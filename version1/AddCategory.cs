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
    public partial class AddCategory : Form
    {
        public event EventHandler setCategory;
        public AddCategory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CategoryName_TextChanged(object sender, EventArgs e)
        {
            if (CategoryName.Text.Length < 3)
            {
                validName.Visible = true;
            }
            else
            {
                validName.Visible = false;
            }


            if (CategoryCode.Text != "" && validName.Visible == false && validName.Visible == false)
                AddCategoryBtn.Enabled = true;

             
        }

        private void CategoryCode_TextChanged(object sender, EventArgs e)
        {
            if(CategoryName.Text !="")
                AddCategoryBtn.Enabled = true;

        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {

            Data.SelectedStore.categoriesList.Add(new Category(CategoryName.Text, CategoryCode.Text));
                if(setCategory !=null)
                  setCategory(this , new EventArgs());

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
