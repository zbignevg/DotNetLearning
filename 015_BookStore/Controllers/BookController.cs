using _015_BookStore.Models;
using _015_BookStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace _015_BookStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService BookService;

        public BookController(IBookService bookService)
        {
            BookService = bookService;
        }

        //GET
        [HttpGet]
        public ActionResult<List<Book>> GetAll()
        {
            var books = BookService.GetAll();



            return Ok(BookService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            var book = this.BookService.Get(id);

            return book == null ? NotFound() : Ok(book);
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            BookService.Add(book);
            return CreatedAtAction(nameof(Create), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Book book)
        {
            if (id != book.Id) return BadRequest();

            var existingBook = BookService.Get(id);

            if (existingBook is null) return NotFound();

            BookService.Update(book);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = BookService.Get(id);

            if (book != null)
            {
                BookService.Delete(id);
            }

            return NoContent();
        }

    }
}
