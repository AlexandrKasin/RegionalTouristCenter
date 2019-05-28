using System;
using System.Collections.Generic;

namespace DomainEntity.Entity.User
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<UserRoles> UserRoles { get; set; }

    
    }
}