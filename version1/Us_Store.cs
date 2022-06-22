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
    public partial class Us_Store : UserControl
    {
        
        public Us_Store()
        {
            InitializeComponent();

            //display stores

           // ComBoxCategory.Items.Clear();
           if(Data.stores.Count() > 0)
            {
                for (int i = 0; i < Data.stores.Count(); i++)
                {
                    Store store = Data.stores[i];
                    ComBoxStores.Items.Add(store.storeName);
                }
            }
           
        }
       
        private void panelstorebody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            AddStore form2 = new AddStore();
            form2.ShowDialog();
            // if(form2.ShowDialog() == DialogResult.OK)
            if (Data.newStore != null)
            ComBoxStores.Items.Add(Data.newStore.storeName);
            
            Data.newStore = null;
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
            activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelstorebody.Controls.Add(childForm);
            panelstorebody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void ComBoxStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddCategory.Enabled = true;
            AddProductBtn.Enabled = false;
            ShowStoreProductGrid.DataSource = null;
            Data.SelectedStore = Data.stores.Find(x => x.storeName == ComBoxStores.SelectedItem);
            ComBoxCategory.Items.Clear();
            for (int i = 0; i < Data.SelectedStore.categoriesList.Count(); i++)
            {
                Category category = Data.SelectedStore.categoriesList[i];
                ComBoxCategory.Items.Add(category.categoryName);
            }
        }
        
        private void AddCategory_Click(object sender, EventArgs e)
        {
            AddCategory addcategoryform = new AddCategory();
            addcategoryform.setCategory += Addcategoryform_setCategory;
            addcategoryform.ShowDialog();
           
        }

        private void Addcategoryform_setCategory(object sender, EventArgs e)
        {
            ComBoxCategory.Items.Clear();
            for (int i = 0; i < Data.SelectedStore.categoriesList.Count(); i++)
            {
                Category category = Data.SelectedStore.categoriesList[i];
                ComBoxCategory.Items.Add(category.categoryName);
            }
        }

        private void StoreGrideVeiw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddProductBtn.Enabled = true;
            Data.SelectedCategory = Data.SelectedStore.categoriesList.Find(x => x.categoryName == ComBoxCategory.SelectedItem);

            ShowStoreProductGrid.DataSource = null;
            ShowStoreProductGrid.DataSource = Data.SelectedCategory.ProductsList;

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();
            product.setproducts += AddProductform_setproducts;
            product.ShowDialog();
        }

        

        private void ProductcheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddProductform_setproducts(object sender, EventArgs e)
        {
            ShowStoreProductGrid.DataSource = null;
            ShowStoreProductGrid.DataSource = Data.SelectedCategory.ProductsList;
           
        }

        private void ShowStoreProductGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            EditStore editStore = new EditStore();
            editStore.changeStoreName += ChangeStore;
            editStore.DeleteStore += ChangeStore;
            editStore.ShowDialog();
        }

        private void ChangeStore(object sender, EventArgs e)
        {
            ComBoxStores.Items.Clear(); 
            for (int i = 0; i < Data.stores.Count(); i++)
            {
                Store store = Data.stores[i];
                ComBoxStores.Items.Add(store.storeName);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            EditCategory editcategory = new EditCategory();
            editcategory.CategoryChanged += ChangeCategory;
            editcategory.CategoryDeleted += ChangeCategory;
            editcategory.ShowDialog();
        }

        private void ChangeCategory(object sender, EventArgs e)
        {
            if(ComBoxStores.SelectedIndex !=-1)
            {
                ComBoxCategory.Items.Clear();
                for (int i = 0; i < Data.SelectedStore.categoriesList.Count(); i++)
                {
                    Category category = Data.SelectedStore.categoriesList[i];
                    ComBoxCategory.Items.Add(category.categoryName);
                }
            }
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            EditProducts products = new EditProducts();
            products.productChanged += changeProduct;
            products.productsDeleted += changeProduct;
            products.ShowDialog();
        }

        private void changeProduct(object sender, EventArgs e)
        {
            ShowStoreProductGrid.DataSource = null;
            ShowStoreProductGrid.DataSource = Data.SelectedCategory.ProductsList;
        }
    }
}
