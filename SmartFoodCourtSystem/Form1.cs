using SmartFoodCourtSystem.DAO;
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
    public partial class Form1 : Form
    {
        UCMomo momo;
        public Form1()
        {
            InitializeComponent();
            uC_cart1.ButtonClick += new EventHandler(UserControl_ButtonClick);
            
            uC_payment1.ButtonClick += new EventHandler(UC_Momo_ButtonClick);
            uC_payment1.BtnCancelClick += new EventHandler(UCpayment_cancelClick);
           // userControl1_Menu1.SendToBack();
        }

        private void UCpayment_cancelClick(object sender, EventArgs e)
        {
            btnHome_Click(sender, e);
        }

        private void UC_Momo_ButtonClick(object sender, EventArgs e)
        {
            momo = new UCMomo();
            momo.Location = new Point(0, 0);
            momo.Size = new Size(1020, 490);
            pn_uc.Controls.Add(momo);
            momo.BringToFront();
            momo.ButtonClick += new EventHandler(momo_ButtonClick);



        }
        private void momo_ButtonClick(object sender, EventArgs e)
        {
            pn_uc.Controls.Remove(momo);
            if(momo.paysuccessed==true)
            {
                btnHome_Click(sender, e);
            }
           // Cart.Instance.DeleteCart();s
          //  btnHome_Click(sender, e);
        }
        void Alert(string msg, FAlert.emType type)
        {
            FAlert frm = new FAlert();
            frm.showAlert(msg, type);

        }
        protected void UserControl_ButtonClick(object sender, EventArgs e)
        {
            if(Cart.Instance.getListFood().Count!=0)
            bntPaymentMethod_Click(sender, e);
            else
            {
                Alert("Your cart is empty!", FAlert.emType.warning); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
        #region button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            userControl_Home1.BringToFront();
            btnHome.BackColor = Color.Gray;
             bntMenu.BackColor = panel1.BackColor;
              bntPaymentMethod.BackColor = panel1.BackColor;
             btnDelivery.BackColor = panel1.BackColor;
             btnCart.BackColor = panel1.BackColor;
        }
        private void bntMenu_Click(object sender, EventArgs e)
        {
            
            SidePanel.Height = bntMenu.Height;
            SidePanel.Top = bntMenu.Top;
            userControl1_Menu1.BringToFront();
            //userControl1_Menu2.Size = new Size(960, 459);
            bntMenu.BackColor = Color.Gray;
             btnHome.BackColor = panel1.BackColor;
              bntPaymentMethod.BackColor = panel1.BackColor;
             btnDelivery.BackColor = panel1.BackColor;
             btnCart.BackColor = panel1.BackColor;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {

           
           if (Cart.Instance.getListFood().Count != 0)
            {
                uC_cart1.LoadCart();
                SidePanel.Height = btnCart.Height;
                SidePanel.Top = btnCart.Top;
                uC_cart1.BringToFront();
                btnCart.BackColor = Color.Gray;
                btnHome.BackColor = panel1.BackColor;
                bntPaymentMethod.BackColor = panel1.BackColor;
                btnDelivery.BackColor = panel1.BackColor;
                bntMenu.BackColor = panel1.BackColor;
            }
             else
              {
                 Alert("Please order first!", FAlert.emType.warning);
              }
        }
        #endregion

        private void userControl_Home1_Load(object sender, EventArgs e)
        {
           
        }

        
        public void bntPaymentMethod_Click(object sender, EventArgs e)
        {
            
          if (Cart.Instance.getListFood().Count != 0)
            {
                SidePanel.Height = bntPaymentMethod.Height;
                SidePanel.Top = bntPaymentMethod.Top;
                uC_payment1.BringToFront();
                bntPaymentMethod.BackColor = Color.Gray;
                btnHome.BackColor = panel1.BackColor;
                bntMenu.BackColor = panel1.BackColor;
                btnDelivery.BackColor = panel1.BackColor;
                btnCart.BackColor = panel1.BackColor;
            }
            else
           {
              Alert("Your cart is empty!", FAlert.emType.warning);
            }
        
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            Alert("Delivery unallowed", FAlert.emType.error);
        }
    }
}
