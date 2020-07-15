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
                int i = dtgListFood.CurrentRow.Index;
                //tBid.Text = dtgListFood.Rows[i].Cells["IDFood"].Value.ToString();
                tBname.Text = dtgListFood.Rows[i].Cells["Name"].Value.ToString();
                nmPrice.Value = Convert.ToInt32(dtgListFood.Rows[i].Cells["Price"].Value);
                nmDiscount.Value = Convert.ToInt32(dtgListFood.Rows[i].Cells["Discount"].Value);
                int category = Convert.ToInt32(dtgListFood.Rows[i].Cells["Category"].Value);
                if (category == 1)
                {
                    cBcat.Text = "Food";
                }
                else
                {
                    cBcat.Text = "Drink";
                }
                tBdescript.Text = dtgListFood.Rows[i].Cells["Description"].Value.ToString();
                string image = dtgListFood.Rows[i].Cells["Image"].Value.ToString();
                if (image != "") pBfood.Image = Image.FromFile(image);
                else pBfood.Image = Resources.dishdefault;
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string name = tBname.Text;
            int category;
            if (cBcat.Text == "Food") category = 1;
            else category = 0;
            int price = (int)nmPrice.Value;
            int discount = (int)nmDiscount.Value;
            string description = tBdescript.Text;
            //string size = cBsize.Text;
         
            if (name == "" || price == 0 || description == "")
            {
                MessageBox.Show("Wrong format, Unable to add a dish");
            }
            else
            {
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = dtgListFood.CurrentRow.Index;
            int id = Convert.ToInt32(dtgListFood.Rows[i].Cells["IDFood"].Value);
            string name = tBname.Text;
            int category;
            if (cBcat.Text == "Food") category = 1;
            else category = 0;
            int price = (int)nmPrice.Value;
            int discount = (int)nmDiscount.Value;
            string description = tBdescript.Text;
            //string size = cBsize.Text;

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
                int i = dtgListFood.CurrentRow.Index;
                int id = Convert.ToInt32(dtgListFood.Rows[i].Cells["IDFood"].Value);
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgListFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentClick(sender, e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tBdescript.Clear();
            tBname.Clear();
            nmDiscount.Value = 0;
            nmPrice.Value = 0;
            cBcat.SelectedIndex = 0;
            pBfood.Image = Resources.dishdefault;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;

                fileName = dlg.FileName;

                pBfood.Image = Image.FromFile(fileName);
            }
        }
    }
}
