using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HotelManagement.GUI.Rooms
{
    public partial class BillinfoService : Form
    {
        Label label = new Label();
        private string nameroom;
        public BillinfoService(int id_fb, string idbill, string nameroom)
        {
            InitializeComponent();
            txtIdBill.Text = idbill;
            Food_Beverage foodBeverage = Food_BeverageDAO.Instance.GetFood_Beverage(id_fb);
            label.Text = foodBeverage.Id_fb.ToString();
            txtPrice.Text = foodBeverage.Price.ToString();
            MemoryStream ms = new MemoryStream(foodBeverage.Image);
            btnImage.Image = Image.FromStream(ms);
            this.nameroom = nameroom;
            txtRoom.Text = this.nameroom;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Room room = RoomDAO.Instance.GetRoomByName(txtRoom.Text);
            string id_bill = txtIdBill.Text;

            int a = (int)numbericAmount.Value;
            int price = (int)numbericAmount.Value * Convert.ToInt32(txtPrice.Text);
            BillinfoDAO.Instance.InsertBillinfo(Convert.ToInt32(id_bill), Convert.ToInt32(label.Text), room.Id_room,
                (int)numbericAmount.Value);

            txtTotal.Text = price.ToString("C");
            this.Close();

        }
    }
}
