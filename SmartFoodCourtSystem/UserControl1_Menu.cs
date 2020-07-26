using SmartFoodCourtSystem.DAO;
using SmartFoodCourtSystem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.Properties;
using System.Globalization;

namespace SmartFoodCourtSystem
{
    public partial class UserControl1_Menu : UserControl
    {
        CultureInfo culture = new CultureInfo("vi-VN");
        public UserControl1_Menu()
        {
             InitializeComponent();
             AutoCompleteSearch();

        }
        void Alert(string msg, FAlert.emType type)
        {
            FAlert frm = new FAlert();
            frm.showAlert(msg, type);

        }
        private int category = 1;
        Panel RectangleFood(Food food)
        {
            Panel panel = new Panel();
            panel.Width = 191;
            panel.Height = 244;
            panel.BackColor = Color.NavajoWhite;
            //------------
            Label lb_name = new Label();
            lb_name.Text = food.name;
            lb_name.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold);
            lb_name.Location = new Point(3, 0);
            lb_name.AutoSize = true;
            //----------

            PictureBox pictureBox = new PictureBox();
           
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new Point(3, 38);
            pictureBox.Margin = new Padding(3, 3, 3, 3);
            pictureBox.Size = new Size(185, 138);
            pictureBox.Click += BtnOrder_Click;
            pictureBox.Tag = food;
            try
            {
                pictureBox.Image = Image.FromFile(food.image);
                 
            }
            catch (Exception a)
            {

                pictureBox.Image = Resources.dishdefault;
            }
             
            //------
            Label pnprice = new Label();
            pnprice.Location = new Point(3, 179);
            pnprice.AutoSize = true;
            pnprice.Text = food.price.ToString("#,### vnđ", culture.NumberFormat);
            pnprice.Font = new Font("Century Gothic", 14.0f);
            pnprice.ForeColor = Color.RoyalBlue;
            
            //---
            if(food.discount!=0)
            {
                Label lbdiscount = new Label();
                lbdiscount.Location = new Point(142, 179);
                lbdiscount.AutoSize = true;
                lbdiscount.Text = "-"+food.discount.ToString() +"%";
                lbdiscount.Font = new Font("Century Gothic", 14.0f);
                lbdiscount.ForeColor = Color.Red;
                panel.Controls.Add(lbdiscount);
            }
            //-----
            Button btnOrder = new Button();
            btnOrder.Location = new Point(1, 207);
            btnOrder.Text = "Order";
            btnOrder.Font = new Font("Century Gothic", 12.0f);
            btnOrder.Size = new Size(190, 31);
            btnOrder.ForeColor = Color.White;
            btnOrder.BackColor = Color.Goldenrod;
            btnOrder.FlatAppearance.MouseOverBackColor = Color.Olive;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Click += BtnOrder_Click;
            btnOrder.Tag = food;
            btnOrder.FlatAppearance.BorderSize = 0;
            //---
            panel.Controls.Add(lb_name);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(pnprice);
            panel.Controls.Add(btnOrder);
            return panel;
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            Food t=null ;

            try
            {
                t = (sender as Button).Tag as Food;
            }
            catch(Exception a)
            {

            }
            if (t == null)
            {
               t = (sender as PictureBox).Tag as Food;
            }
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.getData = t;
            orderDetail.ShowDialog();
        }

        
        public void LoadMenu()
        {
           
            flp_menu.Controls.Clear();
            List<Food> t = FoodDAO.Instance.getFoodbyCategory(category);
            foreach (Food i in t)
            {
                Panel a = RectangleFood(i);
                flp_menu.Controls.Add(a);
            }
        }
        private void UserControl1_Menu_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void tb_searchfood_Enter(object sender, EventArgs e)
        {
            //tb_searchfood.Text = "";
            //tb_searchfood.ForeColor = Color.Black;
             
            //btnclear.Visible = true;

        }

        private void tb_searchfood_Leave(object sender, EventArgs e)
        {
            
        }

        

        private void btnDrink_Click(object sender, EventArgs e)
        {
            category = 0;
            UserControl1_Menu_Load(sender, e);
            btnDrink.BackColor = SystemColors.Highlight;
            btnFood.BackColor = Color.White;
            btnFood.ForeColor = Color.Black;
            btnDrink.ForeColor = Color.White;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            category = 1;
            UserControl1_Menu_Load(sender, e);
            btnFood.BackColor = SystemColors.Highlight;
            btnDrink.BackColor = Color.White;
            btnFood.ForeColor = Color.White;
            btnDrink.ForeColor = Color.Black;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Food> t = FoodDAO.Instance.getFoodByname(tb_searchfood.Text);
            if(t==null)
            {
                 
                
                Alert("Name does not exist!", FAlert.emType.error);
            }
            else
            {
                btnreset.Visible = true;
                flp_menu.Controls.Clear();
                foreach(Food i in t)
                {
                    Panel h = RectangleFood(i);
                    flp_menu.Controls.Add(h);
                }
            }
            
        }
        private void AutoCompleteSearch()
        {
            string query = @"Select Name from Food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            //use LINQ method syntax to pull the Title field from a DT into a string array...
            string[] postSource = data
                                .AsEnumerable()
                                .Select<System.Data.DataRow, String>(x => x.Field<String>("Name"))
                                .ToArray();
            source.AddRange(postSource);
            tb_searchfood.AutoCompleteCustomSource = source;
            tb_searchfood.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tb_searchfood.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
           tb_searchfood.Text = "";
           // btnclear.Visible = false;
          //  tb_searchfood_Leave(sender, e);
            
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            LoadMenu();
            btnreset.Visible = false;
        }

        private void tb_searchfood_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_searchfood_MouseClick(object sender, MouseEventArgs e)
        {
            tb_searchfood.Clear();
            tb_searchfood.ForeColor = Color.Black;

            btnclear.Visible = true;
        }
    }
}
