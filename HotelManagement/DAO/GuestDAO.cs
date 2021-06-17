using HotelManagement.DTO;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.DAO
{
    class GuestDAO
    {
        private static GuestDAO instance;

        public static GuestDAO Instance
        {
            get { if (instance == null) instance = new GuestDAO(); return GuestDAO.instance; }
            private set { GuestDAO.instance = value; }
        }
        public List<Guest> GetGuests()
        {
            List<Guest> list = new List<Guest>();

            string query = "select * from Guest";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Guest category = new Guest(item);
                list.Add(category);
            }

            return list;
        }

        public Guest GetIdentitaion(string card)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Guest where identification_Card = '" + card + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Guest(item);
            }

            return null;
        }


        public bool InsertGuest(string card, string name, string phone, string gender, string date, string email, string nationality)
        {
            string query = string.Format("Insert into Guest values ('" + card + "',N'" + name + "','" + phone + "','" + gender + "','" + date + "','" + email + "','" + nationality + "') ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateGuest(int id_guest, string card, string name, string phone, string gender, string date, string email, string nationality, string oldcard)
        {

            string query = string.Format("Update Guest set identification_Card = '" + card + "',name = N'" + name + "',phone = '" + phone + "',gender = '" + gender + "',date_birth = '" + date + "',email = '" + email + "',nationality = '" + nationality + "' WHERE id_guest = " + id_guest);

           string query2 = "update Bill set identitation_card_guest = '" + card + "' where identitation_card_guest = '"+oldcard+"'";
            
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            int result1 = DataProvider.Instance.ExecuteNonQuery(query2);

            return result > 0;
        }
        public bool DeleteGuest(int id_guest)
        {

            string query = "";
            string query1 = "Select COUNT(id_guest) from Bill where id_guest = " + id_guest.ToString();
            int num_bill = (int)DataProvider.Instance.ExecuteScalar(query1);

            if (num_bill <= 0)
            {

                query = string.Format("Delete from Guest where id_guest = " + id_guest.ToString());
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;

            }
            else
            {
                MessageBox.Show("Bills of this guest existed", "Can't delete",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Guest GetGuestByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Guest where id_guest = " + id);

            foreach (DataRow item in data.Rows)
            {
                return new Guest(item);
            }

            return null;
        }

    }
}
