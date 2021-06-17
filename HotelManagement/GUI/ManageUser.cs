using System;
using System.Drawing;
using System.Windows.Forms;
namespace HotelManagement
{
    public partial class ManageUser : UserControl
    {

        public ManageUser()
        {

            InitializeComponent();

            Find_Users uo = new Find_Users();
            uo.Dock = DockStyle.Fill;
            pnlUsers.Controls.Add(uo);
            pFindUsers.Height = btnFindUsers.Height;
            pFindUsers.Top = btnFindUsers.Top;
            btnFindUsers.BackColor = Color.FromArgb(160, 210, 210);
            btnCreateUsers.BackColor = Color.FromArgb(190, 240, 255);
            uo.BringToFront();



        }

        private void btnFindUsers_Click(object sender, EventArgs e)
        {
            Find_Users uo = new Find_Users();
            uo.Dock = DockStyle.Fill;
            pnlUsers.Controls.Add(uo);
            pFindUsers.Height = btnFindUsers.Height;
            pFindUsers.Top = btnFindUsers.Top;
            btnFindUsers.BackColor = Color.FromArgb(160, 210, 210);
            btnCreateUsers.BackColor = Color.FromArgb(190, 240, 255);
            uo.BringToFront();
        }



        private void btnCreateUsers_Click(object sender, EventArgs e)
        {
            Create_Users uo = new Create_Users();
            uo.Dock = DockStyle.Fill;
            pnlUsers.Controls.Add(uo);
            pFindUsers.Height = btnCreateUsers.Height;
            pFindUsers.Top = btnCreateUsers.Top;
            btnFindUsers.BackColor = Color.FromArgb(190, 240, 255);
            btnCreateUsers.BackColor = Color.FromArgb(160, 210, 210);

            uo.BringToFront();
        }
    }
}

