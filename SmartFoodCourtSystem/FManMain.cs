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
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
