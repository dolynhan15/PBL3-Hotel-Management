using HotelManagement.DTO;
using System.Collections.Generic;
using System.Data;

namespace HotelManagement.DAO
{
    public class Type_RoomDAO
    {
        private static Type_RoomDAO instance;

        public static Type_RoomDAO Instance
        {
            get { if (instance == null) instance = new Type_RoomDAO(); return Type_RoomDAO.instance; }
            private set { Type_RoomDAO.instance = value; }
        }

        private Type_RoomDAO() { }

        public List<Type_Room> GetListCategory()
        {
            List<Type_Room> list = new List<Type_Room>();

            string query = "select * from RoomType";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Type_Room category = new Type_Room(item);
                list.Add(category);
            }

            return list;
        }


    }


}
