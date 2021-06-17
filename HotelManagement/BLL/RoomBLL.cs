using HotelManagement.DAO;
using HotelManagement.DTO;
using HotelManagement.GUI.Rooms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.BLL
{
    class RoomBLL
    {
        List<Room> rooms = RoomDAO.Instance.GetRooms();
        List<Room> busyrooms;
        List<Room> fixrooms = RoomDAO.Instance.GetFixRooms();

        DateTime dateFrom;
        DateTime dateTo;
        private static RoomBLL instance;
        public static RoomBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomBLL();
                return instance;
            }
        }
        public void LoadTypeRoom(ComboBox cbTyperoom)
        {
            List<Type_Room> type_Rooms = Type_RoomDAO.Instance.GetListCategory();
            cbTyperoom.Items.Add("Full");
            foreach (Type_Room item in type_Rooms)
            {
                cbTyperoom.Items.Add(item);
            }
            cbTyperoom.DisplayMember = "name";


        }
       

        public void GetDate(DateTime dateFrom, DateTime dateTo)
        {
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
        }
      

        public void ShowCheckIn(int idRoom)
        {
            TimeSpan totalday = this.dateTo - this.dateFrom;
            int differenceInDays = (int)totalday.TotalDays;
            if (differenceInDays == 0) differenceInDays++;
            Checkin_Room checkin_Room = new Checkin_Room(idRoom, this.dateFrom, differenceInDays);
            checkin_Room.ShowDialog();
            checkin_Room.Location = new Point(170, 100);
            busyrooms = RoomDAO.Instance.GetListRoomByDate(this.dateFrom, this.dateTo);
          
        }

        public void ShowCheckout(int idRoom)
        {
            Checkout_Room checkout_Room = new Checkout_Room(idRoom, this.dateFrom.ToShortDateString(),
                this.dateTo.ToShortDateString());
            checkout_Room.ShowDialog();
            checkout_Room.Location = new Point(170, 100);
        }

     


    }
}
