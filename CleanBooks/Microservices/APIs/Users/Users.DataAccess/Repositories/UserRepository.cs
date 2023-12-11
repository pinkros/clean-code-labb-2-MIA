using Users.DataAccess.Models.Interfaces;
using Users.DataAccess.Repositories.Interfaces;

namespace Users.DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    public Task<IUserModel> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IUserModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(IUserModel entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(IUserModel entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}