using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Windows.Forms;

namespace HotelManagement.GUI.UserInfor
{
    public partial class Info : UserControl
    {

        public delegate void UpdateAccount(Account account);

        public event UpdateAccount UpdateAccount_Event;

        public Account account;

        public Info(Account account)
        {
            InitializeComponent();
            this.account = account;
            txbUsername.Text = account.Username;
            txbName.Text = account.DisplayName;
            txbPassWord.Text = account.Pass;
            txbPhoneNumber.Text = account.Phone;
            cbGender.Text = account.Gender;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txbPassWord.Text != txbRePassWord.Text)
            {
                MessageBox.Show("Password different repassword. Please type again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbUsername.Text != this.account.Username)
            {
                if (AccountDAO.Instance.GetAccountByUserName(txbUsername.Text) != null)
                {
                    MessageBox.Show("This user has been exits. Please choose another name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (AccountDAO.Instance.UpdateUser(this.account.Username, txbUsername.Text, txbName.Text, cbGender.Text, txbPassWord.Text, txbPhoneNumber.Text))
                    {
                        MessageBox.Show("Update Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.account = AccountDAO.Instance.GetAccountByUserName(txbUsername.Text);
                        if (UpdateAccount_Event != null) // DK EVENT O FORM1
                        {
                            UpdateAccount_Event(this.account);

                        }


                    }
                    else MessageBox.Show("Update Failed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (AccountDAO.Instance.UpdateUser(this.account.Username, txbUsername.Text, txbName.Text, cbGender.Text, txbPassWord.Text, txbPhoneNumber.Text))
                {
                    MessageBox.Show("Update Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.account = AccountDAO.Instance.GetAccountByUserName(txbUsername.Text);
                    if (UpdateAccount_Event != null) // DK EVENT O FORM1
                    {
                        UpdateAccount_Event(this.account);

                    }
                }
                else MessageBox.Show("Update Failed", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
