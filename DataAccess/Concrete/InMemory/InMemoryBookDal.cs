using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entity;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBookDal : IProductDal
    {
        List<Book> books;
        public InMemoryBookDal()
        {
            books = new List<Book>()
            {
                new Book { GenreId = 1, Title = "Yüzüklerin Efendisi Two Tower", PageCount = 350, PublishDate = new DateTime(2001, 02, 08)},
                new Book { GenreId = 2, Title = "Harry Potter and the Philosopher's Stone", PageCount = 336, PublishDate = new DateTime(1997, 06, 26) },
                new Book { GenreId = 1, Title = "To Kill a Mockingbird", PageCount = 281, PublishDate = new DateTime(1960, 07, 11) },
                new Book { GenreId = 3, Title = "1984", PageCount = 328, PublishDate = new DateTime(1949, 06, 08) },
                new Book { GenreId = 4, Title = "The Hobbit", PageCount = 310, PublishDate = new DateTime(1937, 09, 21) },
                new Book { GenreId = 2, Title = "The Hunger Games", PageCount = 374, PublishDate = new DateTime(2008, 09, 14) },
                new Book { GenreId = 1, Title = "Pride and Prejudice", PageCount = 279, PublishDate = new DateTime(1813, 01, 28) },
                new Book { GenreId = 4, Title = "The Lord of the Rings: The Return of the King", PageCount = 416, PublishDate = new DateTime(1955, 10, 20) },
                new Book { GenreId = 3, Title = "Fahrenheit 451", PageCount = 249, PublishDate = new DateTime(1953, 10, 19) },
                new Book { GenreId = 2, Title = "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe", PageCount = 206, PublishDate = new DateTime(1950, 10, 16) },
                new Book { GenreId = 4, Title = "The Great Gatsby", PageCount = 200, PublishDate = new DateTime(1925, 04, 10) },
                new Book { GenreId = 3, Title = "Brave New World", PageCount = 311, PublishDate = new DateTime(1932, 06, 25) },
                new Book { GenreId = 1, Title = "Jane Eyre", PageCount = 507, PublishDate = new DateTime(1847, 10, 16) },
                new Book { GenreId = 2, Title = "Twilight", PageCount = 498, PublishDate = new DateTime(2005, 10, 05) },
                new Book { GenreId = 4, Title = "Moby-Dick; or, The Whale", PageCount = 635, PublishDate = new DateTime(1851, 10, 18) },
                new Book { GenreId = 3, Title = "Animal Farm", PageCount = 112, PublishDate = new DateTime(1945, 08, 17) }
            };
        }

        public void Add(Book entity)
        {
            books.Add(entity);
        }

        public void Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            return books;
        }

        public List<Book> GetAllBooksByGenreId(int genreId)
        {
            return books.Where(command => command.GenreId == genreId).ToList();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
