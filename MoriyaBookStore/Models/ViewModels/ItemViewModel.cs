using MoriyaBookStore.Models.BI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoriyaBookStore.Models.ViewModels
{
    public class ItemViewModel
    {
        public Item item { get; set; }
        public List< category> ItemCategores { get; set; }
    }
}