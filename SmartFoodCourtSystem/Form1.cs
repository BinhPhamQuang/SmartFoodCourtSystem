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
        }
    }
}
