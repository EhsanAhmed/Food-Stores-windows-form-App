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
    struct DataGrid
    {
       public string CategoryName, ProductName;
       public float Price;
       public int Quantity;
       public int availableQuantity;


        public bool Exsist()
        {
            return ProductName !=default;
        }
    }
    public partial class US_Sells : UserControl
    {
        float Totalprice;
        Products SelectedProduct;
        Store SelectedSellStore;
        Category SelectedSellCategory;
        List<DataGrid> dataGrids = new List<DataGrid>();
        DataGrid d;
        public US_Sells()
        {
            InitializeComponent();
            foreach (DataGridViewColumn column in OrderDataGrid.Columns)
            {
                column.ReadOnly = true;
            }
            foreach (Store store in Data.stores)
            {
                ComBoxSellsStore.Items.Add(store.storeName);
            }
            if(Data.customersList.Count > 0)
            {
                foreach(Clinte customer in Data.customersList)
                {
                    ComBoxSellCustomer.Items.Add(customer.ClinteName);
                }
            }
        }
        //Ok
        private void BtnNewCustmer_Click(object sender, EventArgs e)
        {
            addCustomer addNewCustomer = new addCustomer();
            addNewCustomer.ShowDialog();
            Data.customersList.Add(new Clinte(addNewCustomer.CustomerName, addNewCustomer.CustomerPhone, addNewCustomer.CustomerAddress));
            ComBoxSellCustomer.Items.Add(addNewCustomer.CustomerName);
            ComBoxSellCustomer.SelectedItem = addNewCustomer.CustomerName;
        }

        //ok
        private void SellsStoreComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComBoxSellsStore.SelectedIndex !=-1)
            {
                SelectedSellStore = Data.stores.Find(x => x.storeName == ComBoxSellsStore.SelectedItem);
                SellsCategoryComBox.Items.Clear();
                for (int i = 0; i < SelectedSellStore.categoriesList.Count(); i++)
                {
                    Category category = SelectedSellStore.categoriesList[i];
                    SellsCategoryComBox.Items.Add(category.categoryName);
                }
            }
        }
        //ok
        private void SellsCategoryComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSellCategory = SelectedSellStore.categoriesList.Find(x => x.categoryName == SellsCategoryComBox.SelectedItem);
            SellsProdectComBox.Items.Clear();
            for (int i = 0; i < SelectedSellCategory.ProductsList.Count(); i++)
            {
                Products product = SelectedSellCategory.ProductsList[i];
                SellsProdectComBox.Items.Add(product.Name);
            }
        }
        //ok
        private void SellsProdectComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedProduct = SelectedSellCategory.ProductsList.Find(x => x.Name == SellsProdectComBox.SelectedItem);
            
                    Avaialbel.Clear();
                    d = dataGrids.Find(x => x.ProductName == SelectedProduct.Name);
                    if(d.ProductName !=default)
                    {
                          Avaialbel.Text =d.availableQuantity.ToString();
                    }
                    else
                    Avaialbel.Text = SelectedProduct.Quantity.ToString();
                    NumericQuantity.Value = 0;
                    NumericQuantity.Maximum = SelectedProduct.Quantity;
               
           

        }

       
       //OK
        private void SellsBtnAddItem_Click(object sender, EventArgs e)
        {
             d =new DataGrid();
            try
            {
                if(SelectedSellStore == null || SellsCategoryComBox.SelectedItem==null || SellsProdectComBox.SelectedItem==null)
                    throw new Exception("You Must choice all of the store, category and product you want to add..");
                d.CategoryName = SellsCategoryComBox.Text;
                d.ProductName = SellsProdectComBox.Text;
                d.Quantity = int.Parse(NumericQuantity.Value.ToString());
                d.availableQuantity = SelectedProduct.Quantity - d.Quantity;
                d.Price = SelectedProduct.Price;

                if (d.Quantity <= 0)
                    throw new Exception("You Must choice the Quantity You Want..");

                    if (dataGrids.Find(x => x.ProductName == SellsProdectComBox.Text).ProductName == d.ProductName)
                    {
                       throw new Exception("You cant Add this product agine, if you want to make change, please delete the product from Grid and make it agine with new values..");
                    }
                dataGrids.Add(d);
                OrderDataGrid.Rows.Add(d.CategoryName, d.ProductName, d.Quantity, d.Price);
                Totalprice += d.Price * d.Quantity;
                TotalPriceText.Text = Totalprice.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            //SelectedProduct.Quantity -= int.Parse(NumericQuantity.Value.ToString());
        }

         //OK
        private void SellsBtnDeleteItem_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = OrderDataGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    Totalprice -= float.Parse(OrderDataGrid.SelectedRows[0].Cells["ColPrice"].Value.ToString()) * int.Parse(OrderDataGrid.SelectedRows[0].Cells["ColQuantity"].Value.ToString());
                    TotalPriceText.Text = Totalprice.ToString();
                    DataGrid d = dataGrids.Find(x => x.ProductName == OrderDataGrid.SelectedRows[0].Cells["colProduct"].Value.ToString());
                    OrderDataGrid.Rows.RemoveAt(OrderDataGrid.SelectedRows[0].Index);
                    dataGrids.Remove(d);    
                }
            }
            OrderDataGrid.ClearSelection();

        }

        private void SellsBtnSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderDataGrid.Rows.Count == 0)
                    throw new Exception("You Must Added Items to the Invoice");
                Clinte customer = Data.customersList.Find(x => x.ClinteName == ComBoxSellCustomer.SelectedItem);
                if (customer == null)
                    throw new Exception("You Must Choice the customer..");
                Invoice sellsInvoice = new Invoice(SelectedSellStore.storeName,DateTimePicker.Value, Totalprice, customer.ClinteName, customer.ClintePhone, customer.ClinteAddress);
                foreach (DataGrid item in dataGrids)
                {
                    Category category = SelectedSellStore.categoriesList.Find(x => x.categoryName == item.CategoryName);
                    if (category == null)
                        throw new Exception("Somthing Want Wrong.. Please Check that you choice all product from one store '/n' you shoud delete all product from different stores and select the store you want to Sell From ");

                    Products product = SelectedSellCategory.ProductsList.Find(x => x.Name == item.ProductName);
                    if (product != null)
                    {
                        if (product.Quantity <= 0)
                            throw new Exception("Sorry,This Product Not Available now..");
                        product.Quantity = product.Quantity - item.Quantity;
                       
                        sellsInvoice.Products.Add(product);
                    }
                    else
                    {
                        throw new Exception("Somthing Want Wrong.. Please Check that you choice the correct Products.");
                    }
                }
                Data.sellsInvoiceList.Add(sellsInvoice);
                MessageBox.Show($"the Invoice Saved Successfully.. with total ptice: {sellsInvoice.TotalPrice} and date: {sellsInvoice.OrderDate} and customer:{sellsInvoice.Clinte.ClinteName} ");
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            Avaialbel.Text = "";
            Totalprice = 0;
            TotalPriceText.Text = "";
            NumericQuantity.Value = 0;
            dataGrids.Clear();
            OrderDataGrid.Rows.Clear();
            SellsCategoryComBox.Items.Clear();
            SellsProdectComBox.Items.Clear();
            ComBoxSellsStore.SelectedIndex = -1;
            ComBoxSellCustomer.SelectedIndex = -1;
            
        }

        private void SellsBtnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            MessageBox.Show("Invoice Was Canceled..");
        }

        private void ComBoxSellCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Avaialbel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}