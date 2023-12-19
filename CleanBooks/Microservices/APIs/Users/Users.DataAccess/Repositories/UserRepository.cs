using Microsoft.EntityFrameworkCore;
using Users.DataAccess.Contexts;
using Users.DataAccess.Models;
using Users.DataAccess.Repositories.Interfaces;

namespace Users.DataAccess.Repositories;

public class UserRepository(UsersDbContext context) : IUserRepository
{

    public async Task<UserModel> GetByIdAsync(Guid id)
    {
        return await context.Users.FindAsync(id);
    }

    public async Task<IEnumerable<UserModel>> GetAllAsync()
    {
        return await context.Users.ToListAsync();
    }

    public async Task AddAsync(UserModel entity)
    {
        var existing = await context.Users.FirstOrDefaultAsync(e => e.Email.Equals(entity.Email));

        if (existing == null)
        {
            await context.Users.AddAsync(entity);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateAsync(UserModel entity, Guid id)
    {
        var existing = await context.Users.FindAsync(id);

        if (existing != null)
        {
            context.Users.Remove(existing);
            await context.SaveChangesAsync();
        }
    }

    public async Task DeleteAsync(Guid id)
    {
        var existing = await context.Users.FindAsync(id);

        if (existing != null)
        {
            context.Users.Update(existing);
            await context.SaveChangesAsync();
        }
    }
}