using System;
using System.Data;

namespace HotelManagement.DTO
{
    class Bill
    {
        private int id_bill;
        private int id_emp;
        private int id_guest;
        private DateTime date_set;
        private DateTime date_check_in;
        private DateTime date_check_out;
        private int discount = 0;
        private string total_money;
        private string status;
        private string identitation_card_guest;

        public Bill(int id_bill, int id_emp, int id_guest, DateTime date_set, DateTime date_check_in, DateTime date_check_out, int discount, string total_money, string status, string identitation_card_guest)
        {
            this.Id_bill = id_bill;
            this.Id_emp = id_emp;
            this.Id_guest = id_guest;
            this.Date_set = date_set;
            this.Date_check_in = date_check_in;
            this.Date_check_out = date_check_out;
            this.Discount = discount;
            this.Identitation_card_guest = identitation_card_guest;
            this.Total_money = total_money;
            this.Status = status;
        }

        public Bill(DataRow row)
        {

            this.Id_bill = (int)row["id_bill"];
            this.Id_emp = (int)row["id_emp"];
            this.Id_guest = (int)row["id_guest"];
            this.Identitation_card_guest = row["identitation_card_guest"].ToString().Trim();
            this.Date_set = (DateTime)row["date_set"];
            this.Date_check_in = (DateTime)row["date_checkin"];
            this.Date_check_out = (DateTime)row["date_checkout"];
            this.Discount = (int)row["discount"];
            this.Total_money = row["total_money"].ToString();
            this.Status = row["status"].ToString().Trim();

        }

        public int Id_bill { get => id_bill; set => id_bill = value; }
        public int Id_emp { get => id_emp; set => id_emp = value; }
        public int Id_guest { get => id_guest; set => id_guest = value; }
        public DateTime Date_set { get => date_set; set => date_set = value; }
        public DateTime Date_check_in { get => date_check_in; set => date_check_in = value; }
        public DateTime Date_check_out { get => date_check_out; set => date_check_out = value; }
        public int Discount { get => discount; set => discount = value; }
        public string Total_money { get => total_money; set => total_money = value; }
        public string Status { get => status; set => status = value; }

        public string Identitation_card_guest { get => identitation_card_guest; set => identitation_card_guest = value; }
    }
}
