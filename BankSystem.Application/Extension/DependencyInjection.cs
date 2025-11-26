using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BankSystem.Application.Extension;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}