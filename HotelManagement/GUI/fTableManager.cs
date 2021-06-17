using HotelManagement.DTO;
using HotelManagement.GUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class fTableManager : Form
    {

        public fTableManager()
        {
            InitializeComponent();

        }

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type, loginAccount.DisplayName); }
        }

        public fTableManager(Account account)
        {
            InitializeComponent();

            this.LoginAccount = account;

        }

        public void ChangeAccount(string type, string name)
        {

            int Type = 0;
            if (type.Contains("Manager")) Type = 1;
            else if (type.Contains("Reception")) Type = 2;

            Flpbutton.Controls.Add(btnAccount);
            Flpbutton.Controls.Add(btnUsers);
            Flpbutton.Controls.Add(btnEmployees);
            Flpbutton.Controls.Add(btnRooms);
            Flpbutton.Controls.Add(btnBills);
            Flpbutton.Controls.Add(btnGuests);
            Flpbutton.Controls.Add(btnStatistics);
       
            if (Type == 1)
            {
                Flpbutton.Controls.Remove(btnUsers);
                btnAccount.Text = "            Manager : " + name;
            }
            else if (Type == 2)
            {
                Flpbutton.Controls.Remove(btnUsers);
                Flpbutton.Controls.Remove(btnStatistics);
                btnAccount.Text = "         Receptionist : " + name;
            }
            else if (Type == 0)
            {
                Flpbutton.Controls.Clear();
                Flpbutton.Controls.Add(btnAccount);
                Flpbutton.Controls.Add(btnUsers);    
                btnAccount.Text = "               Admin : " + name;
            }
        }



        private void btnGuest_Click(object sender, EventArgs e)
        {
            ManageGuest uo = new ManageGuest();
            uo.Dock = DockStyle.Fill;
            pictureBox1.Controls.Add(uo);

            btnUsers.BackColor = Color.FromArgb(236, 236, 236);
            btnEmployees.BackColor = Color.FromArgb(236, 236, 236);
            btnRooms.BackColor = Color.FromArgb(236, 236, 236);
            btnBills.BackColor = Color.FromArgb(236, 236, 236);
            btnGuests.BackColor = Color.FromArgb(201, 228, 214);
            btnStatistics.BackColor = Color.FromArgb(236, 236, 236);
      
            uo.BringToFront();

        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            ManageBill uo = new ManageBill(this.LoginAccount);
            uo.Dock = DockStyle.Fill;
            pictureBox1.Controls.Add(uo);

            btnUsers.BackColor = Color.FromArgb(236, 236, 236);
            btnEmployees.BackColor = Color.FromArgb(236, 236, 236);
            btnRooms.BackColor = Color.FromArgb(236, 236, 236);
            btnBills.BackColor = Color.FromArgb(201, 228, 214);
            btnGuests.BackColor = Color.FromArgb(236, 236, 236);
            btnStatistics.BackColor = Color.FromArgb(236, 236, 236);
          
            uo.BringToFront();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ManageUser uo = new ManageUser();
            uo.Dock = DockStyle.Fill;
            pictureBox1.Controls.Add(uo);

            btnUsers.BackColor = Color.FromArgb(201, 228, 214);
            btnEmployees.BackColor = Color.FromArgb(236, 236, 236);
            btnRooms.BackColor = Color.FromArgb(236, 236, 236);
            btnBills.BackColor = Color.FromArgb(236, 236, 236);
            btnGuests.BackColor = Color.FromArgb(236, 236, 236);
            btnStatistics.BackColor = Color.FromArgb(236, 236, 236);
          

            uo.BringToFront();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ManageEmployee uo = new ManageEmployee(this.LoginAccount);
            uo.Dock = DockStyle.Fill;
            pictureBox1.Controls.Add(uo);

            btnUsers.BackColor = Color.FromArgb(236, 236, 236);
            btnEmployees.BackColor = Color.FromArgb(201, 228, 214);
            btnRooms.BackColor = Color.FromArgb(236, 236, 236);
            btnBills.BackColor = Color.FromArgb(236, 236, 236);
            btnGuests.BackColor = Color.FromArgb(236, 236, 236);
            btnStatistics.BackColor = Color.FromArgb(236, 236, 236);
          
            uo.BringToFront();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            ManageRoom uo = new ManageRoom(this.LoginAccount);
            uo.Dock = DockStyle.Fill;
            pictureBox1.Controls.Add(uo);

            btnUsers.BackColor = Color.FromArgb(236, 236, 236);
            btnEmployees.BackColor = Color.FromArgb(236, 236, 236);
            btnRooms.BackColor = Color.FromArgb(201, 228, 214);
            btnBills.BackColor = Color.FromArgb(236, 236, 236);
            btnGuests.BackColor = Color.FromArgb(236, 236, 236);
            btnStatistics.BackColor = Color.FromArgb(236, 236, 236);
          
            uo.BringToFront();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Statics uo = new Statics();
            uo.Dock = DockStyle.Fill;
            pictureBox1.Controls.Add(uo);

            btnUsers.BackColor = Color.FromArgb(236, 236, 236);
            btnEmployees.BackColor = Color.FromArgb(236, 236, 236);
            btnRooms.BackColor = Color.FromArgb(236, 236, 236);
            btnBills.BackColor = Color.FromArgb(236, 236, 236);
            btnGuests.BackColor = Color.FromArgb(236, 236, 236);
            btnStatistics.BackColor = Color.FromArgb(201, 228, 214);
            uo.BringToFront();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            GUI.UserInfor.Info info = new GUI.UserInfor.Info(this.loginAccount);
            info.UpdateAccount_Event += UpdateAccount_Event;
            info.Dock = DockStyle.Fill;
            pictureBox1.Controls.Add(info);
            info.BringToFront();


        }

        void UpdateAccount_Event(Account account)
        {
            this.loginAccount = account;
            ChangeAccount(account.Type, account.DisplayName);

        }
    }
}
