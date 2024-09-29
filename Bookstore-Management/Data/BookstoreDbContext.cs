using Bookstore_Management.Models;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace Bookstore_Management.Data
{
    public class BookstoreDbContext : DbContext
    {
        public BookstoreDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed Books Data 
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Price = 10.99m,
                    Genre = "Classic"
                },
                new Book
                {
                    Id = 2,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Price = 12.99m,
                    Genre = "Fiction"
                },
                new Book
                {
                    Id = 3,
                    Title = "1984",
                    Author = "George Orwell",
                    Price = 14.99m,
                    Genre = "Dystopian"
                },
                new Book
                {
                    Id = 4,
                    Title = "Moby Dick",
                    Author = "Herman Melville",
                    Price = 11.99m,
                    Genre = "Adventure"
                });
        }
    }
}