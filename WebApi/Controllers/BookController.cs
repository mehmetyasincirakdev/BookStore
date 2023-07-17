using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Business.BookManager;
using WebApi.CreateBook;
using WebApi.DataAccess;
using WebApi.Entity;
using static WebApi.CreateBook.CreateBookCommand;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class BookController : ControllerBase
    {
        private readonly BookStoreDbContext _context;


        public BookController(BookStoreDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            var getAll = new GetAllBooks(_context);
            var result = getAll.GetAll();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetByBookId(int id)
        {
            var book = _context.Books.Where(command => command.Id == id).SingleOrDefault();
            return Ok(book);
        }
        [HttpPost]
        public IActionResult AddBook(CreateBookModel createBookModel)
        {
            try
            {
                var command = new CreateBookCommand(_context);
                command.Model = createBookModel;
                command.Handle();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

    }
}
