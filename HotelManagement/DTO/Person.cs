using System;

namespace HotelManagement.DTO
{
    class Person
    {
        private int id;
        private string identification_card;
        private string name;
        private string phone;
        private string gender;
        private DateTime date_birth;

        public string Identification_card { get => identification_card; set => identification_card = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Date_birth { get => date_birth; set => date_birth = value; }
        public int Id { get => id; set => id = value; }
    }
}
