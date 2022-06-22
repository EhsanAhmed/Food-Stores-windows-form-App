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
    public partial class AddStore : Form
    {
       
        public AddStore()
        {
            InitializeComponent();
        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Data.newStore = new Store(StoreName_txt.Text, StoreLocation_txt.Text);

            Data.stores.Add(Data.newStore);
            this.Close();
        }

        private void StoreName_txt_TextChanged(object sender, EventArgs e)
        {
            if (StoreName_txt.Text.Length < 3)
            {
                validName.Visible = true;
            }
            else
            {
                validName.Visible = false;
            }
            if (valiadLocation.Visible == false)
                BtnAddNewStore.Enabled = true;

        }

        private void StoreLocation_txt_TextChanged(object sender, EventArgs e)
        {
            if (StoreLocation_txt.Text.Length < 3)
            {
                valiadLocation.Visible = true;
            }
            else
            {
                valiadLocation.Visible = false;
            }
           

            if ( validName.Visible == false)
                BtnAddNewStore.Enabled = true;

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegisteration_Load(object sender, EventArgs e)
        {

        }
    }
}
