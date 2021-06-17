using HotelManagement.BLL;
using HotelManagement.DAO;
using HotelManagement.DTO;
using HotelManagement.GUI.Rooms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.GUI.Bills
{
    public partial class BillInfor : Form
    {

        public delegate void UpdateBill(string guest, DateTime date_set, DateTime date_check_in, DateTime date_check_out, string status, int discount, string total, string emp);

        public event UpdateBill UpdateBill_Event;

        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type, loginAccount.DisplayName); }
        }

        public void ChangeAccount(string type, string name)
        {

            int Type = 0;
            if (type.Contains("Manager")) Type = 1;
            else if (type.Contains("Reception")) Type = 2;



            if (Type == 1) // manager
            {

            }
            else if (Type == 2) // reception
            {
                btnUpdate.Hide();
                btnFood_Bev.Hide();
            }

        }

        public BillInfor(Account account)
        {
            InitializeComponent();
            labelID.Hide();
            this.LoginAccount = account;
            BillBLL.Instance.LoadListMemberName(cbGuest,cbEmp);

        }

 


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (UpdateBill_Event != null) // DK EVENT O FORM1
            {
                string discount = txbDiscount.Text.Trim('%');
                UpdateBill_Event(cbGuest.SelectedValue.ToString(), dtpkSet.Value, dtpkCheckIn.Value, dtpkCheckOut.Value, txbStatus.Text, Convert.ToInt32(discount), txbTotal.Text, cbEmp.SelectedValue.ToString());

                this.Close();
            }
            else
            {
                this.Close();
            }

        }

        void LoadData()
        {
            Room room = RoomDAO.Instance.GetRoomByName(txbRoomNumber.Text);
            var typerooms = RoomDAO.Instance.GetRooms(room.Id_room);
         
            Bill bill = BillDAO.Instance.GetBillByIdBillinfo(labelID.Text);
            TimeSpan totalday = bill.Date_check_out - bill.Date_check_in;
            int differenceInDays = (int)totalday.TotalDays;
            if (differenceInDays == 0) differenceInDays++;

            int total = (typerooms.Item3 * differenceInDays) - (typerooms.Item3 * differenceInDays) * bill.Discount / 100;
            List<Output> outputs = OutputDAO.Instance.GetOutputs(labelID.Text);
            foreach (Output item in outputs)
            {
                total += item.Total_price - item.Total_price * bill.Discount / 100;
            }
            txbTotal.Text = total.ToString();
            if (BillDAO.Instance.UpdateBillMoney(labelID.Text, total.ToString()))
            {
                MessageBox.Show("Update Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnFood_Bev_Click(object sender, EventArgs e)
        {

            BillinfoFood billinfoFood = new BillinfoFood(labelID.Text, txbRoomNumber.Text);
            billinfoFood.ShowDialog();
            dtgvBillinfo.Rows.Clear();
            BindingSource output = new BindingSource();
            output.DataSource = OutputDAO.Instance.GetOutputs(labelID.Text);
            dtgvBillinfo.DataSource = output;
            LoadData();
        }
    }
}
