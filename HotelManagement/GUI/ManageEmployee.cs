using HotelManagement.DTO;
using HotelManagement.GUI.Employees;
using System;
using System.Windows.Forms;
namespace HotelManagement
{

    public partial class ManageEmployee : UserControl
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
                btnCreateUsers.Hide();
            }

        }

        public ManageEmployee(Account account)
        {
            InitializeComponent();
            this.LoginAccount = account;

            Find_Employees uo = new Find_Employees(this.LoginAccount);
            uo.Dock = DockStyle.Fill;
            pnlEmp.Controls.Add(uo);
            uo.BringToFront();

        }



        private void btnCreateUsers_Click(object sender, EventArgs e)
        {
            Create_Employees uo = new Create_Employees();
            uo.Dock = DockStyle.Fill;
            pnlEmp.Controls.Add(uo);
            uo.BringToFront();
        }

        private void btnFindUsers_Click(object sender, EventArgs e)
        {
            Find_Employees uo = new Find_Employees(this.LoginAccount);
            uo.Dock = DockStyle.Fill;
            pnlEmp.Controls.Add(uo);
            uo.BringToFront();
        }
    }
}