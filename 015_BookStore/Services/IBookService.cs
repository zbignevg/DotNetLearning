using _015_BookStore.Models;

namespace _015_BookStore.Services
{
    public interface IBookService
    {
        public List<Book> GetAll();
        public Book? Get(int id);
        public void Add(Book book);
        public void Update(Book book);
        public void Delete(int id);
    }
}
