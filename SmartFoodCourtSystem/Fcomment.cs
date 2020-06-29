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
    public partial class Fcomment : Form
    {
        void Alert(string msg, FAlert.emType type)
        {
            FAlert frm = new FAlert();
            frm.showAlert(msg, type);

        }
        public Fcomment()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void Fcomment_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rtb_cmt.Text.Length == 0 || txtEmail.Text.Length==0)
            {
                Alert("Error !", FAlert.emType.error);
                pn_error.Visible = true;
            }
            else
            {
                pn_error.Visible = false;
            }
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Clear();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if(txtName.Text.Length==0)
            {
                txtName.Text = "anonymous";
            }
        }
    }
}
