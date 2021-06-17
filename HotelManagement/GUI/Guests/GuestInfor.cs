using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HotelManagement.GUI.Guests
{
    public partial class GuestInfor : Form
    {
        public delegate void UpdateGuest(string Card, string name, DateTime date_birth, string gender, string phone, string email, string nationality, string oldname);

        public string oldname;
        public event UpdateGuest UpdateGuest_Event;
        public GuestInfor()
        {
            InitializeComponent();
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateGuest_Event != null) // DK EVENT O FORM1
            {
                int this_year = DateTime.Now.Year;
                if (txbCard.Text == "" || txtName.Text == "" || txbPhoneNumber.Text == "" || txbEmail.Text == "" ||
                    txbNationality.Text == "")
                {
                    MessageBox.Show("Missing Information ! Please type again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((this_year - dateTimePicker1.Value.Year) < 16 || (this_year - dateTimePicker1.Value.Year) > 100)
                {
                    MessageBox.Show("Person's age shall not be allowed. You should change the year value.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UpdateGuest_Event(txbCard.Text, txtName.Text, dateTimePicker1.Value, cbGender.SelectedItem.ToString(), txbPhoneNumber.Text, txbEmail.Text, txbNationality.Text, this.oldname);

                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
