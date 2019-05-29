using System;

namespace Services.DTO.Tour
{
    public class DatesPricesDTO
    {
        public DateTime StarTourtDate { get; set; }
        public DateTime EndTourDate { get; set; }
        public double Price { get; set; }
        public int GroupSize { get; set; }

        public TourDTO Tour { get; set; }
    }
}