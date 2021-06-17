using System.Data;

namespace HotelManagement.DTO
{
    class Output
    {
        private string id_bill;
        private string name;
        private int amount;
        private int price;
        private int total_price;

        public Output(string id_bill, string name, int amount, int price, int total_price)
        {
            this.Id_bill = id_bill;
            this.Name = name;
            this.Amount = amount;
            this.Price = price;
            this.Total_price = total_price;
        }

        public Output(DataRow row)
        {
            this.Id_bill = row["id_bill"].ToString().Trim();
            this.Name = row["Name"].ToString().Trim();
            this.Amount = (int)row["Amount"];
            this.Price = (int)row["Price"];
            this.Total_price = (int)row["Total_price"];
        }

        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Price { get => price; set => price = value; }
        public int Total_price { get => total_price; set => total_price = value; }
        public string Id_bill { get => id_bill; set => id_bill = value; }
    }
}
