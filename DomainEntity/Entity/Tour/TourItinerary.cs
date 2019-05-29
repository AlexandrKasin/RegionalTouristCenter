using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntity.Entity.Tour
{
    public class TourItinerary : BaseEntity
    {
        public int NumberOfDay { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Language Language { get; set; }
        public Tour Tour { get; set; }
    }
}