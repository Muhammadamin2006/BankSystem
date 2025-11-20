using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BankSystem.Infrastructure.DbContext;

public class BankSystemDbContextFactory :  IDesignTimeDbContextFactory<BankSystemDbContext>
{
    public BankSystemDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            
        
        var optionsBuilder = new DbContextOptionsBuilder<BankSystemDbContext>();
        optionsBuilder.UseSqlServer(
            config.GetConnectionString("DefaultConnection")
            );
        return new BankSystemDbContext(optionsBuilder.Options);
    }
}