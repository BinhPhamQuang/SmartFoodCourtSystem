using SmartFoodCourtSystem.UC;
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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            Login login = new Login();
            AddControlsToPanel(login);
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }



        private void LoginHome_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            AddControlsToPanel(login);
        }

        private void RegisterHome_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            AddControlsToPanel(register);
        }
    }
}
