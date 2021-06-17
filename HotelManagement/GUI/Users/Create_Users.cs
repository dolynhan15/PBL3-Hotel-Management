using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Windows.Forms;
namespace HotelManagement
{
    public partial class Create_Users : UserControl
    {
        public Create_Users()
        {
            InitializeComponent();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string displayname = txbName.Text;
            string gender = cbGender.Text;
            string pass = txbPassWord.Text;
            string repass = txbRePassWord.Text;
            string type = cbType.Text;
            string phone = txbPhoneNumber.Text;
            Account account = AccountDAO.Instance.GetAccountByUserName(username);
            if (account != null)
            {
                MessageBox.Show("Username already exists please choose another Username", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (username == "" || displayname == "" || pass == "")
            {
                MessageBox.Show("Missing Information please type again", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (pass != repass)
            {
                MessageBox.Show("Password and Repassword is not same. Please enter password again", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                AddAccount(username, displayname, gender, pass, type, phone);
            }
        }

        void AddAccount(string userName, string DisplayName,
            string Gender, string Pass, string Type, string Phone)
        {
            if (AccountDAO.Instance.InsertUser(userName, DisplayName, Gender, Pass, Type, Phone))
                MessageBox.Show("Create Successfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Create Failed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control childControl in groupUser.Controls)
                if (childControl is TextBox)
                    childControl.ResetText();
        }

    }
}
