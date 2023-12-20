using Domain.Common.Interfaces.DataAccess;
using Users.DataAccess.Models;

namespace Users.DataAccess.Repositories.Interfaces;

public interface IUserRepository : IGenericRepository<UserModel, Guid>
{
    
}