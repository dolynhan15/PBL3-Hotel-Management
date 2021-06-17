using System;
using System.Data;

namespace HotelManagement.DTO
{
    class Employee : Person
    {
        private int salary;
        private string position;
        private string status;
        public int Salary { get => salary; set => salary = value; }
        public string Position { get => position; set => position = value; }
        public string Status { get => status; set => status = value; }

        public Employee(int id_Emp, string card, string name, DateTime date_birth, string gender, string phone, int salary, string position, string status)
        {
            this.Id = id_Emp;
            this.Identification_card = card;
            this.Name = name;
            this.Phone = phone;
            this.Gender = gender;
            this.Date_birth = date_birth;
            this.Salary = salary;
            this.Position = position;
            this.Status = status;

        }

        public Employee(DataRow row)
        {
            this.Id = (int)row["id_emp"];
            this.Identification_card = row["identification_card"].ToString().Trim();
            this.Name = row["name"].ToString().Trim();
            this.Phone = row["Phone"].ToString();
            this.Gender = row["Gender"].ToString().Trim();
            this.Date_birth = (DateTime)row["date_birth"];
            this.Salary = (int)row["salary"];
            this.Position = row["position"].ToString().Trim();
            this.Status = row["status"].ToString().Trim();
        }

        public Employee()
        { }



    }
}
