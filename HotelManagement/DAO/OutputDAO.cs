using HotelManagement.DTO;
using System.Collections.Generic;
using System.Data;
namespace HotelManagement.DAO
{
    class OutputDAO
    {
        private static OutputDAO instance;

        public static OutputDAO Instance
        {
            get { if (instance == null) instance = new OutputDAO(); return OutputDAO.instance; }
            private set { OutputDAO.instance = value; }
        }
        public List<Output> GetOutputByRoom(int idroom, string datecheckin, string datecheckout)
        {
            List<Output> list = new List<Output>();

            string query = "select Billinfo.id_bill as id_bill ,Food_Beverage.name as Name ,Billinfo.total_fb as Amount,Food_Beverage.price_food as Price, Food_Beverage.price_food*Billinfo.total_fb as Total_Price "
                + "from Billinfo, Food_Beverage, Bill "
                + "where Billinfo.id_fb = Food_Beverage.id_fb and Bill.id_bill = Billinfo.id_bill and Bill.status = 'uncheck'  and (Bill.date_checkin <= '" + datecheckin + "' or Bill.date_checkin < '" + datecheckout + "') " +
                "and Bill.date_checkout > '" + datecheckin + "' and Billinfo.id_room = " + idroom.ToString();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Output output = new Output(item);
                list.Add(output);
            }

            return list;
        }

        public List<Output> GetOutputs(string idBill)
        {
            List<Output> list = new List<Output>();

            string query = "select distinct Billinfo.id_bill as id_bill ,Food_Beverage.name as Name ,Billinfo.total_fb as Amount,Food_Beverage.price_food as Price, Food_Beverage.price_food*Billinfo.total_fb as Total_Price" +
                " from Billinfo, Food_Beverage, Bill " +
                "where Billinfo.id_bill = " + idBill + " and Billinfo.id_fb = Food_Beverage.id_fb and Billinfo.id_fb != 6";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Output output = new Output(item);
                list.Add(output);
            }


            return list;
        }
    }
}
