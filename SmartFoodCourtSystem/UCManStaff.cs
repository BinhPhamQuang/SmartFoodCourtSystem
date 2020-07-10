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
            tBiduser.Text = dtgListEmployee.Rows[i].Cells["IDUser"].Value.ToString();
            tBname.Text = dtgListEmployee.Rows[i].Cells["Name"].Value.ToString();
            nmAge.Value = Convert.ToInt32(dtgListEmployee.Rows[i].Cells["Age"].Value);
            nmSalary.Value = Convert.ToInt32(dtgListEmployee.Rows[i].Cells["Salary"].Value);
            nmPhone.Value = Convert.ToInt32(dtgListEmployee.Rows[i].Cells["Phonenumber"].Value);
            tBpass.Text = HashMD5.Decrypt(dtgListEmployee.Rows[i].Cells["Password"].Value.ToString());
            tBusername.Text = dtgListEmployee.Rows[i].Cells["Username"].Value.ToString();
            tBtype.Text = HashMD5.Decrypt(dtgListEmployee.Rows[i].Cells["Type"].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tBname.Text;
            int salary = (int)nmSalary.Value;
            int age = (int)nmAge.Value;
            int phone = (int)nmPhone.Value;
            string username = tBusername.Text;
            string password = tBpass.Text;
            string type = tBtype.Text;

            if (EmployeeDAO.Instance.InsertStaff(name, salary, age,phone) && UserDAO.Instance.InsertUser(username,password,type))
            {
                MessageBox.Show("Staff added successfully");
                LoadListEmployee();
            }
            else
            {
                MessageBox.Show("Fail to add a Staff");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tBiduser.Text);
            string name = tBname.Text;
            int salary = (int)nmSalary.Value;
            int age = (int)nmAge.Value;
            int phone = (int)nmPhone.Value;
            string username = tBusername.Text;
            string password = tBpass.Text;
            string type = tBtype.Text;

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
                int id = Convert.ToInt32(tBiduser.Text);
                if (EmployeeDAO.Instance.DeleteStaff(id) && UserDAO.Instance.DeleteUser(id))
                {
                    MessageBox.Show("Staff deleted successfully");
                    LoadListEmployee();
                }
                else
                {
                    MessageBox.Show("Fail to delete dish");
                }
            }
        }
    }
}
