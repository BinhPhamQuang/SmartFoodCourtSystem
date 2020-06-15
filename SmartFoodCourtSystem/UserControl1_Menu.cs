using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFoodCourtSystem
{
    public partial class UserControl1_Menu : UserControl
    {
        Panel RectangleFood()
        {
            Panel panel = new Panel();
            panel.Width = 191;
            panel.Height = 244;
            panel.BackColor = Color.NavajoWhite;
            return panel;
        }
        public UserControl1_Menu()
        {
            InitializeComponent();
          

        }

        private void UserControl1_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
