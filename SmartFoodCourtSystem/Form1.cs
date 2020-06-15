using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace SmartFoodCourtSystem
{
    public partial class Form1 : Form
    {
        private string connectionSTR = "Data Source=database.db;Version=3;New=False;Compress=True;";
        public Form1()
        {
           InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection sql_conn = new SQLiteConnection(connectionSTR);
            
                sql_conn.Open();
                string query = "Select * from User";
                SQLiteCommand cmd = new SQLiteCommand(query, sql_conn) ;
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        #region button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            userControl_Home1.BringToFront();
        }
        private void bntMenu_Click(object sender, EventArgs e)
        {
            SidePanel.Height = bntMenu.Height;
            SidePanel.Top = bntMenu.Top;
            userControl1_Menu1.BringToFront();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCart.Height;
            SidePanel.Top = btnCart.Top;
            uC_cart1.BringToFront();
        }
        #endregion
    }
}
