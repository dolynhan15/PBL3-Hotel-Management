using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;


namespace HotelManagement.DAO
{
    class BillDAO
    {

        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        public List<Bill> GetBills()
        {
            List<Bill> list = new List<Bill>();

            string query = "select distinct * from Bill";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Bill bills = new Bill(item);
                list.Add(bills);
            }

            return list;
        }

        public bool InsertBill(string id_emp, string id_guest, string date_set, string check_in, string check_out, string discount, string total, string nameGuest, string status = "uncheck")
        {
            string query = string.Format("Insert into Bill values (" + id_emp + "," + id_guest + ",'" + nameGuest + "','" + date_set + "','" + check_in + "','" + check_out + "'," + discount + ",'" + total + "','" + status + "') ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public Bill GetBillByIdBill(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Bill where id_bill = " + id + " and Bill.status = 'uncheck'");

            foreach (DataRow item in data.Rows)
            {
                return new Bill(item);
            }

            return null;
        }

        public Bill GetBillByIdBill()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT TOP 1 * FROM  Bill ORDER BY id_bill DESC");

            foreach (DataRow item in data.Rows)
            {
                return new Bill(item);
            }

            return null;
        }

        public Bill GetBillByIdBillinfo(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Bill where id_bill = " + id);

            foreach (DataRow item in data.Rows)
            {
                return new Bill(item);
            }

            return null;
        }


        public void ChangeStatusCheck(string idbill, string total)
        {

            string query = "update Bill Set status = 'Check' , total_money = " + total + " where id_bill = " + idbill;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return;
        }

        public DataTable GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        public DataTable GetListBillByMonth(int month1, int month2, int year)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByMonth @month1 , @month2 , @year", new object[] { month1, month2, year });
        }

        public DataTable GetListBillByYear(int year1, int year2)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByYear @year1 , @year2", new object[] { year1, year2 });
        }



        public int GetDiscount(string datecheckin)
        {
            int discount = 0;
            string query = "select Discount.discount from Discount " +
                "where '" + datecheckin + "' <= Discount.date_end and '" + datecheckin + "' >= Discount.date_start";
            if (DataProvider.Instance.ExecuteScalar(query) != null)
                discount = (int)DataProvider.Instance.ExecuteScalar(query);
            return discount;

        }

        public bool UpdateBillMoney(string idbill, string money)
        {
            string query = "UPDATE Bill SET total_money = " + money + "where id_bill = " + idbill;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateBillMoney(string idbill, string id_guest, string id_emp, string card)
        {
            string query = "UPDATE Bill SET id_guest = " + id_guest + ", id_emp = "+id_emp
                + ",identitation_card_guest = '"+card+"' where id_bill = " + idbill;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
