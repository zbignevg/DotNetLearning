using _015_BookStore.Models;

namespace _015_BookStore.Services

{
    public class BookService : IBookService
    {
        List<Book> Books { get; }
        private IAuthorService AuthorService;


        public BookService(IAuthorService authorService)
        {
            AuthorService = authorService;
            var firstAuthor = AuthorService.Get(1);
            var secondAuthor = AuthorService.Get(2);
            Books = new List<Book>
            {
                new Book { Id = 1, Title = ".NET Learning", Author = firstAuthor},
                new Book { Id = 2, Title = "PHP Learning", Author = firstAuthor},
                new Book { Id = 3, Title = "Vanilla JS Learning", Author = firstAuthor},
                new Book { Id = 4, Title = "Coding strategies", Author = secondAuthor},
                new Book { Id = 5, Title = "Design Patterns", Author = secondAuthor},
                new Book { Id = 6, Title = "Unit tests", Author = secondAuthor},
            };
        }

        public List<Book> GetAll() => Books;

        public Book? Get(int id) => Books.FirstOrDefault(x => x.Id == id);

        public void Add(Book book)
        {
            book.Id = Books.Count + 1;
            Books.Add(book);
        }

        public void Delete(int id)
        {
            var book = Get(id);
            if (book is null) return;

            Books.Remove(book);
        }

        public void Update(Book book)
        {
            var index = Books.FindIndex(p => p.Id == book.Id);

            if (index < 0) return;

            Books[index] = book;
        }
    }
}
