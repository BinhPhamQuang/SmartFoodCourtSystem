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
using System.Globalization;
using SmartFoodCourtSystem.DAO;
namespace SmartFoodCourtSystem
{
    
    public partial class UC_cart : UserControl
    {
        CultureInfo culture = new CultureInfo("vi-VN");
        public static bool isapplypromotioncode = false;
        void Alert(string msg, FAlert.emType type)
        {
            FAlert frm = new FAlert();
            frm.showAlert(msg, type);

        }
        public event EventHandler ButtonClick;
        Panel RectangleItem(Food food)
        {
            Panel panel = new Panel();
            panel.Size = new Size(418, 146);
            panel.BackColor = SystemColors.MenuHighlight;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(3, 14);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                 
                pictureBox.Image = Image.FromFile(food.image);
                
            }
            catch (Exception a)
            {

                pictureBox.Image = Resources.dishdefault;
            }
            
            pictureBox.Margin = new Padding(3, 3, 3, 3);
            pictureBox.Size = new Size(143, 96);

            Label lbname = new Label();
            lbname.Text = food.name;
            lbname.Font = new Font("Comic Sans MS", 15.25f, FontStyle.Bold);
            lbname.Location = new Point(149, 10);
            lbname.AutoSize = true;
            
             

            

            Label lbsize = new Label();
            lbsize.Text = "Discount:";
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
            btndelete.BringToFront();

            Panel line = new Panel();
            line.BackColor = Color.White;
            line.Location = new Point(3, 135);
            line.Size = new Size(411, 3);

            Label lbnamesize = new Label();
            lbnamesize.Text = food.discount.ToString() + "%";
            lbnamesize.ForeColor = Color.Crimson;
            lbnamesize.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold);
            lbnamesize.Location = new Point(196, 43);
            lbnamesize.AutoSize = false;
            lbnamesize.Size = new Size(170, 19);
            lbnamesize.TextAlign = ContentAlignment.MiddleRight;

            //Label lbdiscount = new Label();
            //lbdiscount.Text = "-" + food.discount.ToString() + "%";
            //lbdiscount.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold);
            //lbdiscount.ForeColor = Color.Red;
            //lbdiscount.Location = new Point(196, 43);
            //lbdiscount.AutoSize = true;
            //lbdiscount.Size = new Size(170, 19);
            //lbdiscount.TextAlign = ContentAlignment.MiddleRight;


            Label lbnamequantity = new Label();
            lbnamequantity.Text = food.quantity.ToString();
            lbnamequantity.ForeColor = SystemColors.GradientActiveCaption;
            lbnamequantity.Font = new Font("Century Gothic", 12.0f, FontStyle.Bold);
            lbnamequantity.Location = new Point(297, 66);
            lbnamequantity.AutoSize = false;
            lbnamequantity.Size = new Size(44, 19);
            lbnamequantity.TextAlign = ContentAlignment.MiddleRight;

            Label lbnameprice = new Label();
            lbnameprice.Text = food.totalprice().ToString("#,### vnđ", culture.NumberFormat) ;
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
         //   if (food.discount != 0)
             // panel.Controls.Add(lbdiscount);
           panel.Controls.Add(lbsize);
           panel.Controls.Add(lbquantity);
            panel.Controls.Add(lbprice);
            panel.Controls.Add(line);
            
            panel.Controls.Add(lbnamesize);
            panel.Controls.Add(lbnamequantity);
            panel.Controls.Add(lbnameprice);
            panel.Controls.Add(btnPlus);
            panel.Controls.Add(btnMinus);
            panel.Controls.Add(btndelete);
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
                lbprice.Text = food.totalprice().ToString("#,### vnđ", culture.NumberFormat) ;
                lbPrice.Text = CaculatePrice().ToString("#,### vnđ", culture.NumberFormat) ;
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
            lbprice.Text = food.totalprice().ToString("#,### vnđ", culture.NumberFormat)   ;
            lbPrice.Text = CaculatePrice().ToString("#,### vnđ", culture.NumberFormat)  ;

        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
             Food food= ((sender as Button).Tag as Food);
            Cart.Instance.DeleteFood(food);
            flp_cart.Controls.Clear();
            LoadCart();
        }

        public UC_cart()
        {
            
            InitializeComponent();
            LoadCart();
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
        public void LoadCart()
        {
            flp_cart.Controls.Clear();
            foreach (Food i in Cart.Instance.getListFood())
            {

                Panel t = RectangleItem(i);
                 
                flp_cart.Controls.Add(t);
            }
            lbPrice.Text = CaculatePrice().ToString("#,### vnđ", culture.NumberFormat) ;
        }
        private void UC_cart_Load(object sender, EventArgs e)
        {
            LoadCart();
        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }

        public void btnPayment_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
             
             
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (Cart.Instance.getListFood().Count != 0)
            {
                Cart.Instance.DeleteCart();
                isapplypromotioncode = false;
                Alert("Done!", FAlert.emType.success);
                LoadCart();
            }
            else
            {
                Alert("Your cart is empty!", FAlert.emType.warning);
            }
            
        }

        private void btnApplyPromotioncode_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Promotioncode";
            DataTable code = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow i in code.Rows)
            {
                if (tbPromotioncode.Text == i["code"].ToString())
                {
                    //bool valid = false;
                    int day = int.Parse(i["dayend"].ToString()) - DateTime.Today.Day;
                    int month = int.Parse(i["monthend"].ToString()) - DateTime.Today.Month;
                    int year = int.Parse(i["yearend"].ToString()) - DateTime.Today.Year ;
                    if (year <0)
                    {
                        Alert("Invalid code", FAlert.emType.error);
                        return;
                        
                    }
                    if (year == 0)
                    {
                        if (month < 0)
                        {
                            Alert("Invalid code", FAlert.emType.error);
                            return;

                        }
                        if (month == 0)
                        {
                            if (day < 0)
                            {
                                Alert("Invalid code", FAlert.emType.error);
                                return;
                            }
                        }
                    }

                     
                }
                 
                if (tbPromotioncode.Text.Length != 0 && tbPromotioncode.Text == i["code"].ToString() && isapplypromotioncode == false)
                {
                    isapplypromotioncode = true;
                    foreach (Food ii in Cart.Instance.getListFood())
                    {
                        ii.discount += int.Parse(i["discount"].ToString());
                        if (ii.discount > 100) ii.discount = 100;
                    }
                    LoadCart();
                    Alert("Valid code", FAlert.emType.success);
                    return;
                }
                
            }
            tbPromotioncode.Clear();
            Alert("Invalid code", FAlert.emType.error);
        }

        private void tbPromotioncode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
