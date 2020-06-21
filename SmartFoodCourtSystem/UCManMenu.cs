using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFoodCourtSystem
{
    public partial class UCManMenu : UserControl
    {
        public UCManMenu()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FManAddDish f = new FManAddDish();
            f.ShowDialog();
        }
    }
}
