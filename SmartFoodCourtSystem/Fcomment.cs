using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Windows.Forms;
using System.Threading;
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
            Control.CheckForIllegalCrossThreadCalls = false;
           
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

            if (rtb_cmt.Text.Length == 0 || txtEmail.Text.Length == 0)
            {
                Alert("Error !", FAlert.emType.error);
                pn_error.Visible = true;
            }
            else
            {
                Alert("Thanks for opinions!", FAlert.emType.success);
                pn_error.Visible = false;
                //Thread mainthread = Thread.CurrentThread;
                Thread thread = new Thread(Send);
                thread.IsBackground = true;
                //  mainthread.Abort();
                //  thread.Start();
                //  mainthread.Start();
                thread.Start();
            }
        }
        public void Send()
        {
            FileStream fs = new FileStream("D:\\SmartFoodCourtSystem\\SmartFoodCourtSystem\\bin\\Debug\\File\\gmail.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string email;
            while ((email = sr.ReadLine()) != null)
            {
                sendmail("voquocbao@gmail.com", email, "Opinion for " + rbproduct.Text, "");

            }
            sr.Close();
        }
        public void sendmail(string from, string to, string subject, string message)
        {
            message = rtb_cmt.Text;
            string body;
            if (rbproduct.Checked == true)
                subject = "Opinion for " + subject;
            else
                subject = "Opinion for " + subject;


            if (rbfemale.Checked == true)
                body = "Customer Name: " + txtName.Text + "\n" + "Email: " + txtEmail.Text + "\n" + "Sex: " + rbfemale.Text + "\n" + "Content: " + message;
            else if (rbmale.Checked == true)
                body = "Customer Name: " + txtName.Text + "\n" + "Email: " + txtEmail.Text + "\n" + "Sex: " + rbmale.Text + "\n" + "Content: " + message;
            else
                body = "Customer Name: " + txtName.Text + "\n" + "Email: " + txtEmail.Text + "\n" + "Sex: " + rbother.Text + "\n" + "Content: " + message;

            MailMessage mess = new MailMessage(from, to, subject, body);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("voquocbaonana@gmail.com", "voquocbao");
            client.Send(mess);
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
