using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SmartFoodCourtSystem
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);




        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                lbErrorMessage.Visible = false;
                MessageBox.Show("Login successfully!");
            }
            else
            {
                lbErrorMessage.Text = "";
                lbErrorMessage.Text += "        " + "Incorrect username or password!";
                lbErrorMessage.Visible = true;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked) txtPassword.UseSystemPasswordChar = false;
            else txtPassword.UseSystemPasswordChar = true;
        }
    }
}
