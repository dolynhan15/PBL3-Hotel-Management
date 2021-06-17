using System;
using System.Data;

namespace HotelManagement.DTO
{
    class Guest : Person
    {
        private string email;
        private string nationality;

        public Guest(int id_Guest, string Card, string name, DateTime date_birth, string gender, string phone, string email, string nationality)
        {
            this.Id = id_Guest;
            this.Identification_card = Card;
            this.Name = name;
            this.Email = email;
            this.Date_birth = date_birth;
            this.Gender = gender;
            this.Phone = phone;
            this.Nationality = nationality;
        }

        public Guest(DataRow row)
        {
            this.Id = (int)row["id_guest"];
            this.Identification_card = row["Identification_Card"].ToString().Trim();
            this.Name = row["name"].ToString().Trim();
            this.Phone = row["Phone"].ToString();
            this.Gender = row["Gender"].ToString().Trim();
            this.Date_birth = (DateTime)row["date_birth"];
            this.Email = row["email"].ToString().Trim();
            this.Nationality = row["nationality"].ToString().Trim();
        }




        public string Nationality { get => nationality; set => nationality = value; }
        public string Email { get => email; set => email = value; }
    }
}
