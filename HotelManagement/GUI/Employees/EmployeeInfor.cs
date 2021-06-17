using System;
using System.Windows.Forms;

namespace HotelManagement.GUI.Employees
{
    public partial class EmployeeInfor : System.Windows.Forms.Form
    {
        public delegate void UpdateEmployee(string card, string name, DateTime date_birth, string gender,
            string phone, int salary, string position);

        public event UpdateEmployee UpdateEmployee_Event;

        public EmployeeInfor()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbCard.Text == "" || txtName.Text == "" || txtSalary.Text == "" || txbPosition.Text == ""
                || txbPhoneNumber.Text == "")
                MessageBox.Show("Missing Information ! Please type again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (UpdateEmployee_Event != null) // DK EVENT O FORM1
            {
                UpdateEmployee_Event(txbCard.Text, txtName.Text, dateTimePicker1.Value, cbGender.SelectedItem.ToString(), txbPhoneNumber.Text, Convert.ToInt32(txtSalary.Text), txbPosition.Text);

                this.Close();
            }
            else
            {
                this.Close();
            }


        }


    }
}
