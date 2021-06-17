using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelManagement.DAO
{
    class RoomDAO
    {
        private static RoomDAO instance;

        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }
            private set { RoomDAO.instance = value; }
        }

        public static int RoomHeight = 60;
        public static int RoomWidth = 70;
        private RoomDAO() { }
        public List<Room> GetRooms()
        {
            List<Room> list = new List<Room>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Room");

            foreach (DataRow item in data.Rows)
            {
                Room category = new Room(item);
                list.Add(category);
            }
            return list;
        }

        public List<Room> GetFixRooms()
        {
            List<Room> list = new List<Room>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Room where status = 'Fix'");

            foreach (DataRow item in data.Rows)
            {
                Room category = new Room(item);
                list.Add(category);
            }
            return list;
        }
        public (String, String, int) GetRooms(int id)
        {

            string idroom = Convert.ToString(id);
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT Room.name, RoomType.name as typeroom , RoomType.price as Price FROM " +
                "Room inner join RoomType on id_typeRoom = id_type where id_room = " + idroom);

            string nameroom = "";
            string typeroom = "";
            int money = 0;
            foreach (DataRow row in data.Rows)
            {
                nameroom = row["name"].ToString();
                typeroom = row["typeroom"].ToString();
                money = (int)row["Price"];

            }
            return (nameroom, typeroom, money);
        }

        public Room GetRoomByName(string nameroom)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * from Room where name = " + nameroom);
            foreach (DataRow row in data.Rows)
            {
                return new Room(row);

            }
            return null;
        }

        public Room GetRoomByIdBill(string id)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * from Room where id_room = (select distinct id_room from Billinfo where id_bill = " + id + ")");
            foreach (DataRow row in data.Rows)
            {
                return new Room(row);

            }
            return null;
        }

        public List<Room> GetListRoomByDate(DateTime checkIn, DateTime checkOut)
        {
            List<Room> list = new List<Room>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetListRoomByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
            foreach (DataRow row in data.Rows)
            {
                Room item = new Room(row);
                list.Add(item);
            }
            return list;
        }

        public bool InsertRoom(string name, int type, string status)
        {
            string query = string.Format("Insert into Room values ('" + name + "','" + type + "','" + status + "')");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateRoom(string name, int type, string status)
        {
            string query = "Update Room SET id_type = " + type.ToString() + ", status = '" + status + "' where name = " + name;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public List<Room> GetListRoomCheckOut(DateTime checkOut)
        {
            List<Room> list = new List<Room>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetRoomToday @checkOut", new object[] { checkOut });
            foreach (DataRow row in data.Rows)
            {
                Room item = new Room(row);
                list.Add(item);
            }
            return list;
        }
    }
}
