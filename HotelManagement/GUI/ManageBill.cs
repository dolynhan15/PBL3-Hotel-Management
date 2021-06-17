using HotelManagement.DTO;
using HotelManagement.GUI.Bills;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class ManageBill : UserControl
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

            }

        }

        public ManageBill(Account account)
        {
            InitializeComponent();
            this.LoginAccount = account;

            Find_Bills uo = new Find_Bills(this.LoginAccount);
            uo.Dock = DockStyle.Fill;
            pnlBill.Controls.Add(uo);
            uo.BringToFront();

        }

        private void btnFindUsers_Click(object sender, System.EventArgs e)
        {
            Find_Bills uo = new Find_Bills(this.LoginAccount);
            uo.Dock = DockStyle.Fill;
            pnlBill.Controls.Add(uo);
            uo.BringToFront();
        }
    }
}
