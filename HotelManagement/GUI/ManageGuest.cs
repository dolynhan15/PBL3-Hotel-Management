using HotelManagement.GUI.Guests;
using System;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class ManageGuest : UserControl
    {

        public ManageGuest()
        {
            InitializeComponent();

            Find_Guests uo = new Find_Guests();
            uo.Dock = DockStyle.Fill;
            pnlGuest.Controls.Add(uo);
            uo.BringToFront();
        }

        private void ManaGuest_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateGuest_Click(object sender, EventArgs e)
        {
            Create_Guests uo = new Create_Guests();
            uo.Dock = DockStyle.Fill;
            pnlGuest.Controls.Add(uo);
            uo.BringToFront();
        }

        private void btnFindUsers_Click(object sender, EventArgs e)
        {
            Find_Guests uo = new Find_Guests();
            uo.Dock = DockStyle.Fill;
            pnlGuest.Controls.Add(uo);
            uo.BringToFront();
        }
    }
}
