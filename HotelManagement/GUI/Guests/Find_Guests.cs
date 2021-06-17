using HotelManagement.BLL;
using System;
using System.Windows.Forms;

namespace HotelManagement.GUI.Guests
{
    public partial class Find_Guests : UserControl
    {

        public Find_Guests()
        {
            InitializeComponent();
            dtgvGuestFind.Show();
            dtgvGuestFind.BringToFront();
            GuestBLL.Instance.LoadData();
            GuestBLL.Instance.LoadGridview(dtgvGuestFind);
        }


        private void textBoxFindGuest_TextChanged(object sender, System.EventArgs e)
        {
            GuestBLL.Instance.searchData(textBoxFindGuest.Text, dtgvGuestFind);

        }

        private void DoubleClickRow(object sender, DataGridViewCellEventArgs e)
        {
            GuestBLL.Instance.ToUpdate(dtgvGuestFind);
       
        }

        private void btnUpdateGuest_Click(object sender, EventArgs e)
        {
            if (dtgvGuestFind.SelectedRows.Count > 0)
            {
                GuestBLL.Instance.ToUpdate(dtgvGuestFind);
            }
        }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            GuestBLL.Instance.DeleteGuest(dtgvGuestFind);

        }
    }
}
