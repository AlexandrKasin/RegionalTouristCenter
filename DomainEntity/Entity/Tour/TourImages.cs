namespace DomainEntity.Entity.Tour
{
    public class TourImages : BaseEntity
    {
        public string ImageUrl { get; set; }

        public Tour Tour { get; set; }
    }
}