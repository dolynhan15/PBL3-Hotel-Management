using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.GUI.Rooms
{
    public partial class Create_Room : UserControl
    {
        List<Room> rooms = RoomDAO.Instance.GetRooms();
        List<Type_Room> type_Rooms = Type_RoomDAO.Instance.GetListCategory();
        public Create_Room()
        {

            InitializeComponent();

            txbName.DataSource = rooms;
            txbName.DisplayMember = "Name";
            int roomname = int.Parse(rooms[rooms.Count - 1].Name) + 1;
            txbName.Text = roomname.ToString();

            cbTyperoom.DataSource = type_Rooms;
            cbTyperoom.DisplayMember = "Name";
           
        }



        private void btnNew_Click(object sender, System.EventArgs e)
        {
            DateTime today = DateTime.Today;
            List<Room> busyroom = RoomDAO.Instance.GetListRoomByDate(today, today);

            string name = txbName.Text;
            string status = cbStatus.Text;
            int idtype =(int)cbTyperoom.SelectedValue;

            if (name == "" || cbTyperoom.Text == "")
            {
                MessageBox.Show("Missing Information please type again", "Alert",
                    MessageBoxButtons.OK);
                return;
            }

            else if (checkCase(txbName.Text) == 1)
            {
                foreach (Room room in busyroom)
                    if (room.Name.Contains(name))
                    {

                        MessageBox.Show("This room is being used cannot be changed !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                if (MessageBox.Show("Room has been exits! Do you want to Update Room ?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    UpdateRoom(name, idtype, status);
                }
            }
            else
            {
                if (MessageBox.Show("Room has not been exits! Do you want to Create New Room ?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    AddRoom(name, idtype, status);
                }

            }

        }

        void AddRoom(string name, int idtype, string status)
        {
            if (RoomDAO.Instance.InsertRoom(name, idtype, status))
                MessageBox.Show("Create Successfull", "Notification", MessageBoxButtons.OK);
            else
                MessageBox.Show("Create Failed", "Alert", MessageBoxButtons.OK);
        }

        void UpdateRoom(string name, int idtype, string status)
        {
            if (RoomDAO.Instance.UpdateRoom(name, idtype, status))
                MessageBox.Show("Update Successfull", "Notification", MessageBoxButtons.OK);
            else
                MessageBox.Show("Update Failed", "Alert", MessageBoxButtons.OK);
        }

        private void txbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        int checkCase(string name)
        {
            foreach (Room room in rooms)
            {
                if (room.Name.Contains(name))
                    return 1;
            }
            return 0;
        }


        private void txbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Room room in rooms)
            {
                if (room.Name.Contains(txbName.Text))
                {
                    cbStatus.Text = room.Status_room;
                    cbTyperoom.SelectedIndex = room.Id_type - 1;
                }
            }
        }
    }
}
