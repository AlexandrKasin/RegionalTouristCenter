using System.Threading.Tasks;
using Services.DTO;
using Services.DTO.User;

namespace Services.Services.UserService
{
    public interface IAccountService
    {
        Task<TokenDTO> LoginAsync(LoginDTO loginParams);
        Task<TokenDTO> RegisterUserAsync(UserRegistrationDTO userParams);
    }
}
