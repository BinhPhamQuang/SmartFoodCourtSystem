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
    public partial class FManMenu : Form
    {
        public FManMenu()
        {
            InitializeComponent();
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            FManAddDish f = new FManAddDish();
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
