namespace BlogApp.Model
{
    public class PostImage
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Caption { get; set; }
        public Post Post { get; set; }
    }
}
