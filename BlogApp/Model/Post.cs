namespace BlogApp.Model
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public Author Author { get; set; }
        public ICollection<PostImage>  PostImages { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<PostCategory> postCategories { get; set; }
       
    }
}
