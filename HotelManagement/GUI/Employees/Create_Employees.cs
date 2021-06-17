﻿using HotelManagement.BLL;
using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Windows.Forms;

namespace HotelManagement.GUI.Employees
{
    public partial class Create_Employees : UserControl
    {
        public Create_Employees()
        {
            InitializeComponent();
        }

        private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
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
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void txb1_KeyPress(object sender, KeyPressEventArgs e)
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
            string position = txbPosition.Text;
            string date_birth = dateTimePicker1.Value.ToString();
            string salary = txtSalary.Text;
            string phone = txbPhoneNumber.Text;
            int this_year = DateTime.Now.Year;

            Employee emp = EmployeeDAO.Instance.GetIdentitaion(card);
            if (emp != null)
            {
                MessageBox.Show("Employee already exists", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (card == "" || name == "")
            {
                MessageBox.Show("Missing Information please type again", "Alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if ((this_year - dateTimePicker1.Value.Year) < 15 || (this_year - dateTimePicker1.Value.Year) > 100)
            {
                MessageBox.Show("Person's age shall not be allowed. Maybe you forgot to change the year value?", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EmployeeBLL.Instance.AddEmp(card, name, phone, gender, date_birth, salary, position); 
            }
        }

    

        private void txbCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            foreach (Control childControl in groupEmp.Controls)
                if (childControl is TextBox)
                    childControl.ResetText();
        }
    }

}
