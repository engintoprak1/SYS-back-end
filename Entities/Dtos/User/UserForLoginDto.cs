﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.User
{
    public class UserForLoginDto : IDto
    {
        public string IdentificationNumber { get; set; }
        public string Password { get; set; }
    }
}
