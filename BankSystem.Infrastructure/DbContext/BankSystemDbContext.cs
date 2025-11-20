using BankSystem.Domain.Entities;
using BankSystem.Domain.Entities.Account;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.Infrastructure.DbContext;

public class BankSystemDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public BankSystemDbContext(DbContextOptions<BankSystemDbContext> options) : base(options) { }
    
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Client> Clients { get; set; }
    
    
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     
    //     modelBuilder.ApplyConfigurationsFromAssembly(typeof(BankSystemDbContext).Assembly);
    //     
    //     base.OnModelCreating(modelBuilder);
    //     
    // }
    
}
