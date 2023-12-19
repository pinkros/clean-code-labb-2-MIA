using Books.DataAccess.Contexts;
using Books.DataAccess.Models;
using Books.DataAccess.Models.Interfaces;
using Books.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Books.DataAccess.Repositories;

public class BookRepository(BooksDbContext context) : IBookRepository
{
    public async Task<BookModel> GetByIdAsync(Guid id)
    {
        return await context.Books.FindAsync(id);
    }

    public async Task<IEnumerable<BookModel>> GetAllAsync()
    {
        return await context.Books.ToListAsync();
    }

    public async Task AddAsync(BookModel entity)
    {
        var existingBook = await context.Books.FirstOrDefaultAsync(b => b.Name == entity.Name);
        if (existingBook == null)
        {
            await context.Books.AddAsync(entity);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateAsync(BookModel entity)
    {
        context.Books.Update(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await context.Books.FindAsync(id);
        if (entity != null)
        {
            context.Books.Remove(entity);
            await context.SaveChangesAsync();
        }
    }
}