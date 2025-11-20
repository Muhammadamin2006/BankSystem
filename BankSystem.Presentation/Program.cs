using BankSystem.Application.Extension;
using BankSystem.Application.Mappers;
using BankSystem.Infrastructure.Extension;

namespace BankSystem.Presentation;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services
            .AddApplication()
            .AddInfrastructure(builder.Configuration);  //подключение из extension двух слоев в которых есть зависимости DI

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer(); // нужно для Swagger
        builder.Services.AddSwaggerGen(); // подключаем Swagger
        builder.Services.AddAutoMapper(typeof(Program).Assembly, typeof(RequestResponseMapper).Assembly);


        //builder.Services.AddOpenApi();


        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bank System API v1");
                c.RoutePrefix = string.Empty; // чтобы Swagger открывался сразу на /
                c.EnableTryItOutByDefault(); // автоматически включает Try it out для всех методов
            });

        }

            
        //app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}

