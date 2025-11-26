using System.Net;
using System.Text.Json;
using BankSystem.Application.Exceptions;
using BankSystem.Web.ResponseModels;

namespace BankSystem.Web.Middleware;

public class GlobalExceptionMiddleware : IMiddleware
{
    private readonly ILogger<GlobalExceptionMiddleware> _logger;

    public GlobalExceptionMiddleware(ILogger<GlobalExceptionMiddleware> logger)
    {
        _logger = logger;
    }
    
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)  // Цель метода: обработать запрос, передав его дальше по конвейеру.
    {
        try
        {
            await next(context); // вызываем следующий middleware. Любой middleware должен вызывать _next, иначе запрос остановится.
        }
        catch (Exception ex) // Любая ошибка, выброшенная где-то в сервисах или контроллерах, попадает сюда.
        {
            _logger.LogError(ex, ex.Message); // логируем
            await HandleExceptionAsync(context, ex); // формируем ответ клиенту
        }
    }
    
    private async Task HandleExceptionAsync(HttpContext context,  Exception exception) // вызываем отдельный метод, который формирует ответ клиенту.
    {
        context.Response.ContentType = "application/json"; // клиенту будет возвращён JSON.
        
        var response = new ErrorResponse // Создаём объект ErrorResponse, чтобы всегда отдавать единый формат.
        {
            Message = exception.Message, // берём текст ошибки из объекта исключения, который мы выбросили в сервисе
        };
        
        switch (exception) // Цель: определить, какой HTTP статус вернуть в зависимости от типа исключения.
        {
            case NotFoundException:
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                break;
            case InsufficientFundsException:
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                break;
            case AccountBlockedException:
                context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                break;
            case ConflictException:
                context.Response.StatusCode = (int)HttpStatusCode.Conflict;
                break;
            case ValidationException:
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                break;
            default:
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                break;
        }
        
        response.StatusCode = context.Response.StatusCode; //Присваиваем код ошибки в ErrorResponse.StatusCode после определения
        
        var result = JsonSerializer.Serialize(response); // Сериализуем объект в JSON и отправляем клиенту потому что второе свойство в дто определяется в switch его тип не json
        await context.Response.WriteAsync(result);
        
    }
}