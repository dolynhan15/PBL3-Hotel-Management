using HotelManagement.DAO;
using HotelManagement.DTO;
using HotelManagement.GUI.Guests;
using System;
using System.Windows.Forms;

namespace HotelManagement.BLL
{
    public class GuestBLL
    {
        private static GuestBLL instance;

        BindingSource Guest_list = new BindingSource();
        public static GuestBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new GuestBLL();
                return instance;
            }
        }

        int id;

        public void LoadData()
        {
            Guest_list.DataSource = GuestDAO.Instance.GetGuests();
        }
        public void LoadGridview(DataGridView dtgvGuestFind)
        {
         
            dtgvGuestFind.Columns.Clear();
            dtgvGuestFind.Columns.Add("id", "ID");
            dtgvGuestFind.Columns.Add("card", "Identification Card");
            dtgvGuestFind.Columns.Add("name", "Name");
            dtgvGuestFind.Columns.Add("phone", "Phone");
            dtgvGuestFind.Columns.Add("gender", "Gender");
            dtgvGuestFind.Columns.Add("date", "Date Of Birth");
            dtgvGuestFind.Columns.Add("Email", "Email");
            dtgvGuestFind.Columns.Add("Nationality", "Nationality");

            foreach (Guest s in this.Guest_list)
            {
                dtgvGuestFind.Rows.Add(s.Id.ToString(), s.Identification_card, s.Name, s.Phone, s.Gender,
                    s.Date_birth.ToShortDateString(), s.Email.ToString(), s.Nationality);

            }
        }

        public void searchData(string searchTerm, DataGridView dtgvGuestFind)
        {
            dtgvGuestFind.Rows.Clear();

            foreach (Guest s in this.Guest_list)
            {
                if (s.Name.ToLower().Contains(searchTerm.ToLower()) ||
                    s.Id.ToString().Contains(searchTerm.ToLower()) ||
                    s.Identification_card.Contains(searchTerm.ToLower()) ||
                    s.Phone.ToString().Contains(searchTerm.ToLower()) ||
                    s.Date_birth.ToShortDateString().Contains(searchTerm.ToLower()) ||
                     s.Gender.ToLower().Contains(searchTerm.ToLower()) ||
                     s.Email.ToString().Contains(searchTerm.ToLower()) ||
                     s.Nationality.ToLower().Contains(searchTerm.ToLower()))
                {
                    dtgvGuestFind.Rows.Add(s.Id.ToString(), s.Identification_card, s.Name, s.Phone, s.Gender, s.Date_birth.ToShortDateString(), s.Email.ToString(), s.Nationality);
                }
            }
        }

        public void ToUpdate(DataGridView dtgvGuestFind)
        {
            GuestInfor form = new GuestInfor();
            form.UpdateGuest_Event += UpdateGuest_event;
            this.id = Convert.ToInt32(dtgvGuestFind.CurrentRow.Cells[0].Value.ToString());
            form.oldname = dtgvGuestFind.CurrentRow.Cells[1].Value.ToString();
            form.txbCard.Text = dtgvGuestFind.CurrentRow.Cells[1].Value.ToString();
            form.txbNationality.Text = dtgvGuestFind.CurrentRow.Cells[7].Value.ToString();
            form.txtName.Text = dtgvGuestFind.CurrentRow.Cells[2].Value.ToString();
            form.txbEmail.Text = dtgvGuestFind.CurrentRow.Cells[6].Value.ToString();
            form.txbPhoneNumber.Text = dtgvGuestFind.CurrentRow.Cells[3].Value.ToString();
            form.dateTimePicker1.Value = Convert.ToDateTime(dtgvGuestFind.CurrentRow.Cells[5].Value);
            form.cbGender.SelectedItem = dtgvGuestFind.CurrentRow.Cells[4].Value;

            form.ShowDialog();
            this.LoadGridview(dtgvGuestFind);
        }

        void UpdateGuest_event(string Card, string name, DateTime date_birth, string gender, string phone, string email, string nationality,string oldname)
        {
            // Kiem tra ID
            foreach (Guest s in this.Guest_list)
            {
                if (s.Identification_card == Card)
                {
                    if (s.Id == this.id)
                    {
                        continue;
                    }
                    MessageBox.Show("ID already exits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

            }
            // Gan gia tri vao doi tuong
            foreach (Guest s in this.Guest_list)
            {
                if (s.Id == this.id)
                {

                    s.Identification_card = Card;
                    s.Name = name;
                    s.Phone = phone;
                    s.Gender = gender;
                    s.Date_birth = date_birth;
                    s.Email = email;
                    s.Nationality = nationality;
                    break;
                }

            }
            if (GuestDAO.Instance.UpdateGuest(id, Card, name, phone, gender, date_birth.ToString(), email, nationality,oldname))

                MessageBox.Show("Update Successfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Update Failed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        public void DeleteGuest(DataGridView dtgvGuestFind)
        {
            if (dtgvGuestFind.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure to delete this Guest?", "Delete Guest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.id = Convert.ToInt32(dtgvGuestFind.CurrentRow.Cells[0].Value.ToString());
                    if (GuestDAO.Instance.DeleteGuest(this.id) != false)
                    {

                        int index = 0;

                        foreach (Guest s in this.Guest_list)
                        {
                            if (s.Id == this.id)
                            {
                                break;
                            }
                            index++;
                        }
                        Guest_list.RemoveAt(index);
                        this.LoadGridview(dtgvGuestFind);
                        MessageBox.Show("Delete Successfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

            }
        }

       public void AddGuest(string card, string name, string phone, string gender, string date, string email, string nationality)
        {
            if (GuestDAO.Instance.InsertGuest(card, name, phone, gender, date, email, nationality))
                MessageBox.Show("Create Successfull", "Notification", MessageBoxButtons.OK);
            else
                MessageBox.Show("Create Failed", "Alert", MessageBoxButtons.OK);
        }
    }

}
