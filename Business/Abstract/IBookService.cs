using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entity;

namespace Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        List<Book> GetAllByCategoryId(int id);
        List<Book> GetByPageCount(decimal min, decimal max);
        //<List<BookDetailDto> GetBookDetails();
        Book GetById(int bookId);
        void Add(Book book);
        void Update(Book book);
    }
}
