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
    public partial class OrderDetail : Form
    {
        public OrderDetail()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            btnSmall.BackColor = SystemColors.MenuHighlight;
            btnMedium.BackColor = Color.White;
            btnLarge.BackColor = Color.White;
            btnSmall.ForeColor = Color.White;
            btnMedium.ForeColor = Color.Black;
            btnLarge.ForeColor = Color.Black;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            btnSmall.BackColor = Color.White;
            btnMedium.BackColor = SystemColors.MenuHighlight;
            btnLarge.BackColor = Color.White;
            btnSmall.ForeColor = Color.Black;
            btnMedium.ForeColor = Color.White;
            btnLarge.ForeColor = Color.Black;
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            btnSmall.BackColor = Color.White;
            btnMedium.BackColor = Color.White;
            btnLarge.BackColor = SystemColors.MenuHighlight;
            btnSmall.ForeColor = Color.Black;
            btnMedium.ForeColor = Color.Black;
            btnLarge.ForeColor = Color.White;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
