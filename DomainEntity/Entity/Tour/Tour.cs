using System;
using System.Collections;
using System.Collections.Generic;

namespace DomainEntity.Entity.Tour
{
    public class Tour : BaseEntity
    {
        public int AmountDays { get; set; }

        public ICollection<DatesPrices> DatesPrices { get; set; }
        public ICollection<TourDescription> TourDescriptions { get; set; }
        public ICollection<TourImages> TourImages { get; set; }
    }
}