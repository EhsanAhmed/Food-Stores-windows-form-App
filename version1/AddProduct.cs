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
    public partial class AddProduct : Form
    {
        public event EventHandler setproducts;
        int Qantity;
        float Price;
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
             Data.SelectedCategory.ProductsList.Add(new Products(ProductName.Text,Price, Qantity));
            if (setproducts != null)
                setproducts(this , new EventArgs());   
            this.Close();
        }
       

        private void ProductName_TextChanged(object sender, EventArgs e)
        {
            if (ProductName.Text.Length < 3)
            {
                validName.Visible = true;
            }
            else
            {
                validName.Visible = false;
            }
           

            if (ProductQuantity.Text !="" && ProductPrice.Text!="")
                AddProductBtn.Enabled = true;

        }

        private void ProductPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Price = float.Parse(ProductPrice.Text);
            }
            catch
            {
                MessageBox.Show("Price must be a number");
            }
            if (ProductQuantity.Text != "" && ProductName.Text != "")
                AddProductBtn.Enabled = true;
        }

        private void ProductQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Qantity = int.Parse(ProductQuantity.Text);
            }
            catch
            {
                MessageBox.Show("Qantity must be a number");
            }
            if (ProductName.Text != "" && ProductPrice.Text != "")
                AddProductBtn.Enabled = true;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
