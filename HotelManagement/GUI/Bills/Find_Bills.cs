using HotelManagement.BLL;
using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace HotelManagement.GUI.Bills
{
    public partial class Find_Bills : UserControl
    { 
        
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
                btnDeleteUsers.Hide();
                btnUpdateUsers.Hide();
            }
        }

        public Find_Bills(Account account)
        {
            InitializeComponent();
            this.LoginAccount = account;
            dtgvBillsFind.Show();
         
            dtgvBillsFind.BringToFront();
            BillBLL.Instance.GetAccount(account);
            BillBLL.Instance.LoadGridview(dtgvBillsFind);
        }

        private void textBoxFindBill_TextChanged_1(object sender, EventArgs e)
        {
            BillBLL.Instance.searchData(dtgvBillsFind,textBoxFindBill.Text);
        }

        private void DoubleClickRow(object sender, EventArgs e)
        {
            BillBLL.Instance.ToUpdate(dtgvBillsFind);
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            BillBLL.Instance.DeleteBill(dtgvBillsFind);
        }

        private void btnUpdateUsers_Click_1(object sender, EventArgs e)
        {
            BillBLL.Instance.ToUpdate(dtgvBillsFind);
        }

   
    }
}
