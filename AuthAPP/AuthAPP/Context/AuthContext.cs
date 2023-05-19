using Microsoft.EntityFrameworkCore;

namespace AuthAPP.Data;

public class AuthContext : DbContext
{
    public AuthContext(DbContextOptions<AuthContext> options) : base(options)
    {
    }

    public DbSet<User> User { get; set; }
}