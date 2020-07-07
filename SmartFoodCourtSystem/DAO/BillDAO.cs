using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFoodCourtSystem.DTO;
namespace SmartFoodCourtSystem.DAO
{
    class BillDAO
    {
        
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() {    }

        public void DeleteBillByFoodId(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete from BillInfo where IDFood = " + id);
        }

        public void createbill()
        {
            Bill bill = new Bill();
           // DateTime time = DateTime.Now;
            try
            {
                string hour = DateTime.Now.ToString("HH:mm:ss tt");
                string query = $"INSERT INTO Bill(IDBill,Date,Month,Year,Totalprice,Timecheckout) VALUES ({bill.idbill},{bill.day},{bill.month},{bill.year},{Cart.Instance.caculatePrice()},'{hour}')";
                DataProvider.Instance.ExecuteNonQuery(query);

                foreach(Food i in Cart.Instance.getListFood())
                {
                    query = $"INSERT INTO BillInfo(IDBill, IDFood, Quantity, Note) VALUES({bill.idbill}, {i.idFood}, {i.quantity}, '{i.note}')";
                    DataProvider.Instance.ExecuteNonQuery(query);
                }
            }
            catch (Exception e)
            {
               
            }
        }
         
    }
}
