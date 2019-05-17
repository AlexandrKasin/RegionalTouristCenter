using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DomainEntity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Repository.Repository;
using Services.DTO;
using Services.Exceptions;
using Services.Extends;


namespace Services.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<User> _repositoryUser;
        private readonly IRepository<Role> _repositoryRole;
        private readonly IRepository<UserRoles> _repositoryUserRoles;
        private readonly IEncryptor _encryptor;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AccountService(IRepository<User> repositoryUser, IConfiguration configuration,
            IEncryptor encryptor, IMapper mapper, IRepository<Role> repositoryRole,
            IRepository<UserRoles> repositoryUserRoles)
        {
            _repositoryUser = repositoryUser;
            _configuration = configuration;
            _encryptor = encryptor;
            _mapper = mapper;
            _repositoryRole = repositoryRole;
            _repositoryUserRoles = repositoryUserRoles;
        }

        private static ClaimsIdentity GetIdentity(User user)
        {
            if (user == null) return null;
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
            };
            claims.AddRange(
                user.UserRoles.Select(role => new Claim(ClaimsIdentity.DefaultRoleClaimType, role.Role.Name)));

            var claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
            return claimsIdentity;
        }

        public async Task<TokenDto> LoginAsync(LoginDto loginParams)
        {
            loginParams.Password = _encryptor.GetHash(loginParams.Password);
            var user = await (await _repositoryUser.GetAllAsync(t =>
                    t.Email == loginParams.Email && t.Password == loginParams.Password)).Include("UserRoles.Role")
                .FirstOrDefaultAsync();

            var identity = GetIdentity(user);
            if (identity == null)
            {
                throw new EntityNotExistException("User with current login params not exists.");
            }

            var now = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
                issuer: _configuration["AuthOption:Issuer"],
                audience: _configuration["AuthOption:Audience"],
                notBefore: now,
                claims: identity.Claims,
                expires: now.Add(TimeSpan.FromMinutes(Convert.ToInt32(_configuration["AuthOption:Lifetime"]))),
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["AuthOption:Key"])),
                    SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new TokenDto
            {
                AccessToken = encodedJwt,
                Username = identity.Name,
                Role = user.UserRoles.Select((role) => role.Role.Name).ToList()
            };
            return response;
        }

        public async Task<TokenDto> RegisterUserAsync(UserRegistrationDto userParams)
        {
            var user = _mapper.Map<User>(userParams);
            var existsEmail = await (await _repositoryUser.GetAllAsync(t => t.Email == user.Email)).AnyAsync();
            if (existsEmail)
            {
                throw new EmailAlreadyExists("This email already exists.");
            }

            var role = await (await _repositoryRole.GetAllAsync(r =>
                string.Equals(r.Name, "User", StringComparison.CurrentCultureIgnoreCase))).FirstOrDefaultAsync();
            if (role == null)
            {
                throw new EntityNotExistException("Role - user, not exists.");
            }

            var systemUser =
                await (await _repositoryUser.GetAllAsync(t => t.Email == _configuration["EmailSystemUser"]))
                    .FirstOrDefaultAsync();
            if (systemUser == null)
            {
                throw new EntityNotExistException("System user with email: " + _configuration["EmailSystemUser"] +
                                                  "not exist");
            }

            user.CreatedBy = systemUser.Id;
            user.Password = _encryptor.GetHash(user.Password);
            await _repositoryUserRoles.InsertAsync(new UserRoles {User = user, Role = role, CreatedBy = systemUser.Id});

            var token = await LoginAsync(new LoginDto
            {
                Email = user.Email,
                Password = userParams.Password
            });
            return token;
        }
    }
}