using System.Threading.Tasks;
using Services.DTO;

namespace Services.Services
{
    public interface IAccountService
    {
        Task<TokenDto> LoginAsync(LoginDto loginParams);
        Task<TokenDto> RegisterUserAsync(UserRegistrationDto userParams);
    }
}
