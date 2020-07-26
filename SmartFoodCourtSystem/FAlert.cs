using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.Properties;
namespace SmartFoodCourtSystem
{
    public partial class FAlert : Form
    {
        public FAlert()
        {
            
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        public enum emAction
        {
            wait,
            start,
            close
        }
        
        public enum emType
        {
            success ,
            error ,
            regex,
            warning
        }
        private int x, y; 
        private FAlert.emAction action;

        private void FAlert_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = emAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(this.action)
            {
                case emAction.wait:
                    timer1.Interval = 1000;
                    action = emAction.close;
                    break;
                case emAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x<this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity==1.0)
                        {
                            action = emAction.wait;
                        }
                    }
                    break;
                case emAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity==0.0)
                    {
                        this.Close();
                    }
                    break;
            }
        }

        private void lbmsg_Click(object sender, EventArgs e)
        {

        }

        public void showAlert(string msg,emType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i=1; i<10;i++)
            {
                fname = "alert" + i.ToString();
                FAlert frm = (FAlert)Application.OpenForms[fname];
                if(frm==null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i-5*i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch(type)
            {
                case emType.success:
                    this.ptbcheck.BringToFront();
                    this.BackColor = Color.SeaGreen;
                    break;
                case emType.error:
                    this.ptbsad.BringToFront();
                    this.BackColor = Color.Brown;
                    break;
                case emType.regex:
                    this.ptbexclamation.BringToFront();
                    this.BackColor = Color.DimGray;
                    break;
                case emType.warning:
                    this.ptbexclamation.BringToFront();
                    this.BackColor = Color.Goldenrod;
                    break;


            }
            this.lbmsg.Text = msg;
            
            this.Show();
             
            this.action = emAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
