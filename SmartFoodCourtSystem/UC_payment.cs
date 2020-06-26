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
using SmartFoodCourtSystem.DAO;
using SmartFoodCourtSystem.Properties;

namespace SmartFoodCourtSystem
{
    public partial class UC_payment : UserControl
    {
        public event EventHandler ButtonClick;
        Panel PanelItem(Food food)
        {
            Panel panel = new Panel();
            panel.Size = new Size(951, 41);
            panel.BackColor = SystemColors.ActiveCaption;
            panel.Location = new Point(6, 96);
            panel.AutoSize = false;

            Label lbName = new Label();
            lbName.Text = food.name + " " + '(' + food.size + ')';
            lbName.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular);
            lbName.Location = new Point(22, 10);
            lbName.AutoSize = false;
            lbName.Size = new Size(248, 21);
            lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            Label lbDiscount = new Label();
            lbDiscount.Text = food.discount.ToString() + "%";
            lbDiscount.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular);
            lbDiscount.ForeColor = Color.Red;
            lbDiscount.Location = new Point(274, 10);
            lbDiscount.AutoSize = false;
            lbDiscount.Size = new Size(52, 21);
            lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //Label lbsize = new Label();
            //lbsize.Text = "Size:";
            //lbsize.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular);
            //lbsize.Location = new Point(208, 10);
            //lbsize.AutoSize = true;
            //lbsize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            Label lbQuantity = new Label();
            lbQuantity.Text = food.quantity.ToString();
            lbQuantity.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular);
            lbQuantity.Location = new Point(434, 10);
            lbQuantity.AutoSize = true;
            lbQuantity.TextAlign =System.Drawing.ContentAlignment.MiddleCenter;


            Label lbPrice = new Label();
            lbPrice.Text = food.totalprice().ToString();
            lbPrice.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular);
            lbPrice.Location = new Point(537, 10);
            lbPrice.Size = new Size(83, 21);
            lbPrice.AutoSize = false;
            lbPrice.TextAlign= System.Drawing.ContentAlignment.MiddleCenter; 


            panel.Controls.Add(lbName);
            panel.Controls.Add(lbDiscount);
            panel.Controls.Add(lbQuantity);
            panel.Controls.Add(lbPrice);
            return panel;

        }
        void Alert(string msg, FAlert.emType type)
        {
            FAlert frm = new FAlert();
            frm.showAlert(msg, type);

        }
        public void pictureBoxMouseClickEventHandler(object sender, EventArgs e)
        {
            if ((sender as PictureBox).BackColor != Color.Lime)
            {

                (sender as PictureBox).BackColor = Color.Lime;
            }
            else
                (sender as PictureBox).BackColor = Color.White;
        }
        public UC_payment()
        {
            InitializeComponent();
            LoadPayment();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.MouseClick += new MouseEventHandler(pictureBoxMouseClickEventHandler);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Alert("Only MOMO", FAlert.emType.warning);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Lime)
            {
                //uC_PayMethod1.Visible = true;
                //this.Hide();
                //FormPayMethod f = new FormPayMethod();
                //f.ShowDialog();
                //this.Show();
                if (this.ButtonClick != null)
                    this.ButtonClick(this, e);
            }
            else
            {
                Alert("Select a payment method", FAlert.emType.warning);
            }
        }

        private void uC_PayMethod1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadPayment();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void LoadPayment()
        {
            flp_foodlist.Controls.Clear();
            foreach (Food i in Cart.Instance.getListFood())
            {

                Panel t = PanelItem(i);

                flp_foodlist.Controls.Add(t);
            }
            lbtotalprice.Text = CaculatePrice().ToString() + "VND";
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Alert("Currently only MOMO", FAlert.emType.warning);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Alert("Only MOMO", FAlert.emType.warning);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Alert("Only MOMO", FAlert.emType.warning);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel order?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // this.Close();
                flp_foodlist.Controls.Clear();
                Cart.Instance.DeleteCart();
                lbtotalprice.Text = "0VND";
                Alert("Thank you!", FAlert.emType.success);
            }
        }
    }
}
