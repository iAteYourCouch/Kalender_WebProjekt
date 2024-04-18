namespace WebProjekt_Karamatic.Models {
    //vereinfachte Klasse (keine ctors, ToString, Überprüfung)
    public class User {

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Hobbies { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
