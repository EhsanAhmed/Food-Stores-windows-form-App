using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace version1
{
    public partial class ReportStore : Form
    {
        public ReportStore()
        {
            InitializeComponent();
            foreach (Store store in Data.stores)
            {
                ComboBox1.Items.Add(store.storeName);
            }
        }
        Store selectedstore;
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            string categoryname, productname, quantity, price;
            selectedstore= Data.stores.Find(x => x.storeName == ComboBox1.SelectedItem);
            foreach(Category category in selectedstore.categoriesList)
            {
                categoryname = category.categoryName;
                foreach(Products product in category.ProductsList )
                {
                    productname = product.Name;
                    quantity = product.Quantity.ToString();
                    price = product.Price.ToString();

                    DataGridView1.Rows.Add(categoryname,productname,quantity,price);
                }
            }
        }
    }
}
