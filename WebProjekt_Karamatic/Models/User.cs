namespace WebProjekt_Karamatic.Models {
    //vereinfachte Klasse (keine ctors, ToString, Überprüfung)
    public class User {

        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
