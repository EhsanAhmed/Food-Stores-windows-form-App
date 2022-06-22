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
    public partial class US_Buy : UserControl
    {
        struct US_BuyItem
        {
            public string CategoryName, ProductName, StoreName;
            public float Price;
            public int Quantity;
        }
        float Totalprice;
        Products SelectedProduct;
        Category SelectedBuyCategory;
        Store SelectedBuyStore;
        US_BuyItem d;
        List<US_BuyItem> BuyItemlist =new List<US_BuyItem>();
        public US_Buy()
        {
            InitializeComponent();
            foreach (DataGridViewColumn column in BuyDataGrid.Columns)
            {
                column.ReadOnly = true;
            }
            foreach (Store store in Data.stores)
            {
                ComBoxBuyStore.Items.Add(store.storeName);
            }
            if (Data.supplierList.Count > 0)
            {
                foreach (Clinte supplier in Data.supplierList)
                {
                    ComBoxBuySupplier.Items.Add(supplier.ClinteName);
                }
            }
        }


        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedProduct = SelectedBuyCategory.ProductsList.Find(x => x.Name == BuyProdectComBox.SelectedItem);

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComBoxBuyStore.SelectedIndex != -1)
            {
                SelectedBuyStore = Data.stores.Find(x => x.storeName == ComBoxBuyStore.SelectedItem);
                ComBoBuyCategory.Items.Clear();
                for (int i = 0; i < SelectedBuyStore.categoriesList.Count(); i++)
                {
                    Category category = SelectedBuyStore.categoriesList[i];
                    ComBoBuyCategory.Items.Add(category.categoryName);
                }
            }
        }


        private void BtnSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BuyDataGrid.Rows.Count == 0)
                    throw new Exception("You Must Added Items to the Invoice before save it");
                Clinte supplier = Data.supplierList.Find(x => x.ClinteName == ComBoxBuySupplier.SelectedItem);
                if (supplier == null)
                    throw new Exception("You Must Choice the Supplier..");
                Invoice BuyInvoice = new Invoice(SelectedBuyStore.storeName,DateTimePicker.Value, Totalprice, supplier.ClinteName, supplier.ClintePhone, supplier.ClinteAddress);
                foreach (US_BuyItem item in BuyItemlist)
                {
                    Category category = SelectedBuyStore.categoriesList.Find(x => x.categoryName == item.CategoryName);
                    if (category == null)
                        throw new Exception("Somthing Want Wrong.. Please Check that you choice all product from one store /n you shoud delete all product from different stores and select the store you want to Buy for ");
                    Products product = category.ProductsList.Find(x => x.Name == item.ProductName);
                    if (product != null)
                    {
                        product.Quantity = product.Quantity + item.Quantity;
                        BuyInvoice.Products.Add(product);
                    }
                    else
                    {
                        throw new Exception("Somthing Want Wrong../n Please Cancel the invoic and Try again..");
                    }
                }
                Data.buyInvoiceList.Add(BuyInvoice);
                MessageBox.Show($"the Invoice Saved Successfully.. with total ptice: {BuyInvoice.TotalPrice} and date: {BuyInvoice.OrderDate} and customer:{BuyInvoice.Clinte.ClinteName} ");
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Reset()
        {
            PriceText.Text = "";
            Totalprice = 0;
            TotalPriceText.Text = "";
            NumericQuantity.Value = 0;
            BuyItemlist.Clear();
            BuyDataGrid.Rows.Clear();
            ComBoBuyCategory.Items.Clear();
            BuyProdectComBox.Items.Clear();
            ComBoxBuyStore.SelectedIndex = -1;
            ComBoxBuySupplier.SelectedIndex = -1;

        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = BuyDataGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    Totalprice -= float.Parse(BuyDataGrid.SelectedRows[0].Cells["ColPrice"].Value.ToString());
                    TotalPriceText.Text = Totalprice.ToString();
                    US_BuyItem d = BuyItemlist.Find(x => x.ProductName == BuyDataGrid.SelectedRows[0].Cells["colProduct"].Value.ToString());
                    BuyDataGrid.Rows.RemoveAt(BuyDataGrid.SelectedRows[0].Index);
                    BuyItemlist.Remove(d);
                }
            }
            BuyDataGrid.ClearSelection();
        }

    
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Reset();
            MessageBox.Show("Invoice Was Canceled..");
        }

        private void ComBoBuyCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedBuyCategory= SelectedBuyStore.categoriesList.Find(x => x.categoryName == ComBoBuyCategory.SelectedItem);
            BuyProdectComBox.Items.Clear();
            for (int i = 0; i < SelectedBuyCategory.ProductsList.Count(); i++)
            {
                Products product = SelectedBuyCategory.ProductsList[i];
                BuyProdectComBox.Items.Add(product.Name);
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            d = new US_BuyItem();
            try
            {
                if (SelectedBuyStore == null || ComBoBuyCategory.SelectedItem == null || BuyProdectComBox.SelectedItem == null)
                    throw new Exception("You Must choice all of the store, category and product you want to add..");
                d.StoreName = ComBoxBuyStore.Text;
                d.CategoryName = ComBoBuyCategory.Text;
                d.ProductName = BuyProdectComBox.Text;
                d.Quantity = int.Parse(NumericQuantity.Value.ToString());
                if (float.TryParse(PriceText.Text, out d.Price))
                    d.Price = d.Price;
                else
                    throw new Exception("You Must Enter the Price As a number");

                if (d.Quantity <= 0)
                    throw new Exception("You Must choice the Quantity You Want..");

                if (BuyItemlist.Find(x => x.ProductName == BuyProdectComBox.Text).ProductName == d.ProductName)
                {
                    throw new Exception("You cant Add this product agine, if you want to make change, please delete the product from Grid and make it agine with new values..");
                }
                BuyItemlist.Add(d);
                BuyDataGrid.Rows.Add(d.CategoryName, d.ProductName, d.Quantity, d.Price);
                Totalprice += d.Price;
                TotalPriceText.Text = Totalprice.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddNewSupplierBtn_Click(object sender, EventArgs e)
        {
            AddSupplier addNewsupplier = new AddSupplier();
            addNewsupplier.ShowDialog();
            Data.supplierList.Add(new Clinte(addNewsupplier.SupplierName, addNewsupplier.SupplierPhone, addNewsupplier.SupplierAddress));
            ComBoxBuySupplier.Items.Add(addNewsupplier.SupplierName);
            ComBoxBuySupplier.SelectedItem = addNewsupplier.SupplierName;
        }

        private void ComBoxBuySupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
