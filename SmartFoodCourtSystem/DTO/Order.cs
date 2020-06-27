using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SmartFoodCourtSystem.DTO
{

    public struct data
    {
        public data(string food, int quantity, string note)
        {
            this.food = food;
            this.quantity = quantity;
            this.note = note;
        }

        public data(DataRow item)
        {
            this.food = (string)item["Name"];
            this.quantity = Convert.ToInt32(item["Quantity"]);
            try { 
                this.note = (string)item["Note"];
            }
            catch
            {
                this.note = "";
            }
        }
        private string food;
        private int quantity;
        private string note;

        public string Food { get => food; set => food = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Note { get => note; set => note = value; }
    }
    public class Order
    {
        private int orderID;
        private List<data> detail;
        private int totalPrice;
        private int status;

        public int OrderID { get => orderID; set => orderID = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public List<data> Detail { get => detail; set => detail = value; }
        public int Status { get => status; set => status = value; }

        public Order(int OrderID, List<data> Detail, int price, int status)
        {
            this.orderID = OrderID;
            this.detail = Detail;
            this.totalPrice = price;
            this.status = status;
        }

    }
}
