using HotelManagement.DTO;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.DAO
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set { EmployeeDAO.instance = value; }
        }
        public List<Employee> GetEmp()
        {
            List<Employee> list = new List<Employee>();

            string query = "select * from Employees";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Employee category = new Employee(item);
                list.Add(category);
            }

            return list;
        }

        public Employee GetIdentitaion(string card)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Employees where identification_Card = '" + card + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Employee(item);
            }

            return null;
        }


        public bool InsertEmp(string card, string name, string phone, string gender, string date, string salary, string position)
        {
            string query = string.Format("Insert into Employees values ('" + card + "',N'" + name + "','" + phone + "','" + gender + "','" + date + "','" + salary + "','" + position + "','None') ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteEmp(int id_emp)
        {
            //BillinfoDAO.Instance.DeleteBillInfoByID(id_emp, 1);
            //BillDAO.Instance.DeleteBillByID(id_emp, 1);
            string query = "";
            string query1 = "Select COUNT(id_bill) from Bill where id_emp = " + id_emp.ToString();
            int num_bill = (int)DataProvider.Instance.ExecuteScalar(query1);

            if (num_bill <= 0)
            {

                query = string.Format("Delete from Employees where id_emp = " + id_emp.ToString());
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;

            }
            else
            {
                MessageBox.Show("Bills of this employee existed", "Can't delete",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateEmp(int id_emp, string card, string name, string phone, string gender, string date, string salary, string position)
        {

            string query = string.Format("Update Employees set identification_card = '" + card + "',name = N'" + name + "',phone = '" + phone + "',gender = '" + gender + "',date_birth = '" + date + "',salary = '" + salary + "',position = '" + position + "' WHERE id_emp = " + id_emp);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
