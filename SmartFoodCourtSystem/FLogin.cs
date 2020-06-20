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
using SmartFoodCourtSystem.DAO;
using System.Text.RegularExpressions;

namespace SmartFoodCourtSystem
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        void Alert(string msg,FAlert.emType type)
        {
            FAlert frm = new FAlert();
            frm.showAlert(msg, type);
            
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //bool re = false;
            //string removableChars = Regex.Escape(@"@&'()<>#");
            //string pattern = "[" + removableChars + "]";
            string pattern = @"(\W|_|)";
            //this.Alert("Unallowed characters!", FAlert.emType.regex);
            txtUsername.Text = Regex.Replace(txtUsername.Text, pattern, "");
            //txtPassword.Text = Regex.Replace(txtPassword.Text, pattern, "");
            bool success = false;
            string query = $"SELECT * from User";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            bool hidden = false;
            foreach (DataRow r in data.Rows)
            {
                if (txtUsername.Text == r["Username"].ToString() && txtPassword.Text == r["Password"].ToString())
                {
                    success = true;
                    this.Hide();
                    hidden = true;
                    switch (int.Parse(r["Type"].ToString()))
                    {
                        
                        case 0:
                            lbErrorMessage.Visible = false;
                            this.Alert("Login successfully!", FAlert.emType.success);
                            Cook cook = new Cook();
                            cook.Show();
                            break;
                        case 1:
                            lbErrorMessage.Visible = false;
                            this.Alert("Login successfully!", FAlert.emType.success);
                            FManMain manMain = new FManMain();
                            manMain.Show();
                            break;
                    }
                }
            }
            if (!success)
            {
                lbErrorMessage.Text = "";
                lbErrorMessage.Text += "        " + "Incorrect username or password!";
                lbErrorMessage.Visible = true;
                this.Alert("Error!", FAlert.emType.error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (check.Checked || txtPassword.Text == "Password") txtPassword.UseSystemPasswordChar = false;
            else txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLoadOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.LightGray;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.DimGray;
            }
        }
    }
}
