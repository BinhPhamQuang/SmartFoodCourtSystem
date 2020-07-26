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
        void Alert(string msg, FAlert.emType type)
        {
            FAlert frm = new FAlert();
            frm.showAlert(msg, type);
        }
        string selectedimage = "";

        private void button9_Click(object sender, EventArgs e)
        {
            
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


                try
                {
                    pBfood.Image = Image.FromFile(image);

                }
                catch (Exception a)
                {

                    pBfood.Image = Resources.dishdefault;
                }
                 
                
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
            string image = selectedimage;
            if(name.Length==0 || nmPrice.Value==0)
            {
                Alert("Wrong format", FAlert.emType.error);
                return;
            }
            string query = $"SELECT * from Food WHERE Name ='" + tBname.Text + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count >= 1) MessageBox.Show("Dish already existed in the system");
            else
            {
                if (name == "" || price == 0 )
                {
                    //MessageBox.Show("Wrong format, Unable to add a dish");
                    Alert("Wrong format", FAlert.emType.error);
                }
                else
                {
                    if (FoodDAO.Instance.InsertFood(name, price, description, category, discount, image))
                    {
                        //MessageBox.Show("Dish added successfully");
                        Alert("successfully", FAlert.emType.success);
                        clear();
                        btnAdd.Enabled = false;
             
                        LoadMenu();
                    }
                    else
                    {
                        //MessageBox.Show("Fail to add a dish");
                        Alert("Failed", FAlert.emType.error);
                    }
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
            if (selectedimage == "") selectedimage = dtgListFood.Rows[i].Cells["Image"].Value.ToString();
            string image = selectedimage;
            if (name == "" || price == 0)
            {
                //MessageBox.Show("Wrong format, Unable to add a dish");
                Alert("Wrong format", FAlert.emType.error);
                return;
            }

            if (FoodDAO.Instance.UpdateFood(id, name, price, description, category, discount, image))
            {
                //MessageBox.Show("Dish updated successfully");
                Alert("Successfully", FAlert.emType.success);
                btnNew_Click(sender, e);
                LoadMenu();
            }
            else
            {
                //MessageBox.Show("Fail to update dish");
                Alert("Failed", FAlert.emType.error);
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
                    //MessageBox.Show("Dish deleted successfully");
                    Alert("Successfully", FAlert.emType.success);
                    btnNew_Click(sender, e);
                    LoadMenu();
                }
                else
                {
                    //MessageBox.Show("Fail to delete dish");
                    Alert("Failed", FAlert.emType.error);
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
        private void clear()
        {
            pBfood.Image = null;
            tBdescript.Clear();
            tBname.Text="";
            nmDiscount.Value = 0;
            nmPrice.Value = 0;
            cBcat.SelectedIndex = -1;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            clear();
           // pBfood.Image = Resources.dishdefault;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                selectedimage = dlg.FileName;

                pBfood.Image = Image.FromFile(selectedimage);
            }
        }

        private void cBcat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gBdetail_Enter(object sender, EventArgs e)
        {

        }
    }
}
