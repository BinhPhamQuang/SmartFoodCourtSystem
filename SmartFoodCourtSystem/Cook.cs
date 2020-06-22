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

namespace SmartFoodCourtSystem
{
    public partial class Cook : Form
    {
        public Cook()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            hideBtn(true);
            design(dataGridView1);
            design(dataGridView2);
        }

        private void GetOrderList_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                hideBtn(false);
                
            }
            else
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                hideBtn(true);

            }
            string query = "Select IDBill, Totalprice, status from Bill";

            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dataGridView1.Columns["status"].Visible = false;
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
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                foreach (Form oForm in Application.OpenForms)
                {
                    if (oForm is FLogin)
                    {
                        oForm.Show();
                        break;
                    }
                }
            }
        }
        private void hideBtn(bool state)
        {
            if (state)
            {
                BtnCancel.Visible = false;
                BtnDelete.Visible = false;
                BtnFinished.Visible = false;
                StateLabel.Visible = false;
                StatetextBox.Visible = false;
            }
            else
            {
                BtnCancel.Visible = true;
                BtnDelete.Visible = true;
                BtnFinished.Visible = true;
                StateLabel.Visible = true;
                StatetextBox.Visible = true;
            }
        }

        private void design(DataGridView dataGridView)
        {
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 92, 152);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void show(string query, DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["status"].Value.ToString() == "0")
                {
                    StatetextBox.Text = "Waiting";
                }
                else
                {
                    StatetextBox.Text = "Finished";
                }

                string query = "Select Name, Quantity, Price, Description" +
                    " from BillInfo " +
                    " inner join Food on BillInfo.IDFood = Food.IDFood " +
                    " where IDBill = '" +
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IDBill"].Value.ToString() + "'";

                show(query, dataGridView2);
                
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (StatetextBox.Text == "Waiting")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel order?", "Cancel order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "Delete from BillInfo where IDBill = '" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IDBill"].Value.ToString() + "'";
                    DataProvider.Instance.ExecuteNonQuery(query);

                    query = "Delete from Bill where IDBill = '" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IDBill"].Value.ToString() + "'";
                    DataProvider.Instance.ExecuteNonQuery(query);
                    MessageBox.Show("Order Cancelled");

                    query = "Select IDBill, Totalprice, status from Bill";
                    show(query, dataGridView1);
                    dataGridView1.Columns["status"].Visible = false;

                    dataGridView2.DataSource = null;
                    StatetextBox.Text = "";
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (StatetextBox.Text == "Finished")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete order?", "Delete order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "Delete from BillInfo where IDBill = '" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IDBill"].Value.ToString() + "'";
                    DataProvider.Instance.ExecuteNonQuery(query);

                    query = "Delete from Bill where IDBill = '" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IDBill"].Value.ToString() + "'";
                    DataProvider.Instance.ExecuteNonQuery(query);
                    MessageBox.Show("Order Deleted");

                    query = "Select IDBill, Totalprice, status from Bill";
                    show(query, dataGridView1);
                    dataGridView1.Columns["status"].Visible = false;

                    dataGridView2.DataSource = null;
                    StatetextBox.Text = "";
                }
            }
        }

        private void BtnFinished_Click(object sender, EventArgs e)
        {
            if (StatetextBox.Text == "Waiting")
            {
                string query = "Update Bill Set status = 1 where IDBill = '" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IDBill"].Value.ToString() + "'";
                DataProvider.Instance.ExecuteNonQuery(query);

                query = "Select IDBill, Totalprice, status from Bill";
                show(query, dataGridView1);
                dataGridView1.Columns["status"].Visible = false;

                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["status"].Value.ToString() == "0")
                {
                    StatetextBox.Text = "Waiting";
                }
                else
                {
                    StatetextBox.Text = "Finished";
                }

                query = "Select Name, Quantity, Price, Description" +
                        " from BillInfo " +
                        " inner join Food on BillInfo.IDFood = Food.IDFood " +
                        " where IDBill = '" +
                        dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IDBill"].Value.ToString() + "'";

                show(query, dataGridView2);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
