﻿using Core.Entities;
using Core.Utilities.Security.JWT;
using System;

namespace Entities.Dtos.User
{
    public class UserLoginResultDto : IDto
    {
        public string AccessToken { get; set; }
        public DateTime TokenExpires { get; set; }
        public string IdentificationNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gsm { get; set; }
    }
}
