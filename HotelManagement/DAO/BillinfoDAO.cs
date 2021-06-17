using HotelManagement.DTO;
using System.Collections.Generic;
using System.Data;


namespace HotelManagement.DAO
{
    class BillinfoDAO
    {

        private static BillinfoDAO instance;

        public static BillinfoDAO Instance
        {
            get { if (instance == null) instance = new BillinfoDAO(); return BillinfoDAO.instance; }
            private set { BillinfoDAO.instance = value; }
        }
        public List<Billinfo> GetBillinfos()
        {
            List<Billinfo> list = new List<Billinfo>();

            string query = "select * from Billinfo";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Billinfo billinfos = new Billinfo(item);
                list.Add(billinfos);
            }

            return list;
        }

        public bool InsertBillinfoCheckIn(string idbill, string idroom)
        {
            string query = string.Format("Insert into Billinfo values (" + idbill + ",6 ," + idroom + ",1 )");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public void InsertBillinfo(int id_bill, int id_fb, int id_room, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count  , @idroom  ",
                new object[] { id_bill, id_fb, count, id_room });
        }

        public void DeleteBillinfoandBill(int id_bill)
        {
            DataProvider.Instance.ExecuteQuery("delete from Billinfo where id_bill = " + id_bill.ToString());
            DataProvider.Instance.ExecuteQuery("delete from Bill where id_bill = " + id_bill.ToString());

        }

        public bool UpdateBillinfoandBill(int id_bill, string guest, string date_set, string date_check_in, string date_check_out, string status, string discount, string total, string emp)
        {
            string query1 = "(select id_guest from Guest where name = N'" + guest + "'";
            string query2 = "(select id_emp from Employee where name = N'" + emp + "'";
            string query = string.Format("Update Bill set id_guest = " + query1 + ",date_set = '" + date_set + "',date_check_in = '" + date_check_in + "',date_check_out = '" + date_check_out + "',status = '" + status + "',discount = '" +
                discount + "',total  = '" + total + "',id_emp = " + query2 + " WHERE id_bill = " + id_bill);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;


        }

    }
}

