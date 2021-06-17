using HotelManagement.DTO;
using System.Collections.Generic;
using System.Data;

namespace HotelManagement.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @pass";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public List<Account> GetAccount()
        {
            List<Account> list = new List<Account>();

            string query = "select * from Account ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account category = new Account(item);
                list.Add(category);
            }

            return list;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public bool InsertUser(string userName, string DisplayName, string Gender, string Pass, string Type, string Phone)
        {
            string query = string.Format("Insert into Account values ('" + userName + "',N'" + DisplayName + "','" + Gender + "','" + Pass + "','" + Type + "','" + Phone + "') ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateUser(string oldname, string userName, string DisplayName, string Gender, string Pass, string Phone)
        {
            string query = "update Account set Username = '" + userName + "' , Displayname = N'" + DisplayName + "', Gender = '" + Gender + "', Phone = '" + Phone + "', Pass = '" + Pass + "' where Username = '" + oldname + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

        public bool UpdateUser(string oldname, string userName, string DisplayName, string Gender, string Pass, string Phone, string type)
        {
            string query = "update Account set Username = '" + userName + "' , Displayname = N'" + DisplayName + "', Gender = '" + Gender + "', Phone = '" + Phone + "', Pass = '" + Pass + "', Type = '" + type + "' where Username = '" + oldname + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }
        public bool DeleteUser(string username)
        {
            string query = "delete Account where Username = '" + username + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
