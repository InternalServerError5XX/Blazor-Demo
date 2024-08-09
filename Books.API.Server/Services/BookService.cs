using Books.API.Server.Models;

namespace Books.API.Server.Services
{
    public class BookService : IBookService
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Title1", Author = "Author1" },
            new Book { Id = 2, Title = "Title2", Author = "Author2" },
            new Book { Id = 3, Title = "Title3", Author = "Author3" }
        };

        public IEnumerable<Book> GetBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            var reponse = books.FirstOrDefault(x => x.Id == id);
            if (reponse == null)
                throw new NullReferenceException("Book not found");

            return reponse;
        }

        public Book AddBook(BookDto bookDto)
        {
            var response = new Book
            {
                Id = books.Max(x => x.Id) + 1,
                Title = bookDto.Title,
                Author = bookDto.Author
            };

            books.Add(response);
            return response;
        }

        public Book UpdateBook(int id, BookDto bookDto)
        {
            var response = GetBook(id);

            response.Title = bookDto.Title;
            response.Author = bookDto.Author;

            return response;
        }

        public bool DeleteBook(int id)
        {
            var response = GetBook(id);
            books.Remove(response);

            return true;
        }
    }
}
