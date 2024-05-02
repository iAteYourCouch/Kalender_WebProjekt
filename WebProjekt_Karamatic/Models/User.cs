namespace WebProjekt_Karamatic.Models {
    //vereinfachte Klasse (keine ctors, ToString, Überprüfung)
    public class User {

        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }

        public User(int userId, string firstname, string lastname, string email, string password, DateTime birthdate) {
            UserId = userId;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Birthdate = birthdate;
        }
    }
}
