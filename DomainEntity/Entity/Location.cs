using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntity.Entity
{
    public class Location : BaseEntity
    {
        public string City { get; set; }
        public string Country { get; set; }

        public Tour Tour { get; set; }
    }
}
