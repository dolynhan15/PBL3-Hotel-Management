using System.Data;

namespace HotelManagement.DTO
{
    class Billinfo
    {
        private int id_bill;
        private int id_fb;
        private int id_room;
        private int total_fb;

        public Billinfo(int id_bill, int id_fb, int id_room, int total_fb)
        {
            this.Id_bill = id_bill;
            this.Id_fb = id_fb;
            this.Id_room = id_room;
            this.Total_fb = total_fb;

        }

        public Billinfo(DataRow row)
        {
            this.Id_bill = (int)row["id_bill"];
            this.Id_fb = (int)row["id_fb"];
            this.Id_room = (int)row["id_room"];
            this.Total_fb = (int)row["total_fb"];

        }
        public int Id_bill { get => id_bill; set => id_bill = value; }
        public int Id_fb { get => id_fb; set => id_fb = value; }
        public int Id_room { get => id_room; set => id_room = value; }
        public int Total_fb { get => total_fb; set => total_fb = value; }

    }
}
