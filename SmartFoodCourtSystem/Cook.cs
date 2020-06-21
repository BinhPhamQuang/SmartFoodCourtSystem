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
        }

        private void GetOrderList_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
            }
            string query = $"Select IDBill, Totalprice from Bill";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string query = "Select Name, Quantity, Price, Description from BillInfo inner join Food on BillInfo.IDFood = Food.IDFood where IDBill = '" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IDBill"].Value.ToString() + "'";
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }
    }
}
