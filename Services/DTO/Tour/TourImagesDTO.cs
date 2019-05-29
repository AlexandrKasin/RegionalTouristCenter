using Microsoft.AspNetCore.Http;

namespace Services.DTO.Tour
{
    public class TourImagesDTO
    {
        public string ImageUrl { get; set; }
        public IFormCollection Images { get; set; }

        public TourDTO Tour { get; set; }
    }
}