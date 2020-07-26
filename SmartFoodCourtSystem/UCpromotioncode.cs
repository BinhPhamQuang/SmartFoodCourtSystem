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
namespace SmartFoodCourtSystem
{
    public partial class UCpromotioncode : UserControl
    {
        private class Code
        {
            public string code;
            public int daystart;
            public int monthstart;
            public int yeastart;
            public int duedate;
            public int duemonth;
            public int dueyear;
            public int times;
            public int valuediscount;
        }
       private class Promotioncode
       {
           
            public List<Code> promotioncodes;
            public Promotioncode()
            {
                this.promotioncodes = getPromotioncde();
            }
            public List<Code> getPromotioncde()
            {
                List<Code> t = new List<Code>();
                string query = "SELECT * FROM Promotioncode";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                if (data.Rows.Count == 0) return null;
                foreach (DataRow i in data.Rows)
                {
                    Code temp = new Code();
                    temp.code = i["code"].ToString();
                    temp.daystart = int.Parse(i["daystart"].ToString());
                    temp.monthstart= int.Parse(i["monthstart"].ToString());
                    temp.yeastart= int.Parse(i["yearstart"].ToString());
                    temp.duedate= int.Parse(i["dayend"].ToString());
                    temp.duemonth= int.Parse(i["monthend"].ToString());
                    temp.dueyear= int.Parse(i["yearend"].ToString());
                    temp.valuediscount= int.Parse(i["discount"].ToString());
                    temp.times= int.Parse(i["count"].ToString());

                    t.Add(temp);
                }
                return t;
            }
       }
        private Promotioncode promotioncode;
        public UCpromotioncode()
        {
            InitializeComponent();
            loadcode();
        }
        void Alert(string msg, FAlert.emType type)
        {
            FAlert frm = new FAlert();
            frm.showAlert(msg, type);
        }
        private string getmonth(int month)
        {
            switch(month)
            {
                case 1:
                    return  "January";
                    
                     
                case 2:
                     
                    return "February";
                    
                case 3:
                     
                   return "March";
                    
                case 4:
                     
                   return "April";
                   
                case 5:
                    
                   return "May";
                    
                case 6:
                    
                   return "June";
                    
                case 7:
                    
                  return "July";
                    
                case 8:
                     
                    return"August";
                    
                case 9:
                   //return "August";
                   return "September";
                    
                case 10:
                  //  thangtruoc = "September";
                   return "October";
                    //break;
                case 11:
                   // thangtruoc = "October";
                    return "November";
                    //break;
                case 12:
                    //thangtruoc = "November";
                  return "December";
                    //b/]reak;
            }
            return "NA";
        }
        private void loadcode()
        {
            lvcode.Items.Clear();
            promotioncode = new Promotioncode();
            int stt = 1;
            foreach(Code i in promotioncode.promotioncodes)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = stt.ToString();

                lv.SubItems.Add(i.code);
                string datestart = $"{i.daystart}-{getmonth(i.monthstart)}-{i.yeastart}";
                string dateend = $"{i.duedate}-{getmonth(i.duemonth)}-{i.dueyear}";
                                  
                lv.SubItems.Add(datestart);
                lv.SubItems.Add(dateend);
                lv.SubItems.Add(i.valuediscount.ToString() + "%");
                stt++;
                lvcode.Items.Add(lv);
               
            }
           
        }
        private void clear()
        {
            btnUpdate.Enabled = false;
            tbnamecode.ReadOnly = false;
            tbnamecode.Text = "";
            numericdiscount.Value = 0;
            numTimes.Value = 0;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
            DateTime t = DateTime.Today;
            datestart.Value = new DateTime(t.Year, t.Month, t.Day);
            duedate.Value = new DateTime(2025,1,1);
            tbnamecode.ReadOnly = false;
            btncancel.Visible = true;
            btncreate.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
                foreach(Code i in promotioncode.promotioncodes)
                {
                if(i.code==tbnamecode.Text && i.code!= selected.code)
                {
                    Alert("Name existed", FAlert.emType.error);
                    return;
                }
                 }
                DateTime start = datestart.Value;
                DateTime end = duedate.Value;
                string query = $"UPDATE Promotioncode SET code='{tbnamecode.Text}', daystart={start.Day},dayend={end.Day},monthstart={start.Month},monthend={end.Month},yearstart={start.Year},yearend={end.Year},discount={int.Parse(numericdiscount.Value.ToString())},count={int.Parse(numTimes.Value.ToString())} WHERE code='{selected.code}'";
                DataProvider.Instance.ExecuteNonQuery(query);
            
                btnUpdate.Enabled = false;
                  clear();
            loadcode();
            Alert("Successfully", FAlert.emType.success);

             
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

            clear();
            btncancel.Visible = false;
            btncreate.Visible = false;
        }
        private  Code selected;
        private void lvcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            if (lvcode.SelectedItems.Count == 0)
            {
                return;
            }
            btncancel.Visible = false;
            btncreate.Visible = false;
            ListViewItem item = lvcode.SelectedItems[0];
            tbnamecode.Text = item.SubItems[1].Text;
            foreach(Code i in promotioncode.promotioncodes)
            {
                if(item.SubItems[1].Text==i.code)
                {
                    try
                    {
                        selected = i;
                        datestart.Value = new DateTime(i.yeastart, i.monthstart, i.daystart);
                        duedate.Value = new DateTime(i.dueyear, i.duemonth, i.duedate);
                        numericdiscount.Value = i.valuediscount;
                        numTimes.Value = i.times;
                    }
                    catch(Exception a)
                    {
                        MessageBox.Show(a.ToString());
                    }
                     
                    break;
                }
            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            foreach(Code i in promotioncode.promotioncodes)
            {
                if(i.code==tbnamecode.Text)
                {
                    Alert("code existed", FAlert.emType.error);
                    return;
                }
            }
            try
            {
                if(tbnamecode.Text.Length==0)
                {
                    return;
                }
                string query = $"INSERT INTO Promotioncode(code,daystart,dayend,monthstart,monthend,yearstart,yearend,discount,count) VALUES('{tbnamecode.Text}',{datestart.Value.Day},{duedate.Value.Day},{datestart.Value.Month},{duedate.Value.Month},{datestart.Value.Year},{duedate.Value.Year},{numericdiscount.Value},{numTimes.Value})";
                DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch(Exception a)
            {
                Alert("Can't insert", FAlert.emType.error);
            }
            Alert("Successfully", FAlert.emType.success);
            loadcode();
            clear();
            tbnamecode.ReadOnly = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"DELETE from Promotioncode WHERE code='{selected.code}'";
                DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception a)
            {
                return;
            }
            Alert("Successfully", FAlert.emType.success);
            clear();
            loadcode();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbnamecode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void datestart_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
