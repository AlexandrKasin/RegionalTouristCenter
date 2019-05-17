using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Exceptions;
using Services.Services;

namespace RegionalTouristCenter.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login(LoginDto loginParams)
        {
            try
            {
                var response = await _accountService.LoginAsync(loginParams);
                return Ok(response);
            }
            catch (EntityNotExistException e)
            {
                return StatusCode(401, e.Message);
            }
           
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
          
        }

        [HttpPost("/register")]
        public async Task<IActionResult> Register(UserRegistrationDto userRegistration)
        {
            try
            {
                var response = await _accountService.RegisterUserAsync(userRegistration);
                return Ok(response);
            }
            catch (EntityNotExistException e)
            {
                return StatusCode(401, e.Message);
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}