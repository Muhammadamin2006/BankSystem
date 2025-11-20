using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Bank.Application.Extension;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}