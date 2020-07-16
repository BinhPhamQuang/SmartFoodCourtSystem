using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFoodCourtSystem.DTO;
using System.Data;

namespace SmartFoodCourtSystem.DAO
{
    public class EmployeeDAO
    {
        public static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set { EmployeeDAO.instance = value; }
        }
        private EmployeeDAO() { }

        public DataTable GetListEmployee()
        {
            string query = $"Select  User.IDUser, Name, Salary, Username, Password, Phonenumber, Age, Type from Employee " +
                        "inner join User on Employee.IDUser = User.IDUser " ;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool InsertStaff(string name, float Salary, int age, string phone)
        {
            string query = $"Insert Into Employee ( Name,Salary,Age,Phonenumber) VALUES ('{name}',{Salary },{age},'{phone}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return (result > 0);
        }

        public bool UpdateStaff(int IDUser, string name, float Salary, int age, string phone)
        {
            string query = $"Update Employee SET Name = '{name}', salary = '{Salary}', age = {age}, Phonenumber='{phone}' WHERE IDUser = {IDUser}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return (result > 0);
        }

        public bool DeleteStaff(int IDUser)
        {
            string query = string.Format(@"Delete FROM Employee where IDUser = '" + IDUser + "' ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return (result > 0);
        }

    }
}
