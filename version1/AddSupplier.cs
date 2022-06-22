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
    public partial class AddSupplier : Form
    {
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierAddress { get; set; }
        long phone;
        public AddSupplier()
        {
            InitializeComponent();
        }

       
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            SupplierName = SupplierName_txt.Text;
            SupplierPhone = SupplierPhone_txt.Text;
            SupplierAddress = SupplierAddress_txt.Text;
            this.Close();

        }

        private void SupplierName_txt_TextChanged(object sender, EventArgs e)
        {
            if (SupplierName_txt.Text.Length < 3)
            {
                validName.Visible = true;
            }
            else
            {
                validName.Visible = false;
            }
            if (SupplierAddress_txt.Text != "" && SupplierPhone_txt.Text.Length == 11)
                btnAddSupplier.Enabled = true;

            
        }

        private void SupplierPhone_txt_TextChanged(object sender, EventArgs e)
        {
            bool flag;
            flag = long.TryParse(SupplierPhone_txt.Text, out phone);
            if (flag && phone.ToString().Length == 11)
            {
                SupplierPhone_txt.Text = phone.ToString();
                ValidPhone.Visible = false;

            }

            else
                ValidPhone.Visible = true;

            if (SupplierName_txt.Text != "" && SupplierAddress_txt.Text != "")
                btnAddSupplier.Enabled = true;

           
        }

        private void SupplierAddress_txt_TextChanged(object sender, EventArgs e)
        {
            if (SupplierAddress_txt.Text.Length < 3)
            {
                validAddress.Visible = true;
            }
            else
            {
                validAddress.Visible = false;
            }


            if (SupplierName_txt.Text != "" && SupplierPhone_txt.Text.Length == 11)
                btnAddSupplier.Enabled = true;

           
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
