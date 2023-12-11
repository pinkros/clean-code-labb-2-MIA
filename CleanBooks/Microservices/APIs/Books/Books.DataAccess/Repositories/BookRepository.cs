using Books.DataAccess.Models;
using Books.DataAccess.Models.Interfaces;
using Books.DataAccess.Repositories.Interfaces;

namespace Books.DataAccess.Repositories;

public class BookRepository : IBookRepository
{
    public Task<IBookModel> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IBookModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(IBookModel entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(IBookModel entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }
}