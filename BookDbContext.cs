using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication3
{
    public class BookDbContext: DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
