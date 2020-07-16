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
        void Alert(string msg, FAlert.emType type)
        {
            FAlert frm = new FAlert();
            frm.showAlert(msg, type);
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
            tBusername.ReadOnly = true;
            tBname.Text = dtgListEmployee.Rows[i].Cells["Name"].Value.ToString();
            nmAge.Value = Convert.ToInt32(dtgListEmployee.Rows[i].Cells["Age"].Value);
            nmSalary.Value = Convert.ToInt32(dtgListEmployee.Rows[i].Cells["Salary"].Value);
            nmPhone.Text = dtgListEmployee.Rows[i].Cells["Phonenumber"].Value.ToString();
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
            string phone =  nmPhone.Text;
            string username = tBusername.Text;
            string password = tBpass.Text;
            string type;
            if (cBtype.Text == "Cook") type = "0";
            else type = "1";
            int a = dtgListEmployee.Rows.Count;
            
            string query = $"SELECT * from User WHERE Username ='" + tBusername.Text + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count >= 1)
            {
                //MessageBox.Show("User account already existed in the system");
                Alert("User account existed", FAlert.emType.error);
            }

            else
            {
                if (name == "" || salary == 0 || age == 0 || phone.Length == 0 || username == "" || password == "" || type == "")
                {
                    //MessageBox.Show("Wrong format, Unable to add a staff");
                    Alert("Wrong format", FAlert.emType.error);
                }
                else
                {
                    if (EmployeeDAO.Instance.InsertStaff(name, salary, age, phone) && UserDAO.Instance.InsertUser(username, password, type))
                    {
                        //  MessageBox.Show("Staff added successfully");
                        Alert("successfully", FAlert.emType.success);
                        tBusername.ReadOnly = true;
                        btnAdd.Enabled = false;
                        clear();
                        LoadListEmployee();
                    }
                    else
                    {
                        // MessageBox.Show("Fail to add a Staff");
                        Alert("Failed", FAlert.emType.error);
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
            string phone = nmPhone.Text;
            string username = tBusername.Text;
            string password = tBpass.Text;
            string type;
            if (cBtype.Text == "Cook") type = "0";
            else type = "1";
            if (tBname.Text == "" || (int)nmSalary.Value == 0 || age == 0 || phone.Length == 0 || username == "" || password == "" || type == "")
            {
                //MessageBox.Show("Wrong format, Unable to add a staff");
                Alert("Wrong format", FAlert.emType.error);
                return;
            }
            
            if (EmployeeDAO.Instance.UpdateStaff(id ,name, salary, age, phone) && UserDAO.Instance.UpdateUser(id, username, password, type))
            {
               // MessageBox.Show("Staff updated successfully");
                Alert("Successfully", FAlert.emType.success);
                LoadListEmployee();
                clear();
            }
            else
            {
                // MessageBox.Show("Fail to update Staff");
                Alert("Failed", FAlert.emType.error);
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
                    // MessageBox.Show("Staff deleted successfully");
                    Alert("Successfully", FAlert.emType.success);
                    clear();
                    LoadListEmployee();
                }
                else
                {
                    //MessageBox.Show("Fail to delete staff");
                    Alert("Failed", FAlert.emType.error);
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
        private void clear()
        {
            tBname.Clear();
            tBpass.Clear();
            tBusername.Clear();
            nmAge.Value = 0;
            nmPhone.Text = 0.ToString();
            nmSalary.Value = 0;
            cBtype.SelectedIndex = -1;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            tBusername.ReadOnly = false;
            btnAdd.Enabled = true;
            clear();
        }

        private void nmPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
