using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoriyaBookStore.Models.ContextDB
{
    public class OrderContext : DbContext
    {
        public OrderContext():base("MoriyaDb")
        {
        }
        public DbSet<Order> Orders { get; set; }
        
    }
}