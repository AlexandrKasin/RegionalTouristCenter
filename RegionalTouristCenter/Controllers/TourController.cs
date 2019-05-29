using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.DTO.Tour;
using Services.Services.TourService;

namespace RegionalTouristCenter.Controllers
{
    public class TourController : ControllerBase
    {
        private readonly ITourService _tourService;

        public TourController(ITourService tourService)
        {
            _tourService = tourService;
        }

        [HttpPost("/create/tour")]
        public async Task<IActionResult> CreateTour([FromForm] TourDTO tour)
        {
            await _tourService.CreateTourAsync(tour);
            return Ok();
        }
    }
}