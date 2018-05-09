using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkPractice.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("EntityFramework") { }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}