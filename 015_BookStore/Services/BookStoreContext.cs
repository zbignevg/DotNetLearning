using _015_BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace _015_BookStore.Services
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
