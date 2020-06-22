using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFoodCourtSystem.DTO;
namespace SmartFoodCourtSystem.DAO
{
    class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }
        private FoodDAO() { }
        public List<Food> getFoodbyCategory(int category)
        {
            List<Food> listfood = new List<Food>();
            string query = $"SELECT  * FROM Food WHERE Category={category} ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow r in data.Rows)
            {
                Food t = new Food();
                t.name = r["Name"].ToString();
                t.category = category;
                t.idFood = int.Parse(r["IDFood"].ToString());
                t.price = long.Parse(r["Price"].ToString());
                t.description = r["Description"].ToString();
                t.image = r["image"].ToString();
                t.resource = r["resource"].ToString();
                t.discount = int.Parse(r["Discount"].ToString());
                listfood.Add(t);
            }


            return listfood;
        }
        public List<Food> getFoodByname(string name)
        {
            string query = $"SELECT * FROM Food WHERE Name='{name}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count == 0)
            {
                return null ;
            }
            else
            {
                List<Food> listfood = new List<Food>();
                foreach (DataRow r in data.Rows)
                {
                    Food t = new Food();
                    t.name = r["Name"].ToString();
                    t.category = int.Parse(r["Category"].ToString());
                    t.idFood = int.Parse(r["IDFood"].ToString());
                    t.price = long.Parse(r["Price"].ToString());
                    t.description = r["Description"].ToString();
                    t.image = r["image"].ToString();
                    t.resource = r["resource"].ToString();
                    t.discount = int.Parse(r["Discount"].ToString());
                    listfood.Add(t);
                }
                return listfood;
            }
        }

    }
}
