using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelManagement.BLL
{
    public class StaticBLL
    {
        private static StaticBLL instance;
        public static StaticBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaticBLL();
                return instance;
            }
        }
        public void LoadListBillByDate(DataGridView dtgvStatics, Chart chart2, DateTime checkIn, DateTime checkOut)
        {
            dtgvStatics.DataSource = BillDAO.Instance.GetListBillByDate(checkIn, checkOut);
            chart2.DataSource = BillDAO.Instance.GetListBillByDate(checkIn, checkOut);

        }
        public void LoadListBillByYear(DataGridView dtgvStatics, Chart chart1, int year1, int year2)
        {
            dtgvStatics.DataSource = BillDAO.Instance.GetListBillByYear(year1, year2);
            chart1.DataSource = BillDAO.Instance.GetListBillByYear(year1, year2);
        }

        public void LoadListBillByMonth(DataGridView dtgvStatics, int month1, int month2, int year)
        {
            dtgvStatics.DataSource = BillDAO.Instance.GetListBillByMonth(month1, month2, year);
        }
    }
}
