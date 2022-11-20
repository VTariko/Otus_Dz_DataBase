using Microsoft.EntityFrameworkCore;
using otus.dz.Domain.Models;

namespace otus.dz.DataAccess.PostgreSQL;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<BankAccount> BankAccounts { get; set; }
    public DbSet<Card> Cards { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}