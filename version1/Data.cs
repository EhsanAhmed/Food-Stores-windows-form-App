using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version1
{
    internal class Data
    {
        public static List<Store> stores= new List<Store>();
        public static List<Clinte> customersList = new List<Clinte>();
        public static List<Clinte> supplierList = new List<Clinte>();
        public static List<Invoice> sellsInvoiceList= new List<Invoice>();
        public static List<Invoice> buyInvoiceList= new List<Invoice>();

        public static Store newStore ;
        public static Store SelectedStore;
        public static Store SelectedSellStore;
        public static Category SelectedSellCategory ;
        public static Category SelectedCategory;

        public static Clinte SelectedCustomer ;
        public static Clinte newCustomer ;
    }
}
