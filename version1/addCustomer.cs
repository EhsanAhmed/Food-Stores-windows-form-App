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
    public partial class addCustomer : Form
    {
        // public event EventHandler setCustomer;
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        long phone;
        public addCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CustomerName = customerName_Txt.Text;
            CustomerPhone = customerPhone_Txt.Text;
            CustomerAddress = customerAddress_Txt.Text;
            this.Close();
        }



        private void addCustomer_Load(object sender, EventArgs e)
        {

        }

       

        private void customerName_TextChanged(object sender, EventArgs e)
        {
            if (customerName_Txt.Text.Length < 3)
            {
                validName.Visible = true;
            }
            else
            {
                validName.Visible = false;
            }
            if ( customerAddress_Txt.Text != "" && customerPhone_Txt.Text.Length == 11)
                BtnAddCustomer.Enabled = true;

          
        }

        private void customerPhone_TextChanged(object sender, EventArgs e)
        {
            bool flag;
            flag = long.TryParse(customerPhone_Txt.Text, out phone);
            if(flag && phone.ToString().Length==11)
            {
                customerPhone_Txt.Text = phone.ToString();
                ValidPhone.Visible = false;

            }

            else
                ValidPhone.Visible = true;

            if (customerName_Txt.Text != "" && customerAddress_Txt.Text != "")
                BtnAddCustomer.Enabled = true;

        }

        private void customerAddress_TextChanged(object sender, EventArgs e)
        {
            if (customerAddress_Txt.Text.Length < 3)
            {
                validAddress.Visible = true;
            }
            else
            {
                validAddress.Visible = false;
            }


            if ( customerName_Txt.Text != "" && customerPhone_Txt.Text.Length == 11)
                BtnAddCustomer.Enabled = true;

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
