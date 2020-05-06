using MoriyaBookStore.Models.OrderModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoriyaBookStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<BI.Item> MyItems { get; set; }
        public client Client { get; set; }


    }
}