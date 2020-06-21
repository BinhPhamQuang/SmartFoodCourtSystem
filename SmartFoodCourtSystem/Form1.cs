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

namespace SmartFoodCourtSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
        #region button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            uC_cart1.LoadCart();
            SidePanel.Height = btnCart.Height;
            SidePanel.Top = btnCart.Top;
            uC_cart1.BringToFront();
        }
        #endregion

        private void userControl_Home1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnManager.Height;
            SidePanel.Top = btnManager.Top;
            this.Hide();
            FLogin l = new FLogin();
            l.ShowDialog();
            this.Show();
        }

        private void BtnCook_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cook cook = new Cook();
            cook.ShowDialog();
            this.Show();
        }

        private void bntPaymentMethod_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            panel5.Controls.Add(uC_payment1);
            SidePanel.Height = bntPaymentMethod.Height;
            SidePanel.Top = bntPaymentMethod.Top;
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
