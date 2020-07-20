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
using Microsoft.Office.Interop.Excel;
using System.Threading;
//using System.Runtime.InteropServices;

namespace SmartFoodCourtSystem
{
    public partial class UCReport : UserControl
    {
        static int type = -1;
        static int found1 = 0;
        static int found2 = 0;
        void Alert(string msg, FAlert.emType type)
        {
            FAlert frm = new FAlert();
            frm.showAlert(msg, type);
        }
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
        private void loaditemyear()
        {
            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery("SELECT Year FROM Bill");
            
            List<int> year = new List<int>();
            foreach(DataRow i in data.Rows)
            {
                year.Add(int.Parse(i["year"].ToString()));
            }
            year=year.Distinct().ToList();
            cb3.DataSource = year;
            cb3.SelectedIndex = -1;

        }
        public UCReport()
        {
           InitializeComponent();
            loaditemyear();
           Loadbill("");




            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void Loadbill( string conditon)
        {
            string query = $"SELECT * from Bill {conditon}";
            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int i = 0;
            foreach (DataRow r in data.Rows)
            {
                i++;
                string date = r["Timecheckout"].ToString() + " - " + r["Date"].ToString() + "/" + r["Month"].ToString() + "/" + r["Year"].ToString();
                string money = changetoVND(r["Totalprice"].ToString()) + " VND";
                ListViewItem x = new ListViewItem();
                x.Text = i.ToString();
                int b_id = int.Parse(r["IDBill"].ToString());
                string query1 = $"SELECT * from BillInfo WHERE IDBill = '" + b_id + "'";
                System.Data.DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
                string t = "";
                int count = 0;
                foreach (DataRow rd in data1.Rows)
                {
                    int f_id = int.Parse(rd["IDFood"].ToString());
                    string query2 = $"SELECT Name from Food WHERE IDFood ='" + f_id + "'";
                    System.Data.DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
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
        }
        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            if ((cb2.SelectedIndex <= -1 && cb3.SelectedIndex <= -1) | (cb2.SelectedIndex > -1 && cb3.SelectedIndex <= -1))
                Alert("Wrong format!", FAlert.emType.error);
            else
            {
                string thang = "";
                int thiang = -1;
                string thangtruoc = "";
                string nam = "";
                int reve = 0;
                int l_reve = 0;
                string month = "";
                string year = "";
                double cost = 0.6742389 * reve;
                double l_cost = 0.7742389 * l_reve;
                ListViewItem a = new ListViewItem();
                ListViewItem b = new ListViewItem();
                //label5.Text = "Total revenue of ";
                if (cb2.SelectedIndex > -1 && cb3.SelectedIndex > -1)
                {
                    type = 0;
                    string y = cb3.SelectedItem.ToString();
                    string m = cb2.SelectedItem.ToString();
                    string query = $"SELECT * from Bill WHERE Month ={m} AND Year ={y} ";
                    System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    month = m;
                    year = y;
                    switch (int.Parse(m))
                    {
                        case 1:
                            thang = "January";
                            thangtruoc = "December";
                            break;
                        case 2:
                            thangtruoc = "January";
                            thang = "February";
                            break;
                        case 3:
                            thangtruoc = "February";
                            thang = "March";
                            break;
                        case 4:
                            thangtruoc = "February";
                            thang = "April";
                            break;
                        case 5:
                            thangtruoc = "April";
                            thang = "May";
                            break;
                        case 6:
                            thangtruoc = "May";
                            thang = "June";
                            break;
                        case 7:
                            thangtruoc = "June";
                            thang = "July";
                            break;
                        case 8:
                            thangtruoc = "July";
                            thang = "August";
                            break;
                        case 9:
                            thangtruoc = "August";
                            thang = "September";
                            break;
                        case 10:
                            thangtruoc = "September";
                            thang = "October";
                            break;
                        case 11:
                            thangtruoc = "October";
                            thang = "November";
                            break;
                        case 12:
                            thangtruoc = "November";
                            thang = "December";
                            break;

                    }
                    foreach (DataRow r in data.Rows)
                    {
                        reve += int.Parse(r["Totalprice"].ToString());
                    }
                    string query1 = "";
                    thiang = int.Parse(m) - 1;
                    if (thiang == 0)
                    {
                        query1 = $"SELECT * from Bill WHERE Month ={12.ToString()} AND Year ={(int.Parse(y) - 1).ToString()} ";
                        nam = (int.Parse(y) - 1).ToString();
                    }
                    else
                    {
                        query1 = $"SELECT * from Bill WHERE Month ={(int.Parse(m) - 1).ToString()} AND Year ={y} ";
                        nam = year;
                    }
                    System.Data.DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);

                    foreach (DataRow r in data1.Rows)
                    {
                        l_reve += int.Parse(r["Totalprice"].ToString());
                    }
                    //label5.Text += thang + ", " + y + " is " + changetoVND(money.ToString()) + " VND";
                }
                else if (cb2.SelectedIndex <= -1 && cb3.SelectedIndex > -1)
                {
                    type = 1;
                    string y = cb3.SelectedItem.ToString();
                    string query = $"SELECT * from Bill WHERE Year ={y} ";
                    System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

                    year = y;
                    foreach (DataRow r in data.Rows)
                    {
                        reve += int.Parse(r["Totalprice"].ToString());
                    }
                    string query1 = $"SELECT * from Bill WHERE Year ={(int.Parse(y) - 1).ToString()}";
                    System.Data.DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);

                    foreach (DataRow r in data1.Rows)
                    {
                        l_reve += int.Parse(r["Totalprice"].ToString());
                    }
                    //label5.Text +=  y + " is " + changetoVND(money.ToString()) + " VND";
                }
                cost = Math.Round(0.55645645 * reve);
                l_cost = Math.Round(0.75456456 * l_reve);
                double grossprofit = 0;
                double l_grossprofit = 0;
                double percent = 0;
                if (reve != 0)
                {
                    grossprofit = (double)reve - cost;
                }
                if (l_reve != 0)
                {
                    l_grossprofit = (double)l_reve - l_cost;
                    percent = Math.Abs(Math.Round((grossprofit / l_grossprofit - 1), 2) * 100);
                }
                double diff = Math.Abs(grossprofit - l_grossprofit);
                switch (type)
                {
                    case 0:
                        if (thiang == 0)
                        {
                            a.Text = "12";
                            a.SubItems.Add((int.Parse(year) - 1).ToString());
                        }
                        else
                        {
                            a.Text = (int.Parse(month) - 1).ToString();
                            a.SubItems.Add(year);
                        }
                        a.SubItems.Add(changetoVND(l_reve.ToString()) + " VND ");
                        a.SubItems.Add(changetoVND(l_cost.ToString()) + " VND ");
                        a.SubItems.Add(changetoVND(l_grossprofit.ToString()) + " VND ");
                        b.Text = month;
                        b.SubItems.Add(year);
                        b.SubItems.Add(changetoVND(reve.ToString()) + " VND ");
                        b.SubItems.Add(changetoVND(cost.ToString()) + " VND ");
                        b.SubItems.Add(changetoVND(grossprofit.ToString()) + " VND ");
                        lV1.Items.Add(a);
                        lV1.Items.Add(b);
                        lV1.Visible = true;
                        if (reve != 0 && l_reve != 0)
                        {
                            if (grossprofit > l_grossprofit) label1.Text = "The gross profit of " + thang + " is greater than " + thangtruoc + ": " + changetoVND(diff.ToString()) + "VND, greater than " + percent.ToString() + "%";
                            else label1.Text = "The gross profit of " + thang + " is less than " + thangtruoc + ": " + changetoVND(diff.ToString()) + "VND, less than " + percent.ToString() + "%";
                        }
                        else
                        {
                            if (l_reve == 0 && reve == 0)
                            {
                                label1.Text = "No data found of " + thangtruoc + ", " + nam + " and " + thang + ", " + year;
                            }
                            else if (reve == 0)
                            {
                                label1.Text = "No data found of " + thang + ", " + year;
                            }
                            else if (l_reve == 0)
                            {
                                label1.Text = "No data found of " + thangtruoc + ", " + (int.Parse(year) - 1).ToString();
                            }
                        }
                        break;
                    case 1:
                        a.Text = (int.Parse(year) - 1).ToString();
                        a.SubItems.Add(changetoVND(l_reve.ToString()) + " VND ");
                        a.SubItems.Add(changetoVND(l_cost.ToString()) + " VND ");
                        a.SubItems.Add(changetoVND(l_grossprofit.ToString()) + " VND ");
                        b.Text = year;
                        b.SubItems.Add(changetoVND(reve.ToString()) + " VND ");
                        b.SubItems.Add(changetoVND(cost.ToString()) + " VND ");
                        b.SubItems.Add(changetoVND(grossprofit.ToString()) + " VND ");
                        lV2.Items.Add(a);
                        lV2.Items.Add(b);
                        lV2.Visible = true;
                        if (reve != 0 && l_reve != 0)
                        {
                            found1 = 1;
                            if (grossprofit > l_grossprofit) label1.Text = "The gross profit of " + year + " is greater than " + (int.Parse(year) - 1).ToString() + ": " + changetoVND(diff.ToString()) + "VND, greater than " + percent.ToString() + "%";
                            else label1.Text = "The gross profit of " + year + " is less than " + (int.Parse(year) - 1).ToString() + ": " + changetoVND(diff.ToString()) + "VND, less than " + percent.ToString() + "%";
                        }
                        else
                        {
                            if (l_reve == 0 && reve == 0)
                            {
                                label1.Text = "No data found of " + (int.Parse(year) - 1).ToString() + " and " + year;
                            }
                            else if (reve == 0)
                            {
                                label1.Text = "No data found of " + year;
                            }
                            else if (l_reve == 0)
                            {
                                label1.Text = "No data found of " + (int.Parse(year) - 1).ToString();
                            }
                        }
                        break;
                }

                grBox.BringToFront();
                grBox.Visible = true;
               // label4.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            grBox.Visible = false;
           // label4.Visible = false;
            //label1.Visible = false;
            lV1.Visible = false;
            lV2.Visible = false;
            lV1.Items.Clear();
            lV2.Items.Clear();
            cb2.SelectedIndex = -1;
            cb3.SelectedIndex = -1;
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() {FileName="Report "+cb2.Text+" "+cb3.Text, Filter = "Excel Workbook|*.xls", ValidateNames = true })
                if (sfd.ShowDialog()==DialogResult.OK)
                       {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    
                       
                            ws.Cells[1, 1] = "No";
                            ws.Cells[1, 2] = "Bill ID";
                            ws.Cells[1, 3] = "Food List";
                            ws.Cells[1, 4] = "Amount";
                            ws.Cells[1, 5] = "Time checkout";
                            ws.Cells[1, 6] = "Total price";
                            int i = 2;
                            foreach (ListViewItem item in lV.Items)
                            {
                                ws.Cells[i, 1] = item.SubItems[0].Text;
                                ws.Cells[i, 2] = item.SubItems[1].Text;
                                ws.Cells[i, 3] = item.SubItems[2].Text;
                                ws.Cells[i, 4] = item.SubItems[3].Text;
                                ws.Cells[i, 5] = item.SubItems[4].Text;
                                ws.Cells[i, 6] = item.SubItems[5].Text;
                                i++;
                            }

                    int status = 0;   
                    
                    Thread t = new Thread(() => {
                        wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                        status = 1;
                        

                       
                    });
                    t.Start();
                    ptbprocessing.Visible = true;
                    lbprocessing.Visible = true;



                    t.Join();
                   
                     Alert("Successfully saved!", FAlert.emType.success);
                      ptbprocessing.Visible = false;
                     lbprocessing.Visible = false;
                    

                    //btnExit_Click(null, null);

                   // MessageBox.Show(status.ToString());

                }
        }

        private void btnFitler_Click(object sender, EventArgs e)
        {
            if ((cb2.SelectedIndex <= -1 && cb3.SelectedIndex <= -1) | (cb2.SelectedIndex > -1 && cb3.SelectedIndex <= -1))
                Alert("Wrong format!", FAlert.emType.error);
            else
            {
                btnBack.Visible = true;
                lV.Items.Clear();
                string item = "";
                if (cb2.SelectedIndex==-1)
                {
                    item = $"WHERE Year={cb3.SelectedItem.ToString()}";
                   groupBox1.Text = "Revenue " + cb3.SelectedItem.ToString();
                }
                else
                {
                    item = $"WHERE Year={cb3.SelectedItem.ToString()} AND Month={cb2.SelectedItem.ToString()}";
                    groupBox1.Text = "Revenue " + cb2.SelectedItem.ToString()+"/"+ cb3.SelectedItem.ToString();

                }
                Loadbill(item);
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lV.Items.Clear();
            Loadbill("");
            groupBox1.Text = "All bill";
            cb2.SelectedIndex = -1;
            cb3.SelectedIndex = -1;
            btnBack.Visible = false;
        }

        private void lV_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
       
        private void lV_DoubleClick(object sender, EventArgs e)
        {
            if (lV.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem item = lV.SelectedItems[0];

            Billdetail b = new Billdetail();
            b.id = int.Parse(item.SubItems[1].Text);
            b.date = item.SubItems[4].Text;
            b.totalprice = item.SubItems[5].Text;
            // b.totalprice = int.Parse(item.SubItems[5].Text);
            b.ShowDialog();
        }
    }
}
