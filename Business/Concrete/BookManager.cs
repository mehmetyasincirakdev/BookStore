using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entity;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IProductDal _productDal;

        public BookManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Book book)
        {
            _productDal.Add(book);
        }

        public List<Book> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Book> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(command => command.GenreId == id);
        }

        public Book GetById(int bookId)
        {
            return _productDal.Get(command => command.Id == bookId);
        }

        public List<Book> GetByPageCount(decimal min, decimal max)
        {
            return _productDal.GetAll(command => command.PageCount >= min && command.PageCount <= max);
        }

        public void Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
