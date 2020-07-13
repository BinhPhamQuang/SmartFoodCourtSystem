using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SmartFoodCourtSystem.DAO;
using System.Text.RegularExpressions;
using SmartFoodCourtSystem.DTO;

namespace SmartFoodCourtSystem
{
    public partial class ViewOrderList : UserControl
    {
        public ViewOrderList()
        {
            InitializeComponent();
            LoadOrderList();
            comboBox1.SelectedIndex = 0;
        }
        GradientPanel Square(Order order)
        {
            GradientPanel panel = new GradientPanel();
            panel.Size = new Size(225, 200);
            panel.TopColor = Color.FromArgb(155, 155, 155);
            panel.BackColor = Color.FromArgb(34, 36, 45);
            panel.Angle = 60;
            panel.Margin = new Padding(20);
            panel.AutoScroll = true;
            /*panel.BackgroundImage = Properties.Resources.pre_school_order;
            panel.BackgroundImageLayout = ImageLayout.Stretch;*/


            Label OrderID = new Label();
            OrderID.Size = new Size(200, 25);
            OrderID.Text = "OrderID : " + order.OrderID.ToString();
            OrderID.AutoSize = false;
            OrderID.TextAlign = ContentAlignment.MiddleCenter;
            OrderID.Left = OrderID.Location.X + (panel.Width - OrderID.Size.Width) / 2;
            OrderID.ForeColor = Color.FromArgb(34, 36, 45);
            // OrderID.BackColor = Color.FromArgb(80, 80, 80);
            OrderID.BackColor = Color.Transparent;
            OrderID.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold);
            OrderID.Margin = new Padding(10);

            Label TotalPrice = new Label();
            TotalPrice.Size = new Size(200, 25);
            TotalPrice.Text = "Price : " + order.TotalPrice.ToString() + " VND";
            TotalPrice.AutoSize = false;
            TotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            TotalPrice.Left = TotalPrice.Location.X + (panel.Width - TotalPrice.Size.Width) / 2;
            TotalPrice.Top = TotalPrice.Location.Y + OrderID.Height + 20;
            TotalPrice.ForeColor = Color.FromArgb(34, 36, 45);
            TotalPrice.BackColor = Color.Transparent;
            TotalPrice.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold);
            TotalPrice.Margin = new Padding(10);

            Label Status = new Label();
            Status.Size = new Size(200, 25);
            string temp = null;
            switch (order.Status)
            {
                case 0:
                    temp = "In Queue";
                    break;
                case 1:
                    temp = "Processing";
                    break;
                case 2:
                    temp = "Finished";
                    break;
            }
            Status.Text = "Status : " + temp;
            Status.AutoSize = false;
            Status.TextAlign = ContentAlignment.MiddleCenter;
            Status.Left = Status.Location.X + (panel.Width - Status.Size.Width) / 2;
            Status.Top = Status.Location.Y + OrderID.Height + TotalPrice.Height + 40;
            Status.ForeColor = Color.FromArgb(34, 36, 45);
            Status.BackColor = Color.Transparent;
            Status.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold);
            Status.Margin = new Padding(10);

            Button btnViewOrder = new Button();
            btnViewOrder.Size = new Size(150, 35);
            btnViewOrder.Text = "View Order";
            btnViewOrder.TextAlign = ContentAlignment.MiddleCenter;
            btnViewOrder.Dock = DockStyle.Bottom;
            btnViewOrder.ForeColor = Color.White;
            btnViewOrder.BackColor = Color.OliveDrab;
            btnViewOrder.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold);
            btnViewOrder.FlatStyle = FlatStyle.Flat;
            btnViewOrder.Click += BtnViewOrder_Click;
            btnViewOrder.Tag = order;
            btnViewOrder.Margin = new Padding(20);


            panel.Controls.Add(OrderID);
            panel.Controls.Add(TotalPrice);
            panel.Controls.Add(Status);
            panel.Controls.Add(btnViewOrder);

            return panel;
        }
        public void LoadOrderList(string request = "All")
        {
            int temp = -1;
            switch (request)
            {
                case "In Queue":
                    temp = 0;
                    break;
                case "Processing":
                    temp = 1;
                    break;
                case "Finished":
                    temp = 2;
                    break;
            }
            ListOfOrder.Controls.Clear();
            List<Order> orders = OrderList.Instance.LoadOrderList();
            foreach (Order order in orders)
            {
                Panel item = Square(order);

                switch (order.Status)
                {
                    case 0:
                        item.BackColor = Color.Wheat;
                        break;
                    case 1:
                        item.BackColor = Color.Yellow;
                        break;
                    case 2:
                        item.BackColor = Color.Green;
                        break;

                }

                if (temp == -1)
                    ListOfOrder.Controls.Add(item);
                else if(order.Status == temp)
                {
                    ListOfOrder.Controls.Add(item);
                }
            }
        }
        private void BtnViewOrder_Click(object sender, EventArgs e)
        {
            Cook.Instance.controlpanel.Controls.Clear();
            ViewOrder view = new ViewOrder((sender as Button).Tag as Order);
            Cook.Instance.controlpanel.Controls.Add(view);
            Cook.Instance.controlpanel.Controls["ViewOrder"].BringToFront();
            
        }

        private void backward_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadOrderList(comboBox1.Text);
        }
    }
}
