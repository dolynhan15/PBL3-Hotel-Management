using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HotelManagement.GUI.Rooms
{
    public partial class FoodBeverage : Form
    {
        private string room_name;
        private string datecheckin;
        private string datecheckout;

        List<Food_Beverage> food_Beverages = Food_BeverageDAO.Instance.GetFood_Beverages();
        public FoodBeverage(string name_room, string datecheckin, string datecheckout)
        {

            InitializeComponent();
            this.datecheckin = datecheckin;
            this.datecheckout = datecheckout;
            LoadFood_Beverage();
            room_name = name_room;
        }
        void LoadFood_Beverage()
        {
            List<Food_Beverage> food_Beverages = Food_BeverageDAO.Instance.GetFood_Beverages();
            flpBeverage.Controls.Clear();
            flpFood.Controls.Clear();
            foreach (Food_Beverage item in food_Beverages)
            {
                Button btn = new Button();
                if (item.Type.Contains("Food"))
                    btn = new Button { Width = RoomDAO.RoomWidth + 60, Height = RoomDAO.RoomHeight + 60 };
                else
                    btn = new Button() { Width = RoomDAO.RoomWidth + 20, Height = RoomDAO.RoomHeight + 60 };
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                btn.ImageAlign = ContentAlignment.TopCenter;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.BackColor = Color.Snow;
                btn.FlatAppearance.MouseDownBackColor = Color.Snow;
                btn.FlatAppearance.MouseOverBackColor = Color.Aqua;
                btn.Font = new Font("Times New Roman ", 9);
                //////////////
                MemoryStream ms = new MemoryStream(item.Image);
                btn.Image = Image.FromStream(ms);

                ///////////////
                btn.BackgroundImageLayout = ImageLayout.Center;
                btn.Text = item.Name.Trim() + Environment.NewLine + item.Price + " VND";

                if (item.Type.Contains("Food"))
                {
                    btn.Margin = new Padding(15);
                    flpFood.Controls.Add(btn);

                }
                else if (item.Type.Contains("Beverage"))
                {
                    btn.Margin = new Padding(10);
                    flpBeverage.Controls.Add(btn);
                }

                btn.Click += btn_Click;
                btn.Tag = item;
            }

        }

        void btn_Click(object sender, EventArgs e)
        {
            int id_fb = ((sender as Button).Tag as Food_Beverage).Id_fb;
            ChooseService(id_fb, this.room_name);

        }

        void ChooseService(int id_fb, string room_name)
        {
            ChooseService chooseService = new ChooseService(id_fb, room_name, this.datecheckin, this.datecheckout);
            chooseService.ShowDialog();
            chooseService.Location = new Point(500, 150);
        }


    }


}
