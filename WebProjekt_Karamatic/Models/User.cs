namespace WebProjekt_Karamatic.Models {
    public class User {

        private int UserId; 
        public int GetId() {
            return UserId;
        }
        public void SetId(int userId) {
            if (userId >= 0) {
                UserId = userId;
            }
            else {
                Console.WriteLine("Ungültige UserId!!!");
            }
        }


        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }

        public User() : this(0, "", "", "", "", DateTime.MinValue) { }

        public User(int userId, string firstname, string lastname, string email, string password, DateTime birthdate) {
            UserId = userId;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Birthdate = birthdate;
        }

        public override string ToString() {
            return this.UserId + " - " + this.Firstname + " " + this.Lastname + "\n"
                + this.Email;
        }
    }
}
