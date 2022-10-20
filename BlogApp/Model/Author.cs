namespace BlogApp.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public  Account Account { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
