using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : IProductDal
    {
        BookStoreDbContext _context;

        public EfBookDal(BookStoreDbContext context)
        {
            _context = context;
        }

        public void Add(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            return _context.Set<Book>().SingleOrDefault(filter);
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            return filter == null ? _context.Set<Book>().ToList() : _context.Set<Book>().Where(filter).ToList();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
