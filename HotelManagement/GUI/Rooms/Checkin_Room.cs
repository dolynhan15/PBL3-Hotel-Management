using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace HotelManagement.GUI.Rooms
{

    public partial class Checkin_Room : Form
    {
        private Bill bill;
        private Room room;
        private Guest guest;
        List<Guest> list_guests = GuestDAO.Instance.GetGuests();
        List<Employee> list_employees = EmployeeDAO.Instance.GetEmp();

        private int id_staff = 0;

        private int discount = 0;
        public Checkin_Room(int id, DateTime date, int totaldays)
        {
            InitializeComponent();
            LoadRoom(id);
            this.discount = BillDAO.Instance.GetDiscount(date.ToShortDateString());
            txtDiscount.Text = this.discount.ToString() + "%";
            dateCheckIN.Value = date;
            dateSet.Value = date;
            dateCheckIN.Enabled = false;
            txtCard.DataSource = list_guests;
            txtCard.DisplayMember = "Identification_card";
            txtStaff.DataSource = list_employees;
            txtStaff.DisplayMember = "Name";

            totalDay.Maximum = totaldays;
            totalDay.Value = totaldays;
        }
        void LoadRoom(int id)
        {



            var typerooms = RoomDAO.Instance.GetRooms(id);
            txtRoom.Text = typerooms.Item1;
            txtType.Text = typerooms.Item2.Trim();
            txtRoomPrice.Text = typerooms.Item3.ToString();

            room = RoomDAO.Instance.GetRoomByName(txtRoom.Text);
        }

        public bool check()
        {
            guest = GuestDAO.Instance.GetIdentitaion(txtCard.Text);
            if (guest != null)
            {
                txtName.Text = guest.Name;
                txtEmail.Text = guest.Email;
                txtNationally.Text = guest.Nationality;
                cbGender.Text = guest.Gender;
                dateBirth.Value = guest.Date_birth;
                txtPhone.Text = guest.Phone;

                return true;

            }



            else if (txtCard.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Missing Information please type again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtStaff.Text == "")
            {
                MessageBox.Show("Missing Employee please type again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show("Create New Guest", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddGuest(txtCard.Text, txtName.Text, txtPhone.Text, cbGender.Text, dateBirth.Value.ToString(), txtEmail.Text, txtNationally.Text);
                return true;
            }



        }
        private void btnCheckIN(object sender, System.EventArgs e)
        {

            if (check())
            {
                if (txtStaff.Text != "")
                {
                    foreach (Employee employee in list_employees)
                    {
                        if (employee.Name == txtStaff.Text)
                        {
                            this.id_staff = employee.Id;
                            break;
                        }
                    }
                    if (this.id_staff == 0)
                    {
                        MessageBox.Show("Employee does not exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }

                if (MessageBox.Show("Are you sure to CHECK IN ?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)

                {
                    room.Status_room = "Busy";
                    int RoomPrice = Convert.ToInt32(txtRoomPrice.Text); ;

                    int totalMoney = (int)totalDay.Value * RoomPrice;

                    DateTime checkout = dateCheckIN.Value;
                    checkout = checkout.AddDays((int)totalDay.Value);

                    txtRoomPrice.Text = RoomPrice.ToString("C");
                    txtTotal.Text = totalMoney.ToString("C");

                    guest = GuestDAO.Instance.GetIdentitaion(txtCard.Text);

                    BillDAO.Instance.InsertBill(this.id_staff.ToString(), guest.Id.ToString(), dateSet.Value.ToString(), dateCheckIN.Value.ToShortDateString(), checkout.ToShortDateString(), this.discount.ToString(), totalMoney.ToString(), guest.Identification_card);

                    bill = BillDAO.Instance.GetBillByIdBill();

                    BillinfoDAO.Instance.InsertBillinfoCheckIn(bill.Id_bill.ToString(), room.Id_room.ToString());

                    btnCheckin.Enabled = false;



                }
            }
        }

        void AddGuest(string card, string name, string phone, string gender, string date, string email, string nationality)
        {
            if (GuestDAO.Instance.InsertGuest(card, name, phone, gender, date, email, nationality))
                MessageBox.Show("Create Guest Successfull ! ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Create Guest Failed", "Alert", MessageBoxButtons.OK);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }



}
