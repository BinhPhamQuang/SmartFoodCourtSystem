using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFoodCourtSystem.DTO;
using SmartFoodCourtSystem.DAO;
using System.Windows.Forms;

namespace SmartFoodCourtSystem
{
    public partial class ViewOrder : UserControl
    {
        public ViewOrder(Order order)
        {
            Tag = order;
            InitializeComponent();
            LoadDetail();
        }
        private object tag;

        public object Tag { get => tag; set => tag = value; }

        private void LoadDetail()
        {
            Order order = (Order)Tag;
            try
            {
                OrderIDtextBox.Text = order.OrderID.ToString();
            }
            catch
            {
                OrderIDtextBox.Text = "";
            }
            try
            {
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
            }
            catch
            {
                StatuscomboBox.Text = "";
            }
            if (StatuscomboBox.Text == "Processing")
            {
                BtnConfirm.Visible = true;
                BtnConfirm.Text = "Update";
                BtnConfirm.BackColor = Color.Blue;
            }
            else if (StatuscomboBox.Text == "Finished")
            {
                BtnConfirm.Visible = false;
            }
            else
            {
                BtnConfirm.Visible = true;
                BtnConfirm.Text = "Confirm";
            }
            
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dataGridView.DataSource = order.Detail;
            }
            catch
            {
                dataGridView.DataSource = null;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (StatuscomboBox.Text == "In Queue")
            {
                string query = "Update Bill set status = 1 where IDBill = " + OrderIDtextBox.Text;
                DataProvider.Instance.ExecuteNonQuery(query);

                ((Order)tag).Status = 1;

                LoadDetail();


                FAlert alert = new FAlert();
                alert.showAlert("Processing", FAlert.emType.success);
            }
            else if (StatuscomboBox.Text == "Processing")
            {
                string query = "Update Bill set status = 2 where IDBill = " + OrderIDtextBox.Text;
                DataProvider.Instance.ExecuteNonQuery(query);

                ((Order)tag).Status = 2;

                LoadDetail();


                FAlert alert = new FAlert();
                alert.showAlert("Finished", FAlert.emType.success);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (StatuscomboBox.Text == "Finished")
            {
                string query = "Delete from Bill where IDBill = " + OrderIDtextBox.Text;
                DataProvider.Instance.ExecuteNonQuery(query);

                query = "Delete from BillInfo where IDBill = " + OrderIDtextBox.Text;
                DataProvider.Instance.ExecuteNonQuery(query);

                tag = null;

                LoadDetail();


                FAlert alert = new FAlert();
                alert.showAlert("Deleted", FAlert.emType.success);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (StatuscomboBox.Text == "In Queue")
            {
                string query = "Delete from Bill where IDBill = " + OrderIDtextBox.Text;
                DataProvider.Instance.ExecuteNonQuery(query);

                query = "Delete from BillInfo where IDBill = " + OrderIDtextBox.Text;
                DataProvider.Instance.ExecuteNonQuery(query);

                tag = null;

                LoadDetail();


                FAlert alert = new FAlert();
                alert.showAlert("Cancelled", FAlert.emType.success);
            }
        }
    }
}
