using System.Collections.Generic;

namespace Services.DTO.Tour
{
    public class TourDTO
    {
        public int AmountDays { get; set; }

        public ICollection<DatesPricesDTO> DatesPrices { get; set; }
        public ICollection<TourDescriptionDTO> TourDescription { get; set; }
        public ICollection<TourImagesDTO> TourImages { get; set; }
        public ICollection<TourItineraryDTO> TourItineraries { get; set; }
    }
}