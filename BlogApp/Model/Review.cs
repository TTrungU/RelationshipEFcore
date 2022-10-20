namespace BlogApp.Model
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public  Author Reviewer { get; set; }
        public Post Post { get; set; }
    }
}
