using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BankSystem.Infrastructure.DbContext;

public class BankSystemDbContextFactory :  IDesignTimeDbContextFactory<BankSystemDbContext>
{
    public BankSystemDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder() //Зачем ConfigurationBuilder? Чтобы собрать объект конфигурации и получить ConnectionString.
            
            .SetBasePath(Directory.GetCurrentDirectory()) //Зачем SetBasePath(Directory.GetCurrentDirectory())?
                                                         //Потому что EF CLI запускает процесс НЕ из WebApi проекта, а из того места, где ты выполняешь команду.
                                                        //Без этого он просто НЕ найдёт appsettings.json.
            .AddJsonFile("appsettings.json") // Чтобы подгрузить connect string из конфигурации.
            .Build();
        
        var optionsBuilder = new DbContextOptionsBuilder<BankSystemDbContext>(); //собирает и настраивает настройки DbContext, чтобы создать экземпляр контекста
        optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        return new BankSystemDbContext(optionsBuilder.Options);
    }
}