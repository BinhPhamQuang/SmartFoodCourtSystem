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
using SmartFoodCourtSystem.DTO;
namespace SmartFoodCourtSystem
{
    public partial class Cook : Form
    {
        private static Cook instance;
        public static Cook Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Cook();
                }
                return instance;
            }
        }


        public Cook()
        {
            InitializeComponent();
        }
        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            foreach (Form i in Application.OpenForms)
            {
                if (i is FLogin)
                {
                    i.Show();
                }
            }
        }


        private void GetOrderList_Click(object sender, EventArgs e)
        {
            ViewOrderList viewOrderList = new ViewOrderList();
            AddControlToPanel(viewOrderList);
        }

        private void GetOrderList_MouseEnter(object sender, EventArgs e)
        {
            GetOrderList.BackColor = Color.FromArgb(142, 153, 165);
        }

        private void GetOrderList_MouseLeave(object sender, EventArgs e)
        {
            GetOrderList.BackColor = Color.FromArgb(34, 36, 45);
        }

        public void AddControlToPanel(Control c)
        {
            controlPanel.Controls.Clear();
            controlPanel.Controls.Add(c);
        }
        public Panel controlpanel
        {
            get { return controlPanel; }
            set { controlPanel = value; }
        }

        private void Cook_Load(object sender, EventArgs e)
        {
            instance = this;
            ViewOrderList abc = new ViewOrderList();
            controlPanel.Controls.Clear();
            controlPanel.Controls.Add(abc);
        }
    }
}
