using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entity;

namespace WebApi.DataAccess
{
    public class BookGenerator
    {
        public static void Initialize(BookStoreDbContext dbContext)
        {
            using (var context = new BookStoreDbContext())
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange
                (
                    new Book
                    {
                        Id = 1,
                        GenreId = 1,
                        Title = "Lord of The Rings The Fellowship",
                        PageCount = 500,
                        PublishDate = new DateTime(2001, 06, 05)
                    },
                    new Book
                    {
                        Id = 2,
                        GenreId = 1,
                        Title = "Lord of The Rings Two Tower",
                        PageCount = 600,
                        PublishDate = new DateTime(2003, 06, 05)
                    },
                    new Book
                    {
                        Id = 3,
                        GenreId = 1,
                        Title = "The Hobbit",
                        PageCount = 300,
                        PublishDate = new DateTime(1937, 09, 21)
                    },
                    new Book
                    {
                        Id = 4,
                        GenreId = 1,
                        Title = "The Hobbit",
                        PageCount = 300,
                        PublishDate = new DateTime(1937, 09, 21)
                    },
                    new Book
                    {
                        Id = 5,
                        GenreId = 1,
                        Title = "The Silmarillion",
                        PageCount = 365,
                        PublishDate = new DateTime(1977, 09, 15)
                    },
                    new Book
                    {
                        Id = 6,
                        GenreId = 1,
                        Title = "The Children of Húrin",
                        PageCount = 320,
                        PublishDate = new DateTime(2007, 04, 17)
                    },
                    new Book
                    {
                        Id = 7,
                        GenreId = 1,
                        Title = "The Unfinished Tales",
                        PageCount = 480,
                        PublishDate = new DateTime(1980, 10, 02)
                    },
                    new Book
                    {
                        Id = 8,
                        GenreId = 1,
                        Title = "Beren and Lúthien",
                        PageCount = 288,
                        PublishDate = new DateTime(2017, 06, 01)
                    },
                    new Book
                    {
                        Id = 9,
                        GenreId = 2,
                        Title = "The 7 Habits of Highly Effective People",
                        PageCount = 381,
                        PublishDate = new DateTime(1989, 08, 15)
                    },
                    new Book
                    {
                        Id = 10,
                        GenreId = 2,
                        Title = "Atomic Habits",
                        PageCount = 320,
                        PublishDate = new DateTime(2018, 10, 16)
                    },
                    new Book
                    {
                        Id = 11,
                        GenreId = 2,
                        Title = "Mindset: The New Psychology of Success",
                        PageCount = 320,
                        PublishDate = new DateTime(2006, 12, 26)
                    },
                    new Book
                    {
                        Id = 12,
                        GenreId = 2,
                        Title = "The Power of Now: A Guide to Spiritual Enlightenment",
                        PageCount = 236,
                        PublishDate = new DateTime(1997, 09, 29)
                    },
                    new Book
                    {
                        Id = 13,
                        GenreId = 2,
                        Title = "Thinking, Fast and Slow",
                        PageCount = 499,
                        PublishDate = new DateTime(2011, 10, 25)
                    },
                    new Book
                    {
                        Id = 14,
                        GenreId = 3,
                        Title = "Pride and Prejudice",
                        PageCount = 279,
                        PublishDate = new DateTime(1813, 01, 28)
                    },
                    new Book
                    {
                        Id = 15,
                        GenreId = 3,
                        Title = "To Kill a Mockingbird",
                        PageCount = 324,
                        PublishDate = new DateTime(1960, 07, 11)
                    },
                    new Book
                    {
                        Id = 16,
                        GenreId = 3,
                        Title = "1984",
                        PageCount = 328,
                        PublishDate = new DateTime(1949, 06, 08)
                    },
                    new Book
                    {
                        Id = 17,
                        GenreId = 3,
                        Title = "The Great Gatsby",
                        PageCount = 180,
                        PublishDate = new DateTime(1925, 04, 10)
                    },
                    new Book
                    {
                        Id = 18,
                        GenreId = 3,
                        Title = "To the Lighthouse",
                        PageCount = 209,
                        PublishDate = new DateTime(1927, 05, 05)
                    }

                );
                context.SaveChanges();
            }
        }
    }

}