namespace Services.DTO.Tour
{
    public class TourDescriptionDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }


        public TourDTO Tour { get; set; }
        public LanguageDTO Language { get; set; }
    }
}