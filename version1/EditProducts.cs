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
    public partial class EditProducts : Form
    {
        Store store;
        Category category;
        Products products;
        public EventHandler productChanged;
        public event EventHandler productsDeleted;
        public EditProducts()
        {
            InitializeComponent();
            foreach (Store store in Data.stores)
            {
                ComBoxStores.Items.Add(store.storeName);
            }
        }

        private void ComBoxStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            store = Data.stores.Find(x => x.storeName == ComBoxStores.SelectedItem);

            for (int i = 0; i < store.categoriesList.Count(); i++)
            {
                Category category = store.categoriesList[i];
                ComboBox1.Items.Add(category.categoryName);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = store.categoriesList.Find(x => x.categoryName == ComboBox1.SelectedItem);
            for (int i = 0; i < category.ProductsList.Count(); i++)
            {
                Products product = category.ProductsList[i];
                ComboBox2.Items.Add(product.Name);
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            products = category.ProductsList.Find(x => x.Name == ComboBox2.SelectedItem);
            TextBox1.Text = products.Name;
            TextBox2.Text = products.Price.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
                guna2Button1.Enabled = true;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            products.Name = TextBox1.Text.ToString();
            if(TextBox3.Text!="")
            {
                bool result;
                float price;
                try
                {
                    result = float.TryParse(TextBox3.Text, out price);
                    if(result)
                        products.Price = price; 
                    else
                    throw new Exception("You Must Enter a number");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if(productChanged!=null)
                productChanged(this, new EventArgs());
            this.Close();


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Notice: You Sure you want to delete this product. ");
            if (dialogResult == DialogResult.OK)
                category.ProductsList.Remove(products);
            if (productsDeleted != null)
                productsDeleted(this, new EventArgs());
            this.Close();

        }
    }
}
