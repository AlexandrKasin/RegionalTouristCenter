using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Exceptions;
using Services.Services;

namespace RegionalTouristCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourController : ControllerBase
    {
        private readonly ITourService _tourService;
        public TourController(ITourService tourService)
        {
            _tourService = tourService;
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login(SearchOptionDTO serSearchOptions)
        {
            try
            {
                var response = await _tourService.GetAllTourByParamsAsync();
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