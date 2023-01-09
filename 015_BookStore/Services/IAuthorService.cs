using _015_BookStore.Models;

namespace _015_BookStore.Services
{
    public interface IAuthorService
    {
        public List<Author> GetAll();
        public Author? Get(int id);
        public void Add(Author author);
        public void Update(Author author);
        public void Delete(int id);
    }
}
