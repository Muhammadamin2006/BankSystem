using Bank.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bank.Infrastructure.DbContext;

public class BankSystemDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public BankSystemDbContext(DbContextOptions<BankSystemDbContext> options) : base(options) { }
    
    public DbSet<Account> Accounts { get; set; }
    
}