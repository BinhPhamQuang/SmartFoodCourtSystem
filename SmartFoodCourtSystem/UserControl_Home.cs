using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.DAO;
using SmartFoodCourtSystem.DTO;
using SmartFoodCourtSystem.Properties;
using System.Globalization;

namespace SmartFoodCourtSystem
{
    public partial class UserControl_Home : UserControl
    {
        CultureInfo culture = new CultureInfo("vi-VN");
        public UserControl_Home()
        {
            InitializeComponent();
        }
        private Food t = null;
        private void UserControl_Home_Load(object sender, EventArgs e)
        {
            List<Food> listfood = FoodDAO.Instance.getFoodbyCategory(1);
            Food t = listfood[0];
            foreach (Food i in listfood)
            {
                if (i.discount > t.discount)
                    t = i;
            }
            this.t = t;
            try
            {
               picturebox1.Image = Image.FromFile(t.image);

            }
            catch (Exception a)
            {

                picturebox1.Image = Resources.dishdefault;
            }
            lb_price.Text = (t.price * (100 - t.discount)/100).ToString("#,### vnđ", culture.NumberFormat);
            lb_prevprice.Text = t.price.ToString("#,### vnđ", culture.NumberFormat);
            lb_discount.Text = "- "+t.discount.ToString() + "%";
            lb_namefood.Text = t.name;
            richTextBox_detailfoodinfo.Text = t.description;
        }

        private void btn_Ordernow_Click(object sender, EventArgs e)
        {
           
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.getData = t;
            orderDetail.ShowDialog();
        }

        private void lb_discount_Click(object sender, EventArgs e)
        {

        }
    }
}
