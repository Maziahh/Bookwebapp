using Microsoft.EntityFrameworkCore;
using Bookwebapp.Data;
namespace Bookwebapp.Model
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookwebappContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookwebappContext>>()))
            {
                if (context == null || context.Book == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        PublishedDate = new DateTime(1925, 4, 10),
                        Price = 10.99m
                    },
                    new Book
                    {
                        Title = "To Kill a Mockingbird",
                        Author = "Harper Lee",
                        PublishedDate = new DateTime(1960, 7, 11),
                        Price = 12.99m
                    },
                    new Book
                    {
                        Title = "1984",
                        Author = "George Orwell",
                        PublishedDate = new DateTime(1949, 6, 8),
                        Price = 14.99m
                    },
                    new Book
                    {
                        Title = "Pride and Prejudice",
                        Author = "Jane Austen",
                        PublishedDate = new DateTime(1813, 1, 28),
                        Price = 9.99m
                    },
                    new Book
                    {
                        Title = "The Catcher in the Rye",
                        Author = "J.D. Salinger",
                        PublishedDate = new DateTime(1951, 7, 16),
                        Price = 11.99m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
