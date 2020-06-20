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
            btndelete.Tag = food;

            Panel line = new Panel();
            line.BackColor = Color.White;
            line.Location = new Point(3, 135);
            line.Size = new Size(411, 3);

            Label lbnamesize = new Label();
            lbnamesize.Text = food.size;
            lbnamesize.ForeColor = SystemColors.GradientActiveCaption;
            lbnamesize.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold);
            lbnamesize.Location = new Point(196, 43);
            lbnamesize.AutoSize = false;
            lbnamesize.Size= new Size(170, 19);
            lbnamesize.TextAlign = ContentAlignment.MiddleRight;

            Label lbnamequantity = new Label();
            lbnamequantity.Text = food.quantity.ToString();
            lbnamequantity.ForeColor = SystemColors.GradientActiveCaption;
            lbnamequantity.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold);
            lbnamequantity.Location = new Point(297, 66);
            lbnamequantity.AutoSize = false;
            lbnamequantity.Size = new Size(44, 19);
            lbnamequantity.TextAlign = ContentAlignment.MiddleRight;

            Label lbnameprice = new Label();
            lbnameprice.Text = food.totalprice().ToString() + "VND";
            lbnameprice.ForeColor = SystemColors.GradientActiveCaption;
            lbnameprice.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold);
            lbnameprice.Location = new Point(207, 90);
            lbnameprice.AutoSize = false;
            lbnameprice.Size = new Size(159, 19);
            lbnameprice.TextAlign = ContentAlignment.MiddleRight;

            Button btnPlus = new Button();
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Location = new Point(347, 66);
            btnPlus.Size = new Size(20, 20);
            btnPlus.ForeColor = SystemColors.MenuHighlight;
            btnPlus.BackColor = SystemColors.MenuHighlight;
            btnPlus.Image = Resources.plus_20px;
            btnPlus.Click += BtnPlus;
            btnPlus.Tag = new {a=lbnamequantity,b=food,c=lbnameprice };

            Button btnMinus = new Button();
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Location = new Point(272, 66);
            btnMinus.Size = new Size(20, 20);
            btnMinus.ForeColor = SystemColors.MenuHighlight;
            btnMinus.BackColor = SystemColors.MenuHighlight;
            btnMinus.Image = Resources.minus_sign_20px;
            btnMinus.Click += BtnMinus;
            btnMinus.Tag = new { a = lbnamequantity, b = food, c = lbnameprice };

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(lbname);
            if (food.discount != 0)
              panel.Controls.Add(lbdiscount);
           panel.Controls.Add(lbsize);
           panel.Controls.Add(lbquantity);
            panel.Controls.Add(lbprice);
            panel.Controls.Add(line);
            panel.Controls.Add(btndelete);
            panel.Controls.Add(lbnamesize);
            panel.Controls.Add(lbnamequantity);
            panel.Controls.Add(lbnameprice);
            panel.Controls.Add(btnPlus);
            panel.Controls.Add(btnMinus);

            return panel;
        }

        private void BtnMinus(object sender, EventArgs e)
        {
            Button t = sender as Button;
            Label label = ((dynamic)t.Tag).a;
            Food food = ((dynamic)t.Tag).b;
            Label lbprice = ((dynamic)t.Tag).c;
            int quantity = int.Parse(label.Text.ToString());
            if (quantity > 1)
            {
                label.Text = (quantity -1).ToString();
                food.quantity = quantity - 1;
                Cart.Instance.editCart(food);
                lbprice.Text = food.totalprice().ToString() + "VND";
                lbPrice.Text = CaculatePrice().ToString() + "VND";
            }
           
        }

        private void BtnPlus(object sender, EventArgs e)
        {

            Button t = sender as Button;
            Label label = ((dynamic)t.Tag).a;
            Food food = ((dynamic)t.Tag).b;
            Label lbprice = ((dynamic)t.Tag).c;
            int quantity=int.Parse(label.Text.ToString());
            
            label.Text = (quantity + 1).ToString();
            
            food.quantity = quantity + 1;
            Cart.Instance.editCart(food);
            lbprice.Text = food.totalprice().ToString() + "VND";
            lbPrice.Text = CaculatePrice().ToString() + "VND";

        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
             Food food= ((sender as Button).Tag as Food);
            Cart.Instance.DeleteFood(food);
            flp_cart.Controls.Clear();
            UC_cart_Load(sender,e);
        }

        public UC_cart()
        {
            
            InitializeComponent();
            hihi();
        }
        void hihi ()
        {
            for (int i = 0; i < 10; i++)
            {
                Food food = new Food();
                food.idFood = i;
                food.name = i.ToString();
                food.discount = 10;
                food.price = 1000;
                food.quantity = 10;
                food.image = @"C:\Users\Admin\Desktop\SmartFoodCourtSystem\Photos\1.jpg";
                flp_cart.Controls.Add(RectangleItem(food));
                Cart.Instance.addFood(food);
            }
        }
        private long CaculatePrice()
        {
            long price = 0;
            foreach (Food i in Cart.Instance.getListFood())
            {
                price += i.totalprice();
                
            }
            return price;
        }
        private void UC_cart_Load(object sender, EventArgs e)
        {
           
            foreach(Food i in Cart.Instance.getListFood())
            {
               
                Panel t = RectangleItem(i);
                flp_cart.Controls.Add(t);
            }
            lbPrice.Text = CaculatePrice().ToString() + "VND";
        }
    }
}
