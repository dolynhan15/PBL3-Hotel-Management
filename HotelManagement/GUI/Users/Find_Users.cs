using HotelManagement.BLL;
using HotelManagement.DAO;
using HotelManagement.DTO;
using HotelManagement.GUI.Users;
using System;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Find_Users : UserControl
    {
    
        public Find_Users()
        {
            InitializeComponent();
            dtgvUserFind.Show();
            dtgvUserFind.BringToFront();
            AccountBLL.Instance.LoadData();
            AccountBLL.Instance.LoadGridview(dtgvUserFind);
        }
     
    
        private void textBoxFindUser_TextChanged(object sender, System.EventArgs e)
        {
            AccountBLL.Instance.searchData(dtgvUserFind,textBoxFindUser.Text);

        }
    
        private void DoubleClickRow(object sender, DataGridViewCellEventArgs e)
        {
            AccountBLL.Instance.ToUpdate(dtgvUserFind);
            AccountBLL.Instance.LoadGridview(dtgvUserFind);
        }
    

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dtgvUserFind.SelectedRows.Count > 0)
            {
                AccountBLL.Instance.ToUpdate(dtgvUserFind);
                AccountBLL.Instance.LoadGridview(dtgvUserFind);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            AccountBLL.Instance.Delete(dtgvUserFind);
        }
    }
}
