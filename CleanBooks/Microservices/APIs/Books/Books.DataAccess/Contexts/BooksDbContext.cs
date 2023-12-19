using Books.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Books.DataAccess.Contexts;

public class BooksDbContext : DbContext
{
    public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
    {
    }

    public DbSet<BookModel> Books { get; set; }

}