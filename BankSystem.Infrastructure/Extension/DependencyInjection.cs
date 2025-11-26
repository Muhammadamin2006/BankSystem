using BankSystem.Application.Extension;
using BankSystem.Application.IRepository;
using BankSystem.Application.IService;
using BankSystem.Application.Service;
using BankSystem.Infrastructure.DbContext;
using BankSystem.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BankSystem.Infrastructure.Extension;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
    {
        services.AddDbContext<BankSystemDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped(typeof(IGenericRepository<>),  typeof(GenericRepository<>));
        services.AddScoped<IClientRepository, ClientRepository>();
        services.AddScoped<IClientService, ClientService>();
        services.AddScoped<IClientCsvService,  ClientCsvService>();
        
        
        
        return services;
    }
}
