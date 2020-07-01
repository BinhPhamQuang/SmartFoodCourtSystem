using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFoodCourtSystem.DAO;
using SmartFoodCourtSystem.DTO;
using SmartFoodCourtSystem.Properties;
using System.Text.RegularExpressions;
namespace SmartFoodCourtSystem
{
    public partial class UCReport : UserControl
    {
        public string changetoVND(string x)
        {
            int l = x.Length;
            int dem = 0;
            string y = "";
            string result = "";
            //while (x[length] != '\0')
            //{
            //    length++;
            //}
            for (int i = l - 1; i >= 0; i--)
            {
                y += x[i];
            }
            for (int i = 0; i < l; i++)
            {
                if (dem != 2)
                {
                    dem++;
                    result += y[i];
                }
                else
                {
                    if (i != l - 1)
                    {
                        result += y[i];
                        result += ',';
                    }
                    else
                    {
                        result += y[i];
                    }
                    dem = 0;
                }
            }
            l = result.Length;
            string realresult = "";
            for (int i = l - 1; i >= 0; i--)
            {
                realresult += result[i];
            }
            return realresult;
        }
        public UCReport()
        {
            InitializeComponent();
            string query = $"SELECT * from Bill";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int i = 0;
            foreach (DataRow r in data.Rows)
            {
                i++;
                string date = r["Timecheckout"].ToString() + " - " + r["Date"].ToString() + "/" + r["Month"].ToString() + "/" + r["Year"].ToString();
                string money = changetoVND(r["Totalprice"].ToString()) + " VNĐ";
                ListViewItem x = new ListViewItem();
                x.Text = i.ToString();
                int b_id = int.Parse(r["IDBill"].ToString());
                string query1 = $"SELECT * from BillInfo WHERE IDBill = '" + b_id + "'";
                DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
                string t = "";
                int count = 0;
                foreach (DataRow rd in data1.Rows)
                {
                    int f_id = int.Parse(rd["IDFood"].ToString());
                    string query2 = $"SELECT Name from Food WHERE IDFood ='" + f_id + "'";
                    DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
                    foreach (DataRow rf in data2.Rows)
                    {
                        t += rf["Name"].ToString() + ", ";
                        count++;
                    }
                }
                x.SubItems.Add(b_id.ToString());
                x.SubItems.Add(t);
                x.SubItems.Add(count.ToString());
                x.SubItems.Add(date);
                x.SubItems.Add(money);
                lV.Items.Add(x);

            }
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            int money = 0;
            label5.Text = "Thu nhập của";
            if (cb1.SelectedIndex > -1 && cb2.SelectedIndex > -1 && cb3.SelectedIndex > -1)
            {
                string d = cb1.SelectedItem.ToString();
                string y = cb3.SelectedItem.ToString();
                string m = cb2.SelectedItem.ToString();
                string query = $"SELECT * from Bill WHERE Date={d} AND Month ={m} AND Year ={y} ";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow r in data.Rows)
                {
                    money += int.Parse(r["Totalprice"].ToString());
                }
                label5.Text += " ngày " + d + " tháng " + m + " năm " + y + " là " + changetoVND(money.ToString()) + " VNĐ";
            }
            else if (cb1.SelectedIndex <= -1 && cb2.SelectedIndex > -1 && cb3.SelectedIndex > -1)
            {
                string y = cb3.SelectedItem.ToString();
                string m = cb2.SelectedItem.ToString();
                string query = $"SELECT * from Bill WHERE Month ={m} AND Year ={y} ";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow r in data.Rows)
                {
                    money += int.Parse(r["Totalprice"].ToString());
                }
                label5.Text += " tháng " + m + " năm " + y + " là " + changetoVND(money.ToString()) + " VNĐ";
            }
            else if (cb1.SelectedIndex <= -1 && cb2.SelectedIndex <= -1 && cb3.SelectedIndex > -1)
            {
                string y = cb3.SelectedItem.ToString();
                string query = $"SELECT * from Bill WHERE Year ={y} ";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow r in data.Rows)
                {
                    money += int.Parse(r["Totalprice"].ToString());
                }
                label5.Text += " năm " + y + " là " + changetoVND(money.ToString()) + " VNĐ";
            }
            grBox.BringToFront();
            grBox.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            if (money == 0) label5.Text = "Không có dữ liệu!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            grBox.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }
    }
}
