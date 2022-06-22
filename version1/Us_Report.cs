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
    public partial class Us_Report : UserControl
    {
        public Us_Report()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelReportBody.Controls.Add(childForm);
            PanelReportBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ReportBuy());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ReportSell());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ReportStore());
        }





        //private void BtnReportBuy_Click(object sender, EventArgs e)
        //{
        //    openChildFormInPanel(new ReportBuy());
        //}

        //private void BtnReportSell_Click(object sender, EventArgs e)
        //{
        //    openChildFormInPanel( new ReportSell());
        //}

        //private void BtnReportStore_Click(object sender, EventArgs e)
        //{
        //    openChildFormInPanel(new ReportStore());
        //}
    }
}
