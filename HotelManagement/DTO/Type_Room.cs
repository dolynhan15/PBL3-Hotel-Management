using System.Data;

namespace HotelManagement.DTO
{
    public class Type_Room
    {

        public Type_Room(int id, string name, int price)
        {
            this.Id_TypeRoom = id;
            this.Name = name;
            this.Price = price;
        }

        public Type_Room(DataRow row)
        {
            this.Id_TypeRoom = (int)row["id_typeRoom"];
            this.Name = row["name"].ToString().Trim();
            this.Price = (int)row["price"];
        }

        private string name;
        private int price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int id_TypeRoom;




        public int Id_TypeRoom { get => id_TypeRoom; set => id_TypeRoom = value; }
        public int Price { get => price; set => price = value; }
    }
}
