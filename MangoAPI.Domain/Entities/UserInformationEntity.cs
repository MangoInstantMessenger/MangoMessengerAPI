﻿using System;

namespace MangoAPI.Domain.Entities
{
    public class UserInformationEntity
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDay { get; set; }
        
        public string Website { get; set; }
        public string Address { get; set; }
    }
} 