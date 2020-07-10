using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SmartFoodCourtSystem.DTO;

namespace SmartFoodCourtSystem.DAO
{
    class UserDAO
    {
        public static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return UserDAO.instance; }
            private set { UserDAO.instance = value; }
        }
        private UserDAO() { }

        public DataTable GetListUser()
        {
            string query = $"SELECT * FROM User";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool InsertUser(string username, string password, string type)
        {
            string encpassword = HashMD5.Encrypt(password);
            string enctype = HashMD5.Encrypt(type);
            string query = string.Format(@"Insert Into User ( Username, Password, Type) VALUES ('" + username + "','" +encpassword+ "','" +enctype+ "')");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return (result > 0);
        }

        public bool UpdateUser(int IDUser, string username, string password, string type)
        {
            string encpassword = HashMD5.Encrypt(password);
            string enctype = HashMD5.Encrypt(type);
            string query = string.Format(@"Update User SET Username = '"+username+"', Password = '"+encpassword+"', Type = '"+enctype+"' WHERE IDUser = '" + IDUser + "' ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return (result > 0);
        }

        public bool DeleteUser(int IDUser)
        {
            string query = string.Format(@"Delete FROM User where IDUser = '" + IDUser + "' ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return (result > 0);
        }
    }
}
