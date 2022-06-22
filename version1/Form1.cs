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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Us_Home home = new Us_Home();
            usercontroal(home);


           
        }


        
        int lx,ly;
        int sw, sh;
        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximazOut_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximazOut.Visible = false;
            btnMaxmiziIn.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void btnMaxmiziIn_Click(object sender, EventArgs e)
        {
            btnMaximazOut.Visible = true;
            btnMaxmiziIn.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //usercontrol
        private void usercontroal(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelbody.Controls.Clear();
            panelbody.Controls.Add(userControl);
            userControl.BringToFront();


        }
       


       

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Us_Home home = new Us_Home();
            usercontroal(home);
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Us_Store store = new Us_Store();
            usercontroal(store);

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Us_Report report = new Us_Report();
            usercontroal(report);
        }

       

        

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            US_Buy buy = new US_Buy();
            usercontroal(buy);
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            US_Sells sell = new US_Sells();
            usercontroal(sell);
        }


        

       
    }
}
