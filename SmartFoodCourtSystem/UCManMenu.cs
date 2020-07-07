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
    public partial class UCManMenu : UserControl
    {
        public UCManMenu()
        {
            InitializeComponent();
            LoadMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FManAddDish f = new FManAddDish();
            f.ShowDialog();
        }
         
        public void LoadMenu()
        {
            dtgListFood.DataSource = FoodDAO.Instance.GetListFood();
        }

        private void UCManMenu_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int i;
                i = dtgListFood.CurrentRow.Index;
                tBid.Text = dtgListFood.Rows[i].Cells["IDFood"].Value.ToString();
                tBname.Text = dtgListFood.Rows[i].Cells["Name"].Value.ToString();
                nmPrice.Value = Convert.ToInt32(dtgListFood.Rows[i].Cells["Price"].Value);
                nmDiscount.Value = Convert.ToInt32(dtgListFood.Rows[i].Cells["Discount"].Value);
                nmCat.Value = Convert.ToInt32(dtgListFood.Rows[i].Cells["Category"].Value);
                tBdescript.Text = dtgListFood.Rows[i].Cells["Description"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tBname.Text;
            int category = (int)nmCat.Value;
            int price = (int)nmPrice.Value;
            int discount = (int)nmDiscount.Value;
            string description = tBdescript.Text;

            if (FoodDAO.Instance.InsertFood(name, price, description, category, discount))
            {
                MessageBox.Show("Dish added successfully");
                LoadMenu();
            }
            else
            {
                MessageBox.Show("Fail to add a dish");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tBid.Text);
            string name = tBname.Text;
            int category = (int)nmCat.Value;
            int price = (int)nmPrice.Value;
            int discount = (int)nmDiscount.Value;
            string description = tBdescript.Text;

            if (FoodDAO.Instance.UpdateFood(id, name, price, description, category, discount))
            {
                MessageBox.Show("Dish updated successfully");
                LoadMenu();
            }
            else
            {
                MessageBox.Show("Fail to update dish");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this dish?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(tBid.Text);
                if (FoodDAO.Instance.DeleteFood(id))
                {
                    MessageBox.Show("Dish deleted successfully");
                    LoadMenu();
                }
                else
                {
                    MessageBox.Show("Fail to delete dish");
                }
            }
        }
    }
}
