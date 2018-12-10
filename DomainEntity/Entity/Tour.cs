using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntity.Entity
{
    public class Tour : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateStart  { get; set; }
        public DateTime DateEnd { get; set; }
        public int AmountNight { get; set; }
        public int AmountOfNightJourneys  { get; set; }
        public double Price { get; set; }
        public string StartCity { get; set; }

        public ICollection<StepTour> StepTours { get; set; }
        public ICollection<Location> Locations { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<TypeTransport> TypeTransports { get; set; }
        public ICollection<TypeTour> TypeTours { get; set; }
    }
}
