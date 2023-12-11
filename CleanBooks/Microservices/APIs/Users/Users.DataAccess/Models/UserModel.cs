using Users.DataAccess.Models.Interfaces;

namespace Users.DataAccess.Models;

public class UserModel : IUserModel
{
    public Guid Id { get; }
    public string Email { get; set; }
}