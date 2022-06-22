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
    public partial class ReportBuy : Form
    {
        Invoice invoice;
        public ReportBuy()
        {
            InitializeComponent();
            
        }


        List<Invoice> SortedList = Data.buyInvoiceList.OrderBy(o => o.OrderDate).ToList();

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // MM / dd / yyyy

            string Date_begin = Date_From.Text;
            string Date_end = Date_TO.Text;
            bool flag = false;

            foreach (Invoice item in SortedList)
            { 
                if (item.OrderDate.ToShortDateString() ==  Date_begin)
                {
                    flag = true;
                }
                if (flag)
                {
                    DataGrid1.Rows.Add(item.StoreName, item.Clinte.ClinteName,item.TotalPrice);
                }
                if (item.OrderDate.ToShortDateString() == Date_end)
                {
                    //display the last order
                    flag = false;
                }
            }

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void DataGrid1_SelectionChanged(object sender, EventArgs e)
        {
            DataGrid2.Rows.Clear();
            string Storename = DataGrid1.SelectedRows[0].Cells["ColStore"].Value.ToString();
            string Suppliername = DataGrid1.SelectedRows[0].Cells["ColSupplier"].Value.ToString();
            float Price =float.Parse(DataGrid1.SelectedRows[0].Cells["ColPrice"].Value.ToString());

            foreach (Invoice item in SortedList)
            {
                if(item.StoreName == Storename&& item.Clinte.ClinteName==Suppliername&& item.TotalPrice==Price)
                {
                    invoice = item;
                    break;
                }
            }
            if (invoice != null)
            {
                foreach (Products item in invoice.Products)
                {
                    DataGrid2.Rows.Add(item.Name, item.Quantity);

                }
            }

        }

        private void Date_TO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
