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
    public partial class Loginform : Form
    {
        string Name;
        int Password;
        public Loginform()
        {
            InitializeComponent();
        }

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             Name = UserNametextBox.Text;
             Password = Convert.ToInt32(PasswordtextBox.Text);
            if (Name == "Admin" && Password == 1111)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

            }
           
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserNametextBox_TextChanged(object sender, EventArgs e)
        {
            if (UserNametextBox.Text != "Admin")
            {
                LableValidationName.Visible = true;
            }
            else
            {
                LableValidationName.Visible = false;
            }
        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordtextBox.Text != "1111")
            {
                LableValidationPassword.Visible = true;
            }
            else
            {
                LableValidationPassword.Visible = false;
            }
        }
    }
}
