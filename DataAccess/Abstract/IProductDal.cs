using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entity;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Book> GetAll(Expression<Func<Book, bool>> filter = null);
        Book Get(Expression<Func<Book, bool>> filter);
        void Add(Book entity);
        void Update(Book entity);
        void Delete(Book entity);
    }
}
