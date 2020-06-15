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

namespace SmartFoodCourtSystem
{
    public partial class UserControl1_Menu : UserControl
    {
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
            PictureBox pictureBox = new PictureBox();
            //----------
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new Point(3, 38);
            pictureBox.Margin = new Padding(3, 3, 3, 3);
            pictureBox.Size = new Size(185, 138);
            pictureBox.ImageLocation = food.image;
            //------
            Label pnprice = new Label();
            pnprice.Location = new Point(3, 179);
            pnprice.AutoSize = true;
            pnprice.Text = food.price.ToString()+"VND";
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
            btnOrder.BackColor = Color.OliveDrab;
            btnOrder.FlatStyle = FlatStyle.Flat;
            //---
            panel.Controls.Add(lb_name);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(pnprice);
            panel.Controls.Add(btnOrder);
            return panel;
        }
        public UserControl1_Menu()
        {
            InitializeComponent();
          

        }

        private void UserControl1_Menu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Food aa = new Food(); aa.name = "Seafood ahh"; aa.price = 122200; aa.discount = 10;
                aa.image = @"C:\Users\Admin\Desktop\SmartFoodCourtSystem\Photos\1.jpg";
                Panel a = RectangleFood(aa);
                flp_menu.Controls.Add(a);
            }
        }

        private void tb_searchfood_Enter(object sender, EventArgs e)
        {
            tb_searchfood.Text = "";
            tb_searchfood.ForeColor = Color.Black;
            ptb_clear.Visible = true;

        }

        private void tb_searchfood_Leave(object sender, EventArgs e)
        {
            tb_searchfood.Text = "Search food";
            tb_searchfood.ForeColor = Color.Gray;
            ptb_clear.Visible = false;
        }

        private void ptb_clear_Click(object sender, EventArgs e)
        {
            tb_searchfood.Clear();
        }
    }
}
