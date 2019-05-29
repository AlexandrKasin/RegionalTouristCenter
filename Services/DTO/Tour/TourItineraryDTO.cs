namespace Services.DTO.Tour
{
    public class TourItineraryDTO
    {
        public int NumberOfDay { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public LanguageDTO Language { get; set; }
        public TourDTO Tour { get; set; }
    }
}