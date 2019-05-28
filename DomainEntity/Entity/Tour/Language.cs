using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntity.Entity.Tour
{
    public class Language : BaseEntity
    {
        public string LanguageName { get; set; }

        public ICollection<TourDescription> TourDescriptions { get; set; }
        public ICollection<TourItinerary> TourItineraries { get; set; }
    }
}