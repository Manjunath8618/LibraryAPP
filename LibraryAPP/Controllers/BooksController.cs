using LibraryAPP.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooks _books;
        public BooksController(IBooks books)
        { 
            _books = books;
        }
        [HttpGet("")]
        public async Task<IActionResult>GetAllBooks()
        {
            var books = await _books.GetAllBooks();
            if (books == null)
            {
                return NotFound();
            }
            return Ok(books);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById([FromRoute] int id)
        {
            var book = await _books.GetBookByID(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
    }
}
