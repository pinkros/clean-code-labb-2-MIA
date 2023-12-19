using Books.DataAccess.Contexts;
using Books.DataAccess.Models;
using Books.DataAccess.Models.Interfaces;
using Books.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Books.DataAccess.Repositories;

public class BookRepository(BooksDbContext context) : IBookRepository
{
    public async Task<IBookModel> GetByIdAsync(Guid id)
    {
        return await context.Books.FindAsync(id);
    }

    public async Task<IEnumerable<IBookModel>> GetAllAsync()
    {
        return await context.Books.ToListAsync();
    }

    public async Task AddAsync(IBookModel entity)
    {
        var existingBook = await context.Books.FirstOrDefaultAsync(b => b.Name == entity.Name);
        if (existingBook == null)
        {
            await context.Books.AddAsync((BookModel)entity);
            await context.SaveChangesAsync();
        }
        
    }

    public async Task UpdateAsync(IBookModel entity)
    {
        context.Books.Update((BookModel)entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await context.Books.FindAsync(id);
        if (entity != null)
        {
            context.Books.Remove((BookModel)entity);
            await context.SaveChangesAsync();
        }
    }
}