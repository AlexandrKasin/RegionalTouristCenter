using System.Collections.Generic;

namespace DomainEntity.Entity.Tour
{
    public class TypeTour : BaseEntity
    {
        public string Name { get; set; }
        public long Code { get; set; }

        public ICollection<Tour> Tours { get; set; }
        public Language Language { get; set; }
    }
}