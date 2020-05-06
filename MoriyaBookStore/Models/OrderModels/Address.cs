using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoriyaBookStore.Models.OrderModels
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string ZipNumber { get; set; }
    }
}