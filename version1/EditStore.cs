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
    public partial class EditStore : Form
    {
        public EventHandler changeStoreName;
        public EventHandler DeleteStore;

        Store store;
        public EditStore()
        {
            InitializeComponent();
            foreach (Store store in Data.stores)
            {
                ComBoxStores.Items.Add(store.storeName);
            }
        }

        private void ComBoxStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComBoxStores.SelectedIndex != -1)
            {
                TextBox1.Text = ComBoxStores.SelectedItem.ToString();
                store = Data.stores.Find(x => x.storeName == ComBoxStores.SelectedItem);
            }
          
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
                store.storeName = TextBox1.Text;
            if (changeStoreName != null)
                changeStoreName(this, new EventArgs());
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          DialogResult dialogResult=  MessageBox.Show("Notice: All Categores and Products in this Store Will Be Deleted also. ");
            if(dialogResult == DialogResult.OK)
                Data.stores.Remove(store);
            if (DeleteStore != null)
                DeleteStore(this, new EventArgs());
              this.Close();


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            if (TextBox1.Text != "")
                guna2Button1.Enabled = true;
        }

        private void Store_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
