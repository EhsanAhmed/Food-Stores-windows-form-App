using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version1
{
    internal class Category
    {
        public string categoryName { get; set; }
        public string categoryBarCode { get; set; }

       public List<Products> ProductsList;
        public Category(string name, string barcode )
        {
            ProductsList = new List<Products>();
            categoryBarCode = barcode;
            categoryName  = name; 

        }

    }
}
