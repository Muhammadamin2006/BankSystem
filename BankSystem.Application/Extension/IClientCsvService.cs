using BankSystem.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace BankSystem.Application.Extension;

public interface IClientCsvService
{
    Task ProcessCsvFromFormFileAsync(IFormFile file); // для Swagger/IFormFile
    Task<string> GenerateClientsCsvAsync(IAsyncEnumerable<Client> clients, string path);
}