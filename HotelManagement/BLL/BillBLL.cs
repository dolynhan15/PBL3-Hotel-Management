using HotelManagement.DAO;
using HotelManagement.DTO;
using HotelManagement.GUI.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.BLL
{
    public class BillBLL
    {
        BindingSource bill_list = new BindingSource();
        int id;
        List<Employee> employees = EmployeeDAO.Instance.GetEmp();
        Account account;


        private static BillBLL instance;
        public static BillBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillBLL();
                return instance;
            }
        }

        public void GetAccount(Account account)
        {
            this.account = account;
        }

        public void LoadListMemberName(ComboBox cbGuest, ComboBox cbEmp)
        {
            List<Guest> listGuest = GuestDAO.Instance.GetGuests();
            cbGuest.DataSource = listGuest;
            cbGuest.DisplayMember = "Identification_card";
            cbGuest.ValueMember = "id";

            List<Employee> listEmp = EmployeeDAO.Instance.GetEmp();
            cbEmp.DataSource = listEmp;
            cbEmp.DisplayMember = "name";
            cbEmp.ValueMember = "id";
        }

        public void LoadGridview(DataGridView dtgvBillsFind)
        {
            bill_list.DataSource = BillDAO.Instance.GetBills();

            dtgvBillsFind.Columns.Clear();
            dtgvBillsFind.Columns.Add("id_bill", "ID");
            dtgvBillsFind.Columns.Add("guest", "Guest");
            dtgvBillsFind.Columns.Add("emp", "Employee");
            dtgvBillsFind.Columns.Add("date_set", "Date_set");
            dtgvBillsFind.Columns.Add("date_checkin", "Date_checkin");
            dtgvBillsFind.Columns.Add("date_checkout", "Date_checkout");
            dtgvBillsFind.Columns.Add("discount", "Discount");
            dtgvBillsFind.Columns.Add("total_money", "Total_money");
            dtgvBillsFind.Columns.Add("status", "Status");

            foreach (Bill s in this.bill_list)
            {
                foreach (Employee employee in this.employees)
                {
                    if (s.Id_emp == employee.Id)
                        dtgvBillsFind.Rows.Add(s.Id_bill.ToString(), s.Identitation_card_guest, employee.Name, s.Date_set.ToShortDateString(), s.Date_check_in.ToShortDateString(),
                            s.Date_check_out.ToShortDateString(), s.Discount.ToString(), s.Total_money.ToString(), s.Status);
                }
            }
        }
        public void searchData(DataGridView dtgvBillsFind, string searchTerm)
        {
            dtgvBillsFind.Rows.Clear();
            Employee employee = new Employee();
            foreach (Bill s in this.bill_list)
            {

                foreach (Employee item in this.employees)
                {
                    if (item.Id == s.Id_emp)
                        employee = item;
                }
                if (s.Identitation_card_guest.ToLower().Contains(searchTerm.ToLower()) ||
                s.Id_bill.ToString().Contains(searchTerm.ToLower()) ||
                employee.Name.ToLower().Contains(searchTerm.ToLower()) ||
                s.Date_set.ToShortDateString().Contains(searchTerm.ToLower()) ||
                s.Date_check_in.ToShortDateString().Contains(searchTerm.ToLower()) ||
                s.Date_check_out.ToShortDateString().Contains(searchTerm.ToLower()) ||
                 s.Status.ToLower().Contains(searchTerm.ToLower()) ||
                 s.Discount.ToString().Contains(searchTerm.ToLower()) ||
                 s.Total_money.ToString().Contains(searchTerm.ToLower()))
                {
                    dtgvBillsFind.Rows.Add(s.Id_bill.ToString(), s.Identitation_card_guest, employee.Name, s.Date_set.ToShortDateString(), s.Date_check_in.ToShortDateString(),
                     s.Date_check_out.ToShortDateString(), s.Discount.ToString(), s.Total_money.ToString(), s.Status);
                }

            }
        }

        public void ToUpdate(DataGridView dtgvBillsFind)
        {
            BillInfor form = new BillInfor(this.account);
            form.UpdateBill_Event += UpdateBill_event;

            this.id = Convert.ToInt32(dtgvBillsFind.CurrentRow.Cells[0].Value.ToString());
            Room room = RoomDAO.Instance.GetRoomByIdBill(this.id.ToString());

            if (room != null)
                form.txbRoomNumber.Text = room.Name;

            form.labelID.Text = dtgvBillsFind.CurrentRow.Cells[0].Value.ToString();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = OutputDAO.Instance.GetOutputs(form.labelID.Text);

            form.dtgvBillinfo.DataSource = bindingSource;
            form.cbGuest.Text = dtgvBillsFind.CurrentRow.Cells[1].Value.ToString();
            form.cbEmp.Text = dtgvBillsFind.CurrentRow.Cells[2].Value.ToString();
            form.dtpkSet.Value = Convert.ToDateTime(dtgvBillsFind.CurrentRow.Cells[3].Value);
            form.dtpkCheckIn.Value = Convert.ToDateTime(dtgvBillsFind.CurrentRow.Cells[4].Value);
            form.dtpkCheckOut.Value = Convert.ToDateTime(dtgvBillsFind.CurrentRow.Cells[5].Value);
            form.txbDiscount.Text = dtgvBillsFind.CurrentRow.Cells[6].Value.ToString() + "%";
            form.txbTotal.Text = dtgvBillsFind.CurrentRow.Cells[7].Value.ToString();
            form.txbStatus.Text = dtgvBillsFind.CurrentRow.Cells[8].Value.ToString();
            form.ShowDialog();
            this.LoadGridview(dtgvBillsFind);
        }

        void UpdateBill_event(string id_guest, DateTime date_set, DateTime date_check_in, DateTime date_check_out, string status, int discount, string total, string id_emp)
        {


            // Gan gia tri vao doi tuong

            foreach (Bill s in this.bill_list)
            {
                if (s.Id_bill == this.id)
                {

                    Guest guest = GuestDAO.Instance.GetGuestByID(id_guest);
                    BillDAO.Instance.UpdateBillMoney(this.id.ToString(),id_guest,id_emp,guest.Identification_card);
                    break;
                    
                }

            }
        }

        public void DeleteBill(DataGridView dtgvBillsFind)
        {
            if (dtgvBillsFind.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure to delete this Bill?", "Delete Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.id = Convert.ToInt32(dtgvBillsFind.CurrentRow.Cells[0].Value.ToString());
                    int index = 0;

                    foreach (Bill s in this.bill_list)
                    {
                        if (s.Id_bill == this.id)
                        {
                            break;
                        }
                        index++;
                    }
                    bill_list.RemoveAt(index);
                    BillinfoDAO.Instance.DeleteBillinfoandBill(id);
                    this.LoadGridview(dtgvBillsFind);
                    MessageBox.Show("Delete Successfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
