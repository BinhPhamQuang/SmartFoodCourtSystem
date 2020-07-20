using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.DAO;
using SmartFoodCourtSystem.DTO;
namespace SmartFoodCourtSystem
{
    public partial class Billdetail : Form
    {
        public Billdetail()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        public int id=-1;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       public string totalprice;
        public string date;
        private void Billdetail_Load(object sender, EventArgs e)
        {
           // this.ShowInTaskbar = false;
            CultureInfo culture = new CultureInfo("vi-VN");
            // MessageBox.Show(id.ToString());
            lbID.Text = id.ToString();
           // lbprice.Text = totalprice.ToString("#,### vnđ", culture.NumberFormat);
            string query = $"SELECT * from BillInfo where IDBill={id}";
            try
            {
                int stt = 1;
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                foreach(DataRow i in table.Rows)
                {
                    ListViewItem x = new ListViewItem();
                    x.Text = stt.ToString();
                    string queryfood = $"SELECT Name,discount FROM Food where IDFood={int.Parse(i["IDFood"].ToString())}";
                    DataTable food = DataProvider.Instance.ExecuteQuery(queryfood);
                    x.SubItems.Add(food.Rows[0]["Name"].ToString());
                    x.SubItems.Add(i["Quantity"].ToString());
                    x.SubItems.Add(food.Rows[0]["Discount"].ToString()+"%");


                    stt++;
                    lV.Items.Add(x);
                }
                lbdate.Text = date;
                lbprice.Text = totalprice;
            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Billdetail_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
