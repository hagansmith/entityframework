using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkPractice.Models
{
    public class Order
    {
        public virtual int Id { get; set; }
        public virtual int Total { get; set; }
    }
}