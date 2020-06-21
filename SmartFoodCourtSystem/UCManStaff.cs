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
    public partial class UCManStaff : UserControl
    {
        public UCManStaff()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FManAddStaff f = new FManAddStaff();
            f.ShowDialog();
        }
    }
}
