using System.ComponentModel.DataAnnotations;
using Users.DataAccess.Models.Interfaces;

namespace Users.DataAccess.Models;

public class UserModel : IUserModel
{
    [Key]
    public Guid Id { get; init; }

    [Required]
    public string Email { get; set; }
}