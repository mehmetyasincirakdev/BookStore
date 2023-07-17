using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Common;
using WebApi.DataAccess;
using WebApi.Entity;

namespace WebApi.Business.BookManager
{
    public class GetAllBooks
    {
        private readonly BookStoreDbContext _context;

        public GetAllBooks(BookStoreDbContext context)
        {
            _context = context;
        }

        public List<BooksViewModel> GetAll()
        {
            var bookList = _context.Books.OrderBy(command => command.Id).ToList();
            List<BooksViewModel> viewModel = new List<BooksViewModel>();
            foreach (var book in bookList)
            {
                viewModel.Add(new BooksViewModel()
                {
                    Title = book.Title,
                    PageCount = book.PageCount,
                    PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy"),
                    Genre = ((GenreEnum)book.GenreId).ToString()
                });
            }
            return viewModel;
        }
    }
    public class BooksViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
    }
}