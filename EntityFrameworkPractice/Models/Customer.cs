﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkPractice.Models
{
    public class Customer
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime? InitialDate { get; set; } 
    }
}