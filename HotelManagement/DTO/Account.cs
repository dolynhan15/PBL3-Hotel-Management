using System.Data;

namespace HotelManagement.DTO
{
    public class Account
    {
        private string username;

        private string gender;
        private string phone;
        public Account(string username, string displayName, string type, string gender, string phone, string password = null)
        {
            this.Username = username;
            this.DisplayName = displayName;
            this.Type = type;
            this.Pass = password;
            this.Gender = gender;
            this.Phone = phone;
        }

        public Account(DataRow row)
        {
            this.Username = row["Username"].ToString().Trim();
            this.DisplayName = row["Displayname"].ToString().Trim();
            this.Gender = row["Gender"].ToString().Trim();
            this.Pass = row["Pass"].ToString().Trim();
            this.Type = row["type"].ToString().Trim();
            this.Phone = row["Phone"].ToString();

        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }


        public string Username { get => username; set => username = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
