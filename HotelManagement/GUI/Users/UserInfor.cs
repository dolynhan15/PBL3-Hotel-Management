using System;
using System.Windows.Forms;

namespace HotelManagement.GUI.Users
{
    public partial class UserInfor : Form
    {
        public delegate void UpdateUser(string username, string displayName, string type, string gender, string phone, string repassword, string password = null);

        public event UpdateUser UpdateUser_Event;
        public UserInfor()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateUser_Event != null) // DK EVENT O FORM1
            {
                if (string.Compare(txbRePassWord.Text, txbPassWord.Text) == 0)
                {
                    UpdateUser_Event(txbUsername.Text, txbName.Text, cbType.SelectedItem.ToString(), cbGender.SelectedItem.ToString(), txbPhoneNumber.Text, txbRePassWord.Text, txbPassWord.Text);
                    this.Close();
                }
                else { MessageBox.Show("Password confirmation doesn't match password. Please enter password again.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                this.Close();
            }

        }

    }
}
