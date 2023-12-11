using Domain.Common.Interfaces.DataAccess;
using Users.DataAccess.Models.Interfaces;

namespace Users.DataAccess.Repositories.Interfaces;

public interface IUserRepository : IGenericRepository<IUserModel, Guid>
{
    
}