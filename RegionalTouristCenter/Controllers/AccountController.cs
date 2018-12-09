using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RegionalTouristCenter.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        AccountController()
        {

        }
        [HttpPost("/login")]
        public async Task<string> Login()
        {
            await Task.Run(() => { });
            return "HEllo";
        }
    }
}