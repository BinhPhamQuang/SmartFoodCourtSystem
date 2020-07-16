using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.DTO;
namespace SmartFoodCourtSystem
{
    public partial class UCManMain : UserControl
    {
        public UCManMain()
        {
            InitializeComponent();
            ManName.Text = StaffDTO.Instance.name;
            ManEmail.Text = StaffDTO.Instance.phone;
        }

        private void UCManMain_Load(object sender, EventArgs e)
        {
            ManName.Text = StaffDTO.Instance.name;
            ManEmail.Text = StaffDTO.Instance.phone;
        }
    }
}
