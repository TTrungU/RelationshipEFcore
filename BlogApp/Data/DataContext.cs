using BlogApp.Model;
using Microsoft.EntityFrameworkCore;


namespace BlogApp.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Many-to-Many
            modelBuilder.Entity<PostCategory>()
                .HasKey(pc => new { pc.PostId, pc.CategoryId });
            modelBuilder.Entity<PostCategory>()
                .HasOne(pc => pc.Post)
                .WithMany(p => p.postCategories)
                .HasForeignKey(pc => pc.PostId);
            modelBuilder.Entity<PostCategory>()
                .HasOne(pc => pc.Category)
                .WithMany(c => c.PostCategories)
                .HasForeignKey(pc => pc.CategoryId);

            //One-To-One
            modelBuilder.Entity<Author>()
                .HasOne(a => a.Account)
                .WithOne(ac => ac.Author)
                .HasForeignKey<Account>(ac => ac.AuthorId);

            //Cascase Delete Limination Solution
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Author)
                .WithMany(au => au.Posts)
                .OnDelete(DeleteBehavior.ClientCascade);
        }

    }
}
