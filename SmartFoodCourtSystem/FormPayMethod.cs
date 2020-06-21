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
    public partial class FormPayMethod : Form
    {
        public FormPayMethod()
        {
            InitializeComponent();
        }

        private void FormPayMethod_Load(object sender, EventArgs e)
        {
            

        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UC_payment form = new UC_payment();
            form.Show();
        }
    }
}
