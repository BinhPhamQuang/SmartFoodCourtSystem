using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFoodCourtSystem.DTO;
using System.Windows.Forms;

namespace SmartFoodCourtSystem
{
    public partial class ViewOrder : UserControl
    {
        public ViewOrder(Order order)
        {
            tag = order;
            InitializeComponent();
            LoadDetail();
        }

        public object tag;

        private void LoadDetail()
        {
            Order order = (Order)tag;
            OrderIDtextBox.Text = order.OrderID.ToString();
            switch (order.Status)
            {
                case 0:
                    StatuscomboBox.Text = "In Queue";
                    break;
                case 1:
                    StatuscomboBox.Text = "Processing";
                    break;
                case 2:
                    StatuscomboBox.Text = "Finished";
                    break;
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = order.Detail;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

        }

    }
}
