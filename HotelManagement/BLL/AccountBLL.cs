using HotelManagement.DAO;
using HotelManagement.DTO;
using HotelManagement.GUI.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.BLL
{
    class AccountBLL
    {
        BindingSource User_list = new BindingSource();

        string _username_;

        private static AccountBLL instance;
        public static AccountBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBLL();
                return instance;
            }
        }

        public void LoadData()
        {
            User_list.DataSource = AccountDAO.Instance.GetAccount();
        }
        public void LoadGridview(DataGridView dtgvUserFind)
        {
            
            dtgvUserFind.Columns.Clear();
            dtgvUserFind.Columns.Add("username", "Username");
            dtgvUserFind.Columns.Add("name", "Display Name");
            dtgvUserFind.Columns.Add("type", "Type");
            dtgvUserFind.Columns.Add("phone", "Phone");
            dtgvUserFind.Columns.Add("gender", "Gender");
            dtgvUserFind.Columns.Add("pass", "Password");
            dtgvUserFind.Columns["pass"].Visible = false;
            foreach (Account s in this.User_list)
            {
                dtgvUserFind.Rows.Add(s.Username, s.DisplayName, s.Type, s.Phone, s.Gender, s.Pass);

            }
        }

        public void searchData(DataGridView dtgvUserFind, string searchTerm)
        {
            dtgvUserFind.Rows.Clear();

            foreach (Account s in this.User_list)
            {
                if (s.Username.ToLower().Contains(searchTerm.ToLower()) ||
                    s.DisplayName.ToLower().Contains(searchTerm.ToLower()) ||
                    s.Pass.ToLower().Contains(searchTerm.ToLower()) ||
                    s.Phone.ToLower().Contains(searchTerm.ToLower()) ||
                    s.Gender.ToLower().Contains(searchTerm.ToLower()) ||
                    s.Type.ToLower().Contains(searchTerm.ToLower())
                    )
                {
                    dtgvUserFind.Rows.Add(s.Username, s.DisplayName, s.Type, s.Phone, s.Gender, s.Pass);
                }
            }
        }

        public void ToUpdate(DataGridView dtgvUserFind)
        {
            UserInfor form = new UserInfor();
            form.UpdateUser_Event += UpdateUser_event;
            this._username_ = dtgvUserFind.CurrentRow.Cells[0].Value.ToString();

            form.txbUsername.Text = dtgvUserFind.CurrentRow.Cells[0].Value.ToString();
            form.txbName.Text = dtgvUserFind.CurrentRow.Cells[1].Value.ToString();
            form.txbPhoneNumber.Text = dtgvUserFind.CurrentRow.Cells[3].Value.ToString();
            form.cbGender.SelectedItem = dtgvUserFind.CurrentRow.Cells[4].Value;
            form.cbType.SelectedItem = dtgvUserFind.CurrentRow.Cells[2].Value;
            form.txbPassWord.Text = dtgvUserFind.CurrentRow.Cells[5].Value.ToString();
            form.ShowDialog();
            this.LoadGridview(dtgvUserFind);
        }

        void UpdateUser_event(string username, string displayName, string type, string gender, string phone, string repassword, string password = null)
        {
            foreach (Account s in this.User_list)
                if (string.Compare(s.Username, this._username_) == 0)
                {
                    s.Username = username;
                    s.DisplayName = displayName;
                    s.Phone = phone;
                    s.Gender = gender;
                    s.Type = type;
                    s.Pass = password;



                    if (AccountDAO.Instance.UpdateUser(this._username_, username, displayName, gender, password, phone, type))
                        MessageBox.Show("Update Success !", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Update Failed !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            
        }

        public void Delete(DataGridView dtgvUserFind)
        {
            if (dtgvUserFind.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure to delete this User?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this._username_ = dtgvUserFind.CurrentRow.Cells[0].Value.ToString();
                    int index = 0;

                    foreach (Account s in this.User_list)
                    {
                        if (string.Compare(s.Username, this._username_) == 0)
                        {
                            break;
                        }
                        index++;
                    }
                    User_list.RemoveAt(index);
                    if (AccountDAO.Instance.DeleteUser(this._username_))
                        MessageBox.Show("Delete Success !", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Delete Failed !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.LoadGridview(dtgvUserFind);
                }

            }
        }

    }
}
