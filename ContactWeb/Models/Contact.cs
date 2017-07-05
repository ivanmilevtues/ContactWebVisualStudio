﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models
{
    public class Conctact
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
    }
}