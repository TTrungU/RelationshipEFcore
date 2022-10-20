namespace BlogApp.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Passsword { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
