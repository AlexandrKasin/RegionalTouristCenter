﻿using System;

namespace Services.DTO.User
{
    public class UserRegistrationDTO
    {
        public string Name { get; set; }
        public string SUrname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
