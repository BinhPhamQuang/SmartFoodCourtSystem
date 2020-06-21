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
        public FManMain()
        {
            InitializeComponent();
        }

        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            FManMenu f = new FManMenu();
            f.ShowDialog();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            FManStaff f = new FManStaff();
            f.ShowDialog();
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
            ucManMain1.BringToFront();
        }

        private void btnEditMenu_Click_1(object sender, EventArgs e)
        {
            ucManMenu1.BringToFront();
        }

        private void btnEditStaff_Click_1(object sender, EventArgs e)
        {
            ucManStaff1.BringToFront();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            ucReport1.BringToFront();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
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

        private void ucManMain1_Load(object sender, EventArgs e)
        {

        }
    }
}
