﻿using System;
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
            this.AcceptButton = btnLogin;
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
        //private bool login(string username, string password)
        //{
        //    string query = "SELECT * from User WHERE Password='"+password+"' and Username";
        //    DataTable result = DataProvider.Instance.ExecuteQuery(query);
        //    return result.Rows.Count > 0;
        //}
            private void btnLogin_Click(object sender, EventArgs e)
        {
            //bool re = false;
            //string removableChars = Regex.Escape(@"@&'()<>#");
            //string pattern = "[" + removableChars + "]";
            //string pattern = @"(\W|_|)";
            //this.Alert("Unallowed characters!", FAlert.emType.regex);
            //txtUsername.Text = Regex.Replace(txtUsername.Text, pattern, "");
            //txtPassword.Text = Regex.Replace(txtPassword.Text, pattern, "");
            bool success = false;
            string query = $"SELECT * from User WHERE Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            bool hidden = false;
            //foreach (DataRow r in data.Rows)
            //{
                //if (txtUsername.Text == r["Username"].ToString() && txtPassword.Text == r["Password"].ToString())
                //{
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    int type = int.Parse(row["Type"].ToString());
                    success = true;
                    this.Hide();
                    hidden = true;
                    switch (type)
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
            //}
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
            txtUsername.Text="";
            txtPassword.Text="";
            txtPassword_Leave(sender, e);
            txtUsername_Leave(sender, e);
            this.Show();
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
                if (!check.Checked) txtPassword.UseSystemPasswordChar = true;
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

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
