using System;
using SmartFoodCourtSystem.DAO;
using SmartFoodCourtSystem.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.Properties;

namespace SmartFoodCourtSystem
{
    public partial class UCManStaff : UserControl
    {
        public UCManStaff()
        {
            InitializeComponent();
            LoadListEmployee();
        }

        public void LoadListEmployee()
        {
            dtgListEmployee.DataSource = EmployeeDAO.Instance.GetListEmployee();
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtgListEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgListEmployee.CurrentRow.Index;
       
            tBname.Text = dtgListEmployee.Rows[i].Cells["Name"].Value.ToString();
            nmAge.Value = Convert.ToInt32(dtgListEmployee.Rows[i].Cells["Age"].Value);
            nmSalary.Value = Convert.ToInt32(dtgListEmployee.Rows[i].Cells["Salary"].Value);
            nmPhone.Value = Convert.ToInt32(dtgListEmployee.Rows[i].Cells["Phonenumber"].Value);
            tBpass.Text = HashMD5.Decrypt(dtgListEmployee.Rows[i].Cells["Password"].Value.ToString());
            tBusername.Text = dtgListEmployee.Rows[i].Cells["Username"].Value.ToString();
            int type = Convert.ToInt32(HashMD5.Decrypt(dtgListEmployee.Rows[i].Cells["Type"].Value.ToString()));
            if (type == 0)
            {
                cBtype.Text = "Cook";
            }
            else cBtype.Text = "Manager";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tBname.Text;
            int salary = (int)nmSalary.Value;
            int age = (int)nmAge.Value;
            int phone = (int)nmPhone.Value;
            string username = tBusername.Text;
            string password = tBpass.Text;
            string type;
            if (cBtype.Text == "Cook") type = "0";
            else type = "1";
            int a = dtgListEmployee.Rows.Count;
            
            string query = $"SELECT * from User WHERE Username='" + tBusername.Text + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count >= 1) MessageBox.Show("User account already existed in the system");
            else
            {
                if (name == "" || salary == 0 || age == 0 || phone == 0 || username == "" || password == "" || type == "")
                {
                    MessageBox.Show("Wrong format, Unable to add a staff");
                }
                else
                {
                    if (EmployeeDAO.Instance.InsertStaff(name, salary, age, phone) && UserDAO.Instance.InsertUser(username, password, type))
                    {
                        MessageBox.Show("Staff added successfully");
                        LoadListEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Fail to add a Staff");
                    }
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = dtgListEmployee.CurrentRow.Index;
            int id = Convert.ToInt32(dtgListEmployee.Rows[i].Cells["IDUser"].Value);
            string name = tBname.Text;
            int salary = (int)nmSalary.Value;
            int age = (int)nmAge.Value;
            int phone = (int)nmPhone.Value;
            string username = tBusername.Text;
            string password = tBpass.Text;
            string type;
            if (cBtype.Text == "Cook") type = "0";
            else type = "1";
            if (EmployeeDAO.Instance.UpdateStaff(id ,name, salary, age, phone) && UserDAO.Instance.UpdateUser(id, username, password, type))
            {
                MessageBox.Show("Staff updated successfully");
                LoadListEmployee();
            }
            else
            {
                MessageBox.Show("Fail to update Staff");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this staff?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int i = dtgListEmployee.CurrentRow.Index;
                int id = Convert.ToInt32(dtgListEmployee.Rows[i].Cells["IDUser"].Value);
                if (EmployeeDAO.Instance.DeleteStaff(id) && UserDAO.Instance.DeleteUser(id))
                {
                    MessageBox.Show("Staff deleted successfully");
                    LoadListEmployee();
                }
                else
                {
                    MessageBox.Show("Fail to delete staff");
                }
            }
        }

        private void dtgListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgListEmployee_CellContentClick(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tBpass.UseSystemPasswordChar = false;
            }
            else
                tBpass.UseSystemPasswordChar = true;
        }

        private void tBusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tBpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
