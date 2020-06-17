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
    public partial class UserControl_Home : UserControl
    {
        public UserControl_Home()
        {
            InitializeComponent();
        }

        private void UserControl_Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ordernow_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.ShowDialog();

        }
    }
}
