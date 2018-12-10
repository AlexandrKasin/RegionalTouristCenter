using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntity.Entity
{
    public class TypeTransport : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Tour Tour { get; set; }
    }
}
