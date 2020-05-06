using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoriyaBookStore.Models.BI
{
  public  class Item
    {
        public Item()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }       
        public string ImgUrl { get; set; }
        public int AmountInStack { get; set; }
        public List<category> Categories { get; set; }
    }
}
