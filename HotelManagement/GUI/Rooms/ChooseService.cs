using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HotelManagement.GUI.Rooms
{
    public partial class ChooseService : Form
    {
        Label label = new Label();
        private string datecheckin;
        private string datecheckout;
        public ChooseService(int id_fb, string room_name, string datecheckin, string datecheckout)
        {
            InitializeComponent();
            this.datecheckin = datecheckin;
            this.datecheckout = datecheckout;
            txtRoom.Text = room_name;
            Food_Beverage foodBeverage = Food_BeverageDAO.Instance.GetFood_Beverage(id_fb);
            label.Text = foodBeverage.Id_fb.ToString();
            txtPrice.Text = foodBeverage.Price.ToString();
            MemoryStream ms = new MemoryStream(foodBeverage.Image);
            btnImage.Image = Image.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Room room = RoomDAO.Instance.GetRoomByName(txtRoom.Text);
            List<Output> outputs = OutputDAO.Instance.GetOutputByRoom(room.Id_room, this.datecheckin,
                this.datecheckout);
            var typerooms = RoomDAO.Instance.GetRooms(room.Id_room);
            string id_bill = "";

            foreach (Output item in outputs)
            {
                id_bill = item.Id_bill.ToString();

            }
            int a = (int)numbericAmount.Value;
            int price = (int)numbericAmount.Value * Convert.ToInt32(txtPrice.Text);
            BillinfoDAO.Instance.InsertBillinfo(Convert.ToInt32(id_bill), Convert.ToInt32(label.Text), room.Id_room,
                (int)numbericAmount.Value);

            txtTotal.Text = price.ToString("C");

            MessageBox.Show("Update to Bill Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


        }
    }
}
