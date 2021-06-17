using HotelManagement.BLL;
using HotelManagement.DAO;
using System;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class Statics : UserControl
    {
        public Statics()
        {

            InitializeComponent();
            dtpkTimeFromDate1.Format = DateTimePickerFormat.Custom;
            dtpkTimeFromDate1.CustomFormat = "dd/MM/yyyy";
            dtpkTimeToDate1.Format = DateTimePickerFormat.Custom;
            dtpkTimeToDate1.CustomFormat = "dd/MM/yyyy";


            LoadDateTimePicker();
        }

        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dtpkTimeFromDate1.Value = new DateTime(today.Year, today.Month, 1);
            dtpkTimeToDate1.Value = dtpkTimeToDate1.Value.AddMonths(1).AddDays(-1);
        }
       

     

      

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            StaticBLL.Instance.LoadListBillByDate(dtgvStatics,chart2,dtpkTimeFromDate1.Value, dtpkTimeToDate1.Value);
            chart2.Series[0].XValueMember = dtgvStatics.Columns["date_checkout"].DataPropertyName;
            chart2.Series[0].YValueMembers = dtgvStatics.Columns["total_money"].DataPropertyName;
            chart2.ChartAreas[0].AxisX.Title = "Date";
            chart2.ChartAreas[0].AxisY.Title = "Total_money";
            chart2.DataBind();
            chart2.Show();
            chart1.Hide();
            panel4.Hide();

        }
        private void button_WOC2_Click(object sender, EventArgs e)
        {
            StaticBLL.Instance.LoadListBillByMonth(dtgvStatics, Convert.ToInt32(cbMonth1.SelectedItem.ToString()), Convert.ToInt32(cbMonth2.SelectedItem.ToString()), Convert.ToInt32(numeric.Value));
            chart1.Series[0].XValueMember = dtgvStatics.Columns[0].DataPropertyName;
            chart1.Series[0].YValueMembers = dtgvStatics.Columns[1].DataPropertyName;
            chart1.ChartAreas[0].AxisX.Title = "Month";
            chart1.ChartAreas[0].AxisY.Title = "Total_money";
            chart1.DataSource = dtgvStatics.DataSource;
            chart1.DataBind();
            chart1.Show();
            chart2.Hide();
            panel4.Hide();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {          
             StaticBLL.Instance.LoadListBillByYear(dtgvStatics, chart1,
                 Convert.ToInt32(numeric1.Value), Convert.ToInt32(numeric2.Value));
            chart1.Series[0].XValueMember = dtgvStatics.Columns[0].DataPropertyName;
            chart1.Series[0].YValueMembers = dtgvStatics.Columns[1].DataPropertyName;
            chart1.ChartAreas[0].AxisX.Title = "Year";
            chart1.ChartAreas[0].AxisY.Title = "Total_money";
           
            chart1.DataBind();
            chart1.Show();
            chart2.Hide();
            panel4.Hide();
        }




    }
}
