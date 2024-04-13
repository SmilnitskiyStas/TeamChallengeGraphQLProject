using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool PickUp { get; set; }
        public bool Delivery { get; set; }
        public DateTime Create_at { get; set; }
        public DateTime Delete_at { get; set; }
    }
}
