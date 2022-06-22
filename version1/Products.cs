using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version1
{
    internal class Products
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public Products(string name, float price ,int quantity)
        {
            Name = name; Price = price;
            Quantity = quantity;
        }
    }
}
