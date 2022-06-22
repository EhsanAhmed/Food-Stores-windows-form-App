using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version1
{
    internal class Store
    {
        public string storeName { get; set; }
        public string storeLocation { get; set; }
        public List<Category> categoriesList;
       

        public Store(string name , string loaction)
        {
            storeName = name;   
            storeLocation = loaction;
            categoriesList = new List<Category>();

        }
       
    }
}
