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
    public partial class Cook : Form
    {
        public Cook()
        {
            InitializeComponent();
        }

        private void GetOrderList_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Visible == false)
                dataGridView1.Visible = true;
            else{
                dataGridView1.Visible = false;
            }
        }

        private void GetOrderList_MouseEnter(object sender, EventArgs e)
        {
            GetOrderList.BackColor = Color.FromArgb(219, 216, 216);
        }

        private void GetOrderList_MouseLeave(object sender, EventArgs e)
        {
            GetOrderList.BackColor = Color.FromArgb(34, 36, 45);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
