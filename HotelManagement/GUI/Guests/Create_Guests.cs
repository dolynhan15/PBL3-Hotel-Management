using HotelManagement.BLL;
using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Windows.Forms;

namespace HotelManagement.GUI.Guests
{
    public partial class Create_Guests : UserControl
    {
        public Create_Guests()
        {
            InitializeComponent();
        }

        private void cbGender_KeyPress(object sender, KeyPressEventArgs e)
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
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            string card = txbCard.Text;
            string name = txtName.Text;
            string gender = cbGender.Text;
            string email = txbEmail.Text;
            string date_birth = dateTimePicker1.Value.ToString();
            string nationality = txbNationality.Text;
            string phone = txbPhoneNumber.Text;
            int this_year = DateTime.Now.Year;

            Guest guest = GuestDAO.Instance.GetIdentitaion(card);
            if (guest != null)
            {
                MessageBox.Show("Guest already exists", "Alert", MessageBoxButtons.OK);
                return;
            }
            else if (card == "" || name == "" || email == "")
            {
                MessageBox.Show("Missing Information please type again", "Alert",
                    MessageBoxButtons.OK);
                return;
            }
            else if ((this_year - dateTimePicker1.Value.Year) < 15 || (this_year - dateTimePicker1.Value.Year) > 100)
            {
                MessageBox.Show("Person's age shall not be allowed. Maybe you forgot to change the year value?", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GuestBLL.Instance.AddGuest(card, name, phone, gender, date_birth, email, nationality);
            }
        }

 
        private void btnReset_Click(object sender, System.EventArgs e)
        {
            foreach (Control childControl in groupCreate.Controls)
                if (childControl is TextBox)
                    childControl.ResetText();
        }
    }
}
