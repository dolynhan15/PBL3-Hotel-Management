using HotelManagement.BLL;
using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Windows.Forms;

namespace HotelManagement.GUI.Employees
{
    public partial class Find_Employees : UserControl
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type, loginAccount.DisplayName); }
        }

        public void ChangeAccount(string type, string name)
        {

            int Type = 0;
            if (type.Contains("Manager")) Type = 1;
            else if (type.Contains("Reception")) Type = 2;

            if (Type == 1) // manager
            {

            }
            else if (Type == 2) // reception
            {
                btnDeleteUsers.Hide();
                btnUpdateUsers.Hide();
            }

        }
        public Find_Employees(Account account)
        {
            InitializeComponent();
            this.LoginAccount = account;
            dtgvEmployeesFind.Show();
            dtgvEmployeesFind.BringToFront();
            EmployeeBLL.Instance.LoadData();
            EmployeeBLL.Instance.LoadGridview(dtgvEmployeesFind);

            if (this.LoginAccount.Type.Contains("Reception"))
                dtgvEmployeesFind.Columns["salary"].Visible = false;

        }

     
       
        private void textBoxFindEmployee_TextChanged(object sender, System.EventArgs e)
        {
            EmployeeBLL.Instance.searchData(dtgvEmployeesFind,textBoxFindEmployee.Text);

        }
      
        private void DoubleClickRow(object sender, DataGridViewCellEventArgs e)
        {
            
            if (LoginAccount.Type.Contains("Manager"))
            {
              
                EmployeeBLL.Instance.ToUpdate(dtgvEmployeesFind);
             
            }
         }

     

        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            if (dtgvEmployeesFind.SelectedRows.Count > 0)
            {
                EmployeeBLL.Instance.ToUpdate(dtgvEmployeesFind);
              
            }

        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            EmployeeBLL.Instance.DeleteEmp(dtgvEmployeesFind);
        }
    }
}
