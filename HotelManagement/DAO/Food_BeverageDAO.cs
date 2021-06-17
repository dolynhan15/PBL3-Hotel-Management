using HotelManagement.DTO;
using System.Collections.Generic;
using System.Data;

namespace HotelManagement.DAO
{
    class Food_BeverageDAO
    {
        private static Food_BeverageDAO instance;
        public static Food_BeverageDAO Instance
        {
            get { if (instance == null) instance = new Food_BeverageDAO(); return Food_BeverageDAO.instance; }
            private set { Food_BeverageDAO.instance = value; }
        }

        private Food_BeverageDAO() { }

        public List<Food_Beverage> GetFood_Beverages()
        {
            List<Food_Beverage> list = new List<Food_Beverage>();

            string query = "select * from Food_Beverage ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food_Beverage category = new Food_Beverage(item);
                list.Add(category);
            }

            return list;
        }

        public Food_Beverage GetFood_Beverage(int id_fb)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Food_Beverage where id_fb = '" + id_fb.ToString() + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Food_Beverage(item);
            }

            return null;
        }
    }
}
