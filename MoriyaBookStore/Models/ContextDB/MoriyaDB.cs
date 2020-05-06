using MoriyaBookStore.Models.BI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace MoriyaBookStore.Models.ContextDB
{
    public class MoriyaDB:DbContext
    {
       
      public  MoriyaDB():base("MoriyaDb") { }

       

     public   DbSet<Item>  GetItems;
        public DbSet<category> GetCategories { get; set; }
    }
}