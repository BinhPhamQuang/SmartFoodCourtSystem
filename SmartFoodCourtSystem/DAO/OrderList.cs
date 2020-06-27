using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFoodCourtSystem.DTO;
using System.Data;

namespace SmartFoodCourtSystem.DAO
{
    public class OrderList
    {
        private static OrderList instance;

        public static OrderList Instance
        {
            get { if (instance == null) instance = new OrderList(); return OrderList.instance; }
            private set { OrderList.instance = value; }
        }
        private OrderList(){}

        public List<Order>LoadOrderList()
        {
            List<Order> orders = new List<Order>();

            string query = "Select IDBill, TotalPrice, status from Bill";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                query = "Select Name, Quantity, Note from BillInfo " +
                        "inner join Food on BillInfo.IDFood = Food.IDFood " +
                        "where IDBill = " + Convert.ToInt32(item["IDBill"]);
                DataTable table1 = DataProvider.Instance.ExecuteQuery(query);

                List<data> detail = new List<data>();
                foreach( DataRow monan in table1.Rows)
                {
                    data temp = new data(monan);
                    detail.Add(temp);
                }
                Order order = new Order(Convert.ToInt32(item["IDBill"]), detail, Convert.ToInt32(item["Totalprice"]), Convert.ToInt32(item["status"]));
                orders.Add(order);
            }

            return orders; 
        }
    }
}
