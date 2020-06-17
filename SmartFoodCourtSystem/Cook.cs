using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Cook : Form
    {
        public Cook()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void GetOrderList_MouseEnter(object sender, EventArgs e)
        {
            GetOrderList.BackColor = Color.FromArgb(219, 216, 216);
        }

        private void GetOrderList_MouseLeave(object sender, EventArgs e)
        {
            GetOrderList.BackColor = Color.FromArgb(34, 36, 45);
        }

        private void GetOrderList_Click(object sender, EventArgs e)
        {

                dataGridView1.Visible = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.DataSource = GetCustomer().Tables[0];
                dataGridView1.Columns["Food"].Visible = false;
                dataGridView1.Columns["Quantity"].Visible = false;
                dataGridView1.Columns["Prices"].Visible = false;
                dataGridView1.Columns["Note"].Visible = false;
                dataGridView1.Columns["State"].Visible = false;

        }
        DataSet GetCustomer()
        {
            DataSet data = new DataSet();

            //SQLconnection

            using(SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("GetInfo", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@param", 0);
                //SqlDataAdapter adapter = new SqlDataAdapter("Select top 5 * from OrderList", connection);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int i = 0;
                IDTextbox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i++].Value.ToString();
                CustomerTextbox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i++].Value.ToString();
                FoodTextbox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i++].Value.ToString();
                QuantityTextbox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i++].Value.ToString();
                PriceTextbox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i++].Value.ToString();
                NoteTextBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i++].Value.ToString();
                StatecomboBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i++].Value.ToString();
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (StatecomboBox.Text == "InQueue")
            {
                StatecomboBox.Text = "Waiting";
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("ContactAddorEdit", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Index + 1);
                    //MessageBox.Show(dataGridView1.CurrentRow.Index.ToString());
                    cmd.Parameters.AddWithValue("@State", "Waiting");
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }       
            }
            else
            {
                MessageBox.Show("Order is being process");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (StatecomboBox.Text == "Waiting")
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("ContactAddorEdit", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    //MessageBox.Show(dataGridView1.CurrentRow.Index.ToString());
                    cmd.Parameters.AddWithValue("@State", "Finished");
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else if (StatecomboBox.Text == "Complete")
            {
                MessageBox.Show("Order is completed, waiting for costumer");
            }
            else
            {
                MessageBox.Show("Order has not been accepted!!");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("ContactDelete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            IDTextbox.Text = CustomerTextbox.Text = FoodTextbox.Text= QuantityTextbox.Text = PriceTextbox.Text = NoteTextBox.Text = StatecomboBox.Text= "";
            GetOrderList_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (StatecomboBox.Text == "Finished")
            {
                BtnCancel_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.OrderList' table. You can move, or remove it, as needed.
            this.orderListTableAdapter.Fill(this.database1DataSet.OrderList);

        }

        private void StatecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
