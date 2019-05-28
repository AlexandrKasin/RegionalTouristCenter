using System;

namespace DomainEntity.Entity.Tour
{
    public class DatesPrices : BaseEntity
    {
        public DateTime StarTourtDate { get; set; }
        public DateTime EndTourDate { get; set; }
        public double Price { get; set; }
        public int GroupSize { get; set; }

        public Tour Tour { get; set; }
    }
}