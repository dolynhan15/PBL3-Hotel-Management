using HotelManagement.DAO;
using HotelManagement.DTO;
using HotelManagement.GUI.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.BLL
{
    public class EmployeeBLL
    {
        private static EmployeeBLL instance;

        BindingSource employee_list = new BindingSource();
        int id;
        public static EmployeeBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeBLL();
                return instance;
            }
        }

        public void LoadData()
        {
            employee_list.DataSource = EmployeeDAO.Instance.GetEmp();
        }
        public void LoadGridview(DataGridView dtgvEmployeesFind)
        {
           

            dtgvEmployeesFind.Columns.Clear();
            dtgvEmployeesFind.Columns.Add("id", "ID");
            dtgvEmployeesFind.Columns.Add("card", "Identification Card");
            dtgvEmployeesFind.Columns.Add("name", "Name");
            dtgvEmployeesFind.Columns.Add("phone", "Phone");
            dtgvEmployeesFind.Columns.Add("gender", "Gender");
            dtgvEmployeesFind.Columns.Add("date", "Date Of Birth");
            dtgvEmployeesFind.Columns.Add("salary", "Salary");
            dtgvEmployeesFind.Columns.Add("position", "Position");

            foreach (Employee s in this.employee_list)
            {
                dtgvEmployeesFind.Rows.Add(s.Id.ToString(), s.Identification_card, s.Name, s.Phone, s.Gender,
                    s.Date_birth.ToShortDateString(), s.Salary.ToString(), s.Position);

            }

           
        }

        public void searchData(DataGridView dtgvEmployeesFind,string searchTerm)
        {
            dtgvEmployeesFind.Rows.Clear();

            foreach (Employee s in this.employee_list)
            {
                if (s.Name.ToLower().Contains(searchTerm.ToLower()) ||
                    s.Id.ToString().Contains(searchTerm.ToLower()) ||
                    s.Identification_card.Contains(searchTerm.ToLower()) ||
                    s.Phone.ToString().Contains(searchTerm.ToLower()) ||
                    s.Date_birth.ToShortDateString().Contains(searchTerm.ToLower()) ||
                     s.Gender.ToLower().Contains(searchTerm.ToLower()) ||
                     s.Salary.ToString().Contains(searchTerm.ToLower()) ||
                     s.Position.ToLower().Contains(searchTerm.ToLower()))
                {
                    dtgvEmployeesFind.Rows.Add(s.Id.ToString(), s.Identification_card, s.Name, s.Phone, s.Gender, s.Date_birth.ToShortDateString(), s.Salary.ToString(), s.Position);
                }
            }
        }

        public void ToUpdate(DataGridView dtgvEmployeesFind)
        {
            EmployeeInfor form = new EmployeeInfor();
            form.UpdateEmployee_Event += UpdateEmployee_event;
            this.id = Convert.ToInt32(dtgvEmployeesFind.CurrentRow.Cells[0].Value.ToString());

            form.txbCard.Text = dtgvEmployeesFind.CurrentRow.Cells[1].Value.ToString();
            form.txbPosition.Text = dtgvEmployeesFind.CurrentRow.Cells[7].Value.ToString();
            form.txtName.Text = dtgvEmployeesFind.CurrentRow.Cells[2].Value.ToString();
            form.txtSalary.Text = dtgvEmployeesFind.CurrentRow.Cells[6].Value.ToString();
            form.txbPhoneNumber.Text = dtgvEmployeesFind.CurrentRow.Cells[3].Value.ToString();
            form.dateTimePicker1.Value = Convert.ToDateTime(dtgvEmployeesFind.CurrentRow.Cells[5].Value);
            form.cbGender.SelectedItem = dtgvEmployeesFind.CurrentRow.Cells[4].Value;

            form.ShowDialog();
            this.LoadGridview(dtgvEmployeesFind);
        }

        void UpdateEmployee_event(string card, string name, DateTime date_birth, string gender, string phone, int salary, string position)
        {
            // Kiem tra ID
            foreach (Employee s in this.employee_list)
            {
                if (s.Identification_card == card)
                {
                    if (s.Id == this.id)
                    {
                        continue;
                    }
                    MessageBox.Show("Employee already exists", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

            }
            // Gan gia tri vao doi tuong
            foreach (Employee s in this.employee_list)
            {
                if (s.Id == this.id)
                {

                    s.Identification_card = card;
                    s.Name = name;
                    s.Phone = phone;
                    s.Gender = gender;
                    s.Date_birth = date_birth;
                    s.Salary = salary;
                    s.Position = position;
                    break;
                }

            }
            if (EmployeeDAO.Instance.UpdateEmp(id, card, name, phone, gender, date_birth.ToString(), salary.ToString(), position))

                MessageBox.Show("Update Successfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Update Failed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void DeleteEmp(DataGridView dtgvEmployeesFind)
        {
            if (dtgvEmployeesFind.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure to delete this employee?", "Delete employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.id = Convert.ToInt32(dtgvEmployeesFind.CurrentRow.Cells[0].Value.ToString());
                    if (EmployeeDAO.Instance.DeleteEmp(this.id) != false)
                    {

                        int index = 0;

                        foreach (Employee s in this.employee_list)
                        {
                            if (s.Id == this.id)
                            {
                                break;
                            }
                            index++;
                        }
                        employee_list.RemoveAt(index);
                        this.LoadGridview(dtgvEmployeesFind);
                        MessageBox.Show("Delete Successfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }

        public void AddEmp(string card, string name, string phone, string gender, string date, string salary, string position)
        {
            if (EmployeeDAO.Instance.InsertEmp(card, name, phone, gender, date, salary, position))
                MessageBox.Show("Create Successfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Create Failed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
