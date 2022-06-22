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
    public partial class EditCategory : Form
    {
        Store store;
        Category category;
        public event EventHandler CategoryChanged;
        public event EventHandler CategoryDeleted;

        public EditCategory()
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
            TextBox1.Text = ComboBox1.SelectedItem.ToString();
             category=store.categoriesList.Find(x => x.categoryName == ComboBox1.SelectedItem);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            category.categoryName= TextBox1.Text.ToString();
            if (CategoryChanged != null)
                CategoryChanged(this, new EventArgs());
            this.Close();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Notice: All Products in this catrgory Will Be Deleted also. ");
            if (dialogResult == DialogResult.OK)
                store.categoriesList.Remove(category);
            if (CategoryDeleted != null)
                CategoryDeleted(this, new EventArgs());
            this.Close();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
                guna2Button1.Enabled = true;
        }
    }
}
