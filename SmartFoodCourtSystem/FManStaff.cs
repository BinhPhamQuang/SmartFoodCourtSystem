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
    public partial class FManStaff : Form
    {
        public FManStaff()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FManAddStaff f = new FManAddStaff();
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
