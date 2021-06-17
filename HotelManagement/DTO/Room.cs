using System.Data;


namespace HotelManagement.DTO
{
    class Room
    {
        private int id_room;
        private string name;
        private int id_type;
        private string status_room = "None";
        public Room(int id_room, string name, int id_type, string status_room)
        {
            this.Id_room = id_room;
            this.Name = name;
            this.Id_type = id_type;
            this.Status_room = status_room;
        }

        public Room(DataRow row)
        {
            this.Id_room = (int)row["id_room"];
            this.Name = row["name"].ToString();
            this.Id_type = (int)row["id_type"];
            this.Status_room = row["status"].ToString();

        }
        public string Name { get => name; set => name = value; }
        public int Id_type { get => id_type; set => id_type = value; }
        public string Status_room { get => status_room; set => status_room = value; }
        public int Id_room { get => id_room; set => id_room = value; }
    }
}
