using _015_BookStore.Models;
using _015_BookStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace _015_BookStore.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService AuthorService;

        public AuthorController(IAuthorService authorService)
        {
            AuthorService = authorService;
        }

        //GET
        [HttpGet] public ActionResult<List<Author>> GetAll() => Ok(AuthorService.GetAll());

        [HttpGet("{id}")]
        public ActionResult<Author> Get(int id)
        {
            var author = AuthorService.Get(id);

            return author == null ? NotFound() : Ok(author);
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            AuthorService.Add(author);
            return CreatedAtAction(nameof(Create), new { id = author.Id }, author);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Author author)
        {
            if (id != author.Id) return BadRequest();

            var existingAuthor = AuthorService.Get(id);

            if (existingAuthor is null) return NotFound();

            AuthorService.Update(author);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var author = AuthorService.Get(id);

            if (author != null)
            {
                AuthorService.Delete(id);
            }

            return NoContent();
        }

    }
}
