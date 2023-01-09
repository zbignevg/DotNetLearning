using _015_BookStore.Models;

namespace _015_BookStore.Services

{
    public class AuthorService : IAuthorService
    {
        List<Author> Authors { get; }

        public AuthorService()
        {
            Authors = new List<Author>
            {
                new Author{ Id = 1, FirstName = "George", LastName = "Orwell" },
                new Author{ Id = 2, FirstName = "Steven", LastName = "King"},
            };
        }

        public List<Author> GetAll() => Authors;

        public Author? Get(int id) => Authors.FirstOrDefault(x => x.Id == id);

        public void Add(Author author)
        {
            author.Id = Authors.Count + 1;
            Authors.Add(author);
        }

        public void Delete(int id)
        {
            var author = Get(id);
            if (author is null) return;

            Authors.Remove(author);
        }

        public void Update(Author author)
        {
            var index = Authors.FindIndex(p => p.Id == author.Id);

            if (index < 0) return;

            Authors[index] = author;
        }
    }
}
