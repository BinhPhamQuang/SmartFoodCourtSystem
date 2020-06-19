using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.DTO;
using SmartFoodCourtSystem.Properties;
namespace SmartFoodCourtSystem
{
    
    public partial class UC_cart : UserControl
    {
        Panel RectangleItem(Food food)
        {
            Panel panel = new Panel();
            panel.Size = new Size(418, 146);
            panel.BackColor = SystemColors.MenuHighlight;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(3, 14);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.ImageLocation = food.image;
            pictureBox.Margin = new Padding(3, 3, 3, 3);
            pictureBox.Size = new Size(143, 96);

            Label lbname = new Label();
            lbname.Text = food.name;
            lbname.Font = new Font("Century Gothic", 14.25f, FontStyle.Bold);
            lbname.Location = new Point(149, 10);
            lbname.AutoSize = true;

            Label lbdiscount = new Label();
            lbdiscount.Text = food.discount.ToString()+"%";
            lbdiscount.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold);
            lbdiscount.ForeColor = Color.Red;
            lbdiscount.Location = new Point(318, 13);
            lbdiscount.AutoSize = true;

            Label lbsize = new Label();
            lbsize.Text = "Size:";
            lbsize.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold);
            lbsize.Location = new Point(148, 43);
            lbsize.AutoSize = true;


            Label lbquantity = new Label();
            lbquantity.Text = "Quantity:";
            lbquantity.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold);
            lbquantity.Location = new Point(148, 66);
            lbquantity.AutoSize = true;

            Label lbprice = new Label();
            lbprice.Text = "Price:";
            lbprice.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold);
            lbprice.Location = new Point(148, 91);
            lbprice.AutoSize = true;

            Button btndelete = new Button();
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Location = new Point(381, 3);
            btndelete.Size = new Size(34, 32);
            btndelete.BackColor = SystemColors.MenuHighlight;
            btndelete.ForeColor = SystemColors.MenuHighlight;
            btndelete.Image = Resources.cancel_filled_30px;
            btndelete.Click += Btndelete_Click;

            Panel line = new Panel();
            line.BackColor = Color.White;
            line.Location = new Point(3, 135);
            line.Size = new Size(411, 3);

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lbname);
            if (food.discount != 0)
               panel.Controls.Add(lbdiscount);
           panel.Controls.Add(lbsize);
           panel.Controls.Add(lbquantity);
            panel.Controls.Add(lbprice);
            panel.Controls.Add(line);
            panel.Controls.Add(btndelete);
            return panel;
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ahiih");
        }

        public UC_cart()
        {
            InitializeComponent();
        }

        private void UC_cart_Load(object sender, EventArgs e)
        {
            for (int i=0; i<10;i++)
            {
                Food food = new Food();
                food.name = "Egg Tart";
                food.discount = 0;
                food.price = 2000;
                food.image = @"C:\Users\Admin\Desktop\SmartFoodCourtSystem\Photos\1.jpg";
                flp_cart.Controls.Add(RectangleItem(food));
            }
        }
    }
}
