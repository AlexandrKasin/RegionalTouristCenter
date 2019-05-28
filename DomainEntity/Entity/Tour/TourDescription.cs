using System;

namespace DomainEntity.Entity.Tour
{
    public class TourDescription : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }


        public Tour Tour { get; set; }
        public Language Language { get; set; }
    }
}