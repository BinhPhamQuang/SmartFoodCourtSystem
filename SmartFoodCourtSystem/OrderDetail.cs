using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.DTO;
using SmartFoodCourtSystem.Properties;
namespace SmartFoodCourtSystem
{
    public partial class OrderDetail : Form
    {
        CultureInfo culture = new CultureInfo("vi-VN");

        //Thread.CurrentThread.CurrentCulture = culture;

       
        public object getData;

        public OrderDetail()
        {
            InitializeComponent();
        }


        void Alert(string msg, FAlert.emType type)
        {
            FAlert frm = new FAlert();
            frm.showAlert(msg, type);

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lbQuantity.Text)+1;
            lbQuantity.Text = quantity.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lbQuantity.Text) -1;
            if(quantity>0)
            {
                lbQuantity.Text = quantity.ToString();
            }
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            
            Food food = (Food)getData;
            foreach(Food i in Cart.Instance.getListFood())
            {
                if(food.idFood==i.idFood)
                {
                    pn_ordered.Visible = true;
                    if(i.quantity>1)
                    {
                        lb_ordered.Text = i.quantity.ToString() + " items";
                    }
                    else
                    {
                        lb_ordered.Text = i.quantity.ToString() + " item";
                    }
                    

                }
            }
            try
            { 
                ptbImage.Image = Image.FromFile(food.image);
            }
            catch(Exception a)
            {
                
                ptbImage.Image = Resources.dishdefault;
            }
            
            lbName.Text = food.name;
              
            lb_price.Text = food.price.ToString("#,### vnđ", culture.NumberFormat);
            lbDiscount.Text = food.discount.ToString() + "%";
            rtb_description.Text = food.description;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Food food = (Food)getData;

            Food t = new Food();
            t.idFood = food.idFood;
            t.name = food.name;
            t.price = food.price;
            t.quantity = int.Parse(lbQuantity.Text.ToString());
            t.image = food.image;
            t.discount = food.discount;
            t.note = txtNote.Text;

            Cart.Instance.addFood(t);
            Alert("Order successfully !", FAlert.emType.success);
            this.Close();
        }
    }
}
