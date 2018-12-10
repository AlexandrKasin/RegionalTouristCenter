using System;
using System.Collections.Generic;
using System.Text;

namespace DomainEntity.Entity
{
    public class Order : BaseEntity
    {
        public string Comment { get; set; }

        private User User { get; set; }
        private Tour Tour { get; set; }
    }
}
