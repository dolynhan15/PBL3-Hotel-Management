using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Missing information", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (Login(userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password or Account!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPassWord.Text = "";

            }
        }
    }
}
