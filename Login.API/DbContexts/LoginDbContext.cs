using Microsoft.EntityFrameworkCore;
using Login.API.Entities;

namespace Login.API.DbContexts;

public class LoginDbContext(DbContextOptions<LoginDbContext> options) : DbContext(options)
{
    public DbSet<Access> Logins { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }


}
