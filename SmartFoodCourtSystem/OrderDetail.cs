using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.DTO;

namespace SmartFoodCourtSystem
{
    public partial class OrderDetail : Form
    {
        public object getData;

        public OrderDetail()
        {
            InitializeComponent();
        }

         

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            btnSmall.BackColor = SystemColors.MenuHighlight;
            btnMedium.BackColor = Color.White;
            btnLarge.BackColor = Color.White;
            btnSmall.ForeColor = Color.White;
            btnMedium.ForeColor = Color.Black;
            btnLarge.ForeColor = Color.Black;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            btnSmall.BackColor = Color.White;
            btnMedium.BackColor = SystemColors.MenuHighlight;
            btnLarge.BackColor = Color.White;
            btnSmall.ForeColor = Color.Black;
            btnMedium.ForeColor = Color.White;
            btnLarge.ForeColor = Color.Black;
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            btnSmall.BackColor = Color.White;
            btnMedium.BackColor = Color.White;
            btnLarge.BackColor = SystemColors.MenuHighlight;
            btnSmall.ForeColor = Color.Black;
            btnMedium.ForeColor = Color.Black;
            btnLarge.ForeColor = Color.White;
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
            ptbImage.Image = Image.FromFile(food.image);
            lbName.Text = food.name;
            lb_price.Text = food.price.ToString() + "VND";
            lbDiscount.Text = food.discount.ToString() + "%";
            rtb_description.Text = food.description;

        }
    }
}
