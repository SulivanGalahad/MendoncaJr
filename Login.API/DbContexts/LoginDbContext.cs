using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Login.API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Login.API.DbContexts;

public class LoginDbContext(DbContextOptions<LoginDbContext> options) : IdentityDbContext(options)
{
    public DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder.Entity<User>().HasData(
             new { IdUser = 1, Email = "dzutchaoz@gmail.com", Password = "Teste2234@@" }
             );

        base.OnModelCreating(modelBuilder);
    }


}
