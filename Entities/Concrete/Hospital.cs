﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Hospital : IEntity
    {
        public int Id { get; set; }

        public int PoliclinicId { get; set; }

        public string HospitalName { get; set; }

        public string Address { get; set; }
    }
}
