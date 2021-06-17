using System.Data;

namespace HotelManagement.DTO
{
    class Food_Beverage
    {
        private int id_fb;
        private string name;
        private string type;
        private int price;
        private byte[] image;
        public Food_Beverage(int id_fb, string name, string type, int price, byte[] image)
        {
            this.Id_fb = id_fb;
            this.Name = name;
            this.Type = type;
            this.Price = price;
            this.Image = image;
        }

        public Food_Beverage(DataRow row)
        {
            this.Id_fb = (int)row["id_fb"];
            this.Name = row["name"].ToString();
            this.Type = row["Type"].ToString();
            this.Price = (int)row["price_food"];
            this.Image = (byte[])row["Image"];

        }
        public string Name { get => name; set => name = value; }
        public int Id_fb { get => id_fb; set => id_fb = value; }
        public string Type { get => type; set => type = value; }
        public int Price { get => price; set => price = value; }
        public byte[] Image { get => image; set => image = value; }
    }
}

