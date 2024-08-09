using Books.API.Server.Models;

namespace Books.API.Server.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        Book AddBook(BookDto bookDto);
        Book UpdateBook(int id, BookDto bookDto);
        bool DeleteBook(int id);
    }
}
