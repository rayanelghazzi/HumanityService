﻿using System.Collections.Generic;

namespace HumanityService.DataContracts
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Location> Locations { get; set; }
    }
}