using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelManagement.GUI.Rooms
{
    public partial class Checkout_Room : Form
    {
        private Bill bill;
        private Room room;
        private int idroom;
        private List<Room> rooms;
        private string datecheckin;
        private string datecheckout;
        public Checkout_Room(int idroom, string datecheckin, string datecheckout)
        {
            InitializeComponent();
            this.idroom = idroom;
            this.rooms = RoomDAO.Instance.GetRooms();
            this.datecheckin = datecheckin;
            this.datecheckout = datecheckout;
            LoadRoom();
            ShowBill();

            TimeSpan daycount = Convert.ToDateTime(datecheckout) - DateTime.Today;
            int differenceInDays = (int)daycount.TotalDays;
            if (differenceInDays > 0)
                button2.Enabled = false;

        }

        private int total_money;
        public int Total_money { get => total_money; set => total_money = value; }

        void ShowBill()
        {
            listService.Items.Clear();
            List<Output> outputs = OutputDAO.Instance.GetOutputByRoom(this.idroom, this.datecheckin, this.datecheckout);
            var typerooms = RoomDAO.Instance.GetRooms(this.idroom);
            int total_service = 0;
            string id_bill = "";

            foreach (Output item in outputs)
            {
                id_bill = item.Id_bill.ToString();
                if (item.Name.ToString() != "ROOM")
                {
                    ListViewItem listViewItem = new ListViewItem(item.Name.ToString());
                    listViewItem.SubItems.Add(item.Amount.ToString());
                    listViewItem.SubItems.Add(item.Price.ToString());
                    listViewItem.SubItems.Add(item.Total_price.ToString());
                    total_service += item.Total_price;
                    listService.Items.Add(listViewItem);
                }

            }

            bill = BillDAO.Instance.GetBillByIdBill(id_bill);

            dateCheckIN.Value = bill.Date_check_in;
            dateCheckOUT.Value = bill.Date_check_out;
            txtDiscount.Text = bill.Discount.ToString() + "%";

            TimeSpan totalday = bill.Date_check_out - bill.Date_check_in;
            int differenceInDays = (int)totalday.TotalDays;
            if (differenceInDays == 0) differenceInDays++;
            txtDays.Text = differenceInDays.ToString();

            Guest guest = GuestDAO.Instance.GetGuestByID(bill.Id_guest.ToString());
            txtCard.Text = guest.Identification_card;
            txtName.Text = guest.Name;
            txtPhone.Text = guest.Phone;

            txtFood_Bev.Text = total_service.ToString("C");
            int discount = bill.Discount;
            total_room_money.Text = (typerooms.Item3 * differenceInDays).ToString("C");
            this.Total_money = typerooms.Item3 * differenceInDays + total_service - (int)(typerooms.Item3 * differenceInDays + total_service) * discount / 100;
            txtTotal.Text = this.Total_money.ToString("C");
            bill.Status = "check";
        }
        void LoadRoom()
        {
            var typerooms = RoomDAO.Instance.GetRooms(this.idroom);
            txtRoom.Text = typerooms.Item1;
            txtRoomPrice.Text = typerooms.Item3.ToString("C");
            room = RoomDAO.Instance.GetRoomByName(txtRoom.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<Output> outputs = OutputDAO.Instance.GetOutputByRoom(room.Id_room, this.datecheckin, this.datecheckout);
            string id_bill = "";
            foreach (Output item in outputs)
            {
                id_bill = item.Id_bill.ToString();
            }


            if (MessageBox.Show("Are you sure to CHECK OUT ?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                BillDAO.Instance.ChangeStatusCheck(id_bill, Total_money.ToString());
                foreach (Room item in this.rooms)
                    if (item.Id_room == room.Id_room)
                        item.Status_room = "None";
                button2.Enabled = false;
                btnCancel.Enabled = false;
                btnFood_Bev.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to CANCEL BOOKING ?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                BillinfoDAO.Instance.DeleteBillinfoandBill(bill.Id_bill);
                foreach (Room item in this.rooms)
                    if (item.Id_room == room.Id_room)
                        item.Status_room = "None";


            }
            this.Close();
        }

        private void btnFood_Bev_Click(object sender, EventArgs e)
        {
            FoodBeverage foodBeverage = new FoodBeverage(txtRoom.Text, this.datecheckin, this.datecheckout);
            foodBeverage.ShowDialog(txtRoom);
            ShowBill();

        }
    }
}
