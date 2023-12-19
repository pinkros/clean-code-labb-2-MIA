using Microsoft.EntityFrameworkCore;
using Users.DataAccess.Models;

namespace Users.DataAccess.Contexts;

public class UsersDbContext : DbContext
{
    public DbSet<UserModel> Users { get; set; }

    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {

    }
}
