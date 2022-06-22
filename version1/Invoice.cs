using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version1
{
    internal class Invoice:IComparable<Invoice>
    {
        public string StoreName { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalPrice { get; set; }

        public Clinte Clinte;
        public List<Products> Products;
        public Invoice(string name, DateTime data, float price, string customername, string phone, string address)
        {
            StoreName = name;
            OrderDate = data;
            TotalPrice = price;
            Products = new List<Products>();
            Clinte = new Clinte(customername, phone, address);
        }

        public int CompareTo(Invoice other)
        {
            return this.OrderDate < other.OrderDate ? -1 : 1;
        }
    }
}
