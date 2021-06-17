using HotelManagement.BLL;
using HotelManagement.DAO;
using HotelManagement.DTO;
using HotelManagement.GUI.Rooms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class ManageRoom : UserControl
    {
        List<Room> rooms = RoomDAO.Instance.GetRooms();
        List<Room> busyrooms;
        List<Room> fixrooms = RoomDAO.Instance.GetFixRooms();
        public ManageRoom(Account account)
        {
            InitializeComponent();
            if (account.Type == "Receptionist")
                btnCreateUsers.Hide();
            DateTime checkout = dateFrom.Value;
            checkout = checkout.AddDays(1);
            dateTo.Value = checkout;

            pnlFind.Controls.Add(this.flpRoom);
            RoomBLL.Instance.LoadTypeRoom(cbTyperoom);
            LoadRoomByType(0);
            flpRoom.BringToFront();


        }

        void LoadRoomByType(int idtype)
        {

            if (flpRoom.Controls.Count > 0)
                flpRoom.Controls.Clear();

            foreach (Room item in rooms)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth + 8, Height = RoomDAO.RoomHeight + 20 };
                if (item.Id_type == 1)
                {
                    if (item.Status_room.Contains("None"))
                        btn.BackgroundImage = HotelManagement.Properties.Resources.room1;
                    else if (item.Status_room.Contains("Fix"))
                        btn.BackgroundImage = HotelManagement.Properties.Resources.room1_fix;
                    else
                        btn.BackgroundImage = HotelManagement.Properties.Resources.room_1_busy;


                }
                else if (item.Id_type == 2)
                {

                    if (item.Status_room.Contains("None"))
                        btn.BackgroundImage = HotelManagement.Properties.Resources.room2;
                    else if (item.Status_room.Contains("Fix"))
                        btn.BackgroundImage = HotelManagement.Properties.Resources.room2_fix;
                    else
                        btn.BackgroundImage = HotelManagement.Properties.Resources.room2_busy;

                }

                else if (item.Id_type == 3)
                {
                    if (item.Status_room.Contains("None"))
                        btn.BackgroundImage = HotelManagement.Properties.Resources.room3;
                    else if (item.Status_room.Contains("Fix"))
                        btn.BackgroundImage = HotelManagement.Properties.Resources.room3_fix;
                    else
                        btn.BackgroundImage = HotelManagement.Properties.Resources.room3_busy;

                }
                else if (item.Id_type == 4)
                {
                    if (item.Status_room.Contains("None"))
                        btn.BackgroundImage = HotelManagement.Properties.Resources.room4;
                    else if (item.Status_room.Contains("Fix"))
                        btn.BackgroundImage = HotelManagement.Properties.Resources.room4_fix;
                    else
                        btn.BackgroundImage = HotelManagement.Properties.Resources.room4_busy;


                }
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Text = item.Name;
                btn.BackgroundImageLayout = ImageLayout.Center;
                if (item.Id_type == 2) btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.ImageAlign = ContentAlignment.MiddleCenter;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.BackColor = Color.Snow;
                btn.FlatAppearance.MouseDownBackColor = Color.Snow;
                btn.FlatAppearance.MouseOverBackColor = Color.Aqua;
                btn.Font = new Font("Times New Roman ", 10);

                btn.Click += btn_Click;
                btn.Tag = item;

                btn.Margin = new Padding(20);


                if (idtype == 0) flpRoom.Controls.Add(btn);
                else if (item.Id_type == idtype) flpRoom.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            int idRoom = ((sender as Button).Tag as Room).Id_room;
            string status = ((sender as Button).Tag as Room).Status_room;
            if (status.Contains("None"))
                RoomBLL.Instance.ShowCheckIn(idRoom);
            else if (status.Contains("Busy")) RoomBLL.Instance.ShowCheckout(idRoom);
            else MessageBox.Show("This room is fixing. Please choose another Room !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LoadDataAgain();

        }
        private void cbTyperoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpRoom.Controls.Clear();
            
            ComboBox cb = sender as ComboBox;
            Type_Room selected = cb.SelectedItem as Type_Room;
            if (cb.SelectedItem.ToString().Contains("Full"))
            {
                LoadRoomByType(0);
                return;
            }
            int id = selected.Id_TypeRoom;
            LoadRoomByType(id);

        }

        private void btnFindUsers_Click(object sender, EventArgs e)
        {
            pnlFind.Visible = true;
            pnlFind.BringToFront();
            LoadDataAgain();
            cbTyperoom.BringToFront();
        }

        void LoadDataAgain()
        {
            DateTime datefrom =dateFrom.Value;
            DateTime dateto = dateTo.Value;

            if (dateTo.Value < dateFrom.Value)
            {
                MessageBox.Show("Date To cannot be smaller then Date From", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            rooms = RoomDAO.Instance.GetRooms();
            fixrooms = RoomDAO.Instance.GetFixRooms();
            busyrooms = RoomDAO.Instance.GetListRoomByDate(datefrom, dateto);
            if (busyrooms.Count > 0)
            {
                foreach (Room item in rooms)
                {
                    item.Status_room = "None";
                    foreach (Room item1 in busyrooms)
                        if (item.Id_room == item1.Id_room)
                            item.Status_room = "Busy";

                }
            }
            else
            {
                busyrooms.Clear();
                foreach (Room item in rooms)
                {
                    item.Status_room = "None";
                }

            }

            if (fixrooms.Count > 0)
                foreach (Room item in rooms)
                {
                    foreach (Room item1 in fixrooms)
                        if (item.Id_room == item1.Id_room)
                            item.Status_room = "Fix";

                }
            LoadRoomByType(0);

        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            RoomBLL.Instance.GetDate(dateFrom.Value, dateTo.Value);
            LoadDataAgain();
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            RoomBLL.Instance.GetDate(dateFrom.Value, dateTo.Value);
            LoadDataAgain();
        }

        private void btnCreateUsers_Click(object sender, EventArgs e)
        {
            Create_Room uo = new Create_Room();
            uo.Dock = DockStyle.Fill;
            pnlRoom.Controls.Add(uo);
            uo.BringToFront();

        }

        private void btnCheckToday_Click(object sender, EventArgs e)
        {
            string s = "\n";
            List<Room> checkoutroom = RoomDAO.Instance.GetListRoomCheckOut(DateTime.Today);
            foreach (Room room in checkoutroom)
                s += room.Name + "\n";
            MessageBox.Show("There are " + checkoutroom.Count + " room have to check out today" + s, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
