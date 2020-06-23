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
        public Form1()
        {
            InitializeComponent();
            uC_cart1.ButtonClick += new EventHandler(UserControl_ButtonClick);
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
        }
        private void bntMenu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = bntMenu.Height;
            SidePanel.Top = bntMenu.Top;
            userControl1_Menu1.BringToFront();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {

           
            if (Cart.Instance.getListFood().Count != 0)
            {
                uC_cart1.LoadCart();
                SidePanel.Height = btnCart.Height;
                SidePanel.Top = btnCart.Top;
                uC_cart1.BringToFront();
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

        private void btnManager_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCook_Click(object sender, EventArgs e)
        {
         
        }

        public void bntPaymentMethod_Click(object sender, EventArgs e)
        {
            
          if (Cart.Instance.getListFood().Count != 0)
            {
                SidePanel.Height = bntPaymentMethod.Height;
                SidePanel.Top = bntPaymentMethod.Top;
                uC_payment1.BringToFront();
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
    }
}
