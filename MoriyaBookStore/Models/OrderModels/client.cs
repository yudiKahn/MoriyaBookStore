using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoriyaBookStore.Models.OrderModels
{
    public class client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Address Address { get; set; }
        public string Mail { get; set; }
        public string PhonNumber { get; set; }
    }
}