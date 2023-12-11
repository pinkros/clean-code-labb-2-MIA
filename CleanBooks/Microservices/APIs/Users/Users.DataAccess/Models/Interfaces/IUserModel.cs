using Domain.Common.Interfaces.DataAccess;

namespace Users.DataAccess.Models.Interfaces;

public interface IUserModel : IEntity<Guid>
{
    string Email { get; set; }
}