using Books.API.Server.Models;
using Books.API.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace Books.API.Server.Controllers
{
    [ApiController]
    [Route("books")]
    [TypeFilter(typeof(ApiExceptionFilter))]
    public class BooksController(IBookService bookService) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBooks()
        {
            var response = bookService.GetBooks();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var response = bookService.GetBook(id);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult AddBook(BookDto book)
        {
            var response = bookService.AddBook(book);
            return Ok(response);
        }

        [HttpPatch]
        public IActionResult UpdateBook(int id, BookDto book)
        {
            var response = bookService.UpdateBook(id, book);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var response = bookService.DeleteBook(id);
            return Ok(response);
        }
    }
}
