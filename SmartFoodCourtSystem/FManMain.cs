using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFoodCourtSystem
{
    public partial class FManMain : Form
    {
        UCManMain ucManMain2;
        UCManMenu ucManMenu2;
        UCManStaff ucManStaff1;
        UCReport ucReport1;
        UCpromotioncode uCpromotioncode1;
        public FManMain()
        {
            InitializeComponent();
            timer1.Start();
            lbday.Text = DateTime.Now.ToString("D");
            ucManMain2 = new UCManMain();
           // ucManMain2.Location = new Point(200, 46);
           // ucManMain2.Size = new Size(840, 594);

            ucManMenu2 = new UCManMenu();


            ucManStaff1 = new UCManStaff();


            ucReport1 = new UCReport();

            uCpromotioncode1 = new UCpromotioncode();

            pnuc.Controls.Add(ucManMain2);
            pnuc.Controls.Add(ucManMenu2);
            pnuc.Controls.Add(ucManStaff1);
            pnuc.Controls.Add(ucReport1);
            pnuc.Controls.Add(uCpromotioncode1);
            ucManMain2.BringToFront();

        }

        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                foreach (Form oForm in Application.OpenForms)
                {
                    if (oForm is FLogin)
                    {
                        oForm.Show();
                        break;
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManHome_Click(object sender, EventArgs e)
        {
            ucManMain2.BringToFront();
           panel2.Height = btnManHome.Height;
            panel2.Top = btnManHome.Top;
        }

        private void btnEditMenu_Click_1(object sender, EventArgs e)
        {
            ucManMenu2.BringToFront();
            panel2.Height = btnEditMenu.Height;
            panel2.Top = btnEditMenu.Top;
        }

        private void btnEditStaff_Click_1(object sender, EventArgs e)
        {
            ucManStaff1.BringToFront();
            panel2.Height = btnEditStaff.Height;
            panel2.Top = btnEditStaff.Top;
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            ucReport1.BringToFront();
            panel2.Height = btnViewReport.Height;
            panel2.Top = btnViewReport.Top;
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                foreach(Form i in Application.OpenForms)
                {
                    if(i is FLogin)
                    {
                        i.Show();
                    }
                }
                 
            }
        }

        private void ucManMain1_Load(object sender, EventArgs e)
        {

        }

        private void ucReport1_Load(object sender, EventArgs e)
        {

        }

        private void ucManMenu1_Load(object sender, EventArgs e)
        {

        }

        private void btnpromotioncode_Click(object sender, EventArgs e)
        {
           
            panel2.Height = btnpromotioncode.Height;
            panel2.Top = btnpromotioncode.Top;
            uCpromotioncode1.BringToFront();
            panel2.BringToFront();
        }

        private void FManMain_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtoday.Text = DateTime.Now.ToString("t");
        }
    }
}
