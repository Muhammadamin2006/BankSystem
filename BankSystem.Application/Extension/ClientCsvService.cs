using System.Text;
using BankSystem.Application.IRepository;
using BankSystem.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace BankSystem.Application.Extension;

public class ClientCsvService : IClientCsvService
{
    private readonly IClientRepository _clientRepository;

    public ClientCsvService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }
    
    // Чтение CSV из IFormFile (Swagger)
    public async Task ProcessCsvFromFormFileAsync(IFormFile file)
    {
        if (file == null || file.Length == 0) // проверка на существование файла
            throw new ArgumentException("Файл пустой или не выбран");

        using var reader = new StreamReader(file.OpenReadStream());
        // file.OpenReadStream() → создаёт поток для чтения данных из загруженного файла
        // StreamReader → удобный класс для построчного чтения текста из потока.
        // using var → автоматически закроет поток после завершения работы (чисто и безопасно).

        var header = await reader.ReadLineAsync();
        // Первая строка CSV обычно содержит названия колонок (ClientId,Name,PassportNumber)
        // Мы её читаем, но не используем, чтобы не записывать как данные.
        
        while (!reader.EndOfStream) //→ читаем файл построчно до конца.
        {
            var line = await reader.ReadLineAsync(); //→ асинхронно читает одну строку.
            if (string.IsNullOrWhiteSpace(line)) continue;  //→ пропускаем пустые строки.

            var values = line.Split(','); // CSV строка разделяется запятыми на отдельные поля.
            if (values.Length < 3) continue; //Проверяем, что строка содержит хотя бы 3 поля. Если меньше — строка некорректна → пропускаем.

            var clientId = Guid.Parse(values[0]); //превращаем строку из CSV в Guid.
            
            var exists = await _clientRepository.IdExistAsync(clientId); // проверяем, есть ли такой клиент уже в базе
            // Если есть → пропускаем, чтобы не нарушать первичный ключ. Если нет → создаём нового клиента.
            if (!exists)
            {
                // var client = new Client  ----ошибка
                // {
                //     ClientId = clientId,
                //     Name = values[1],
                //     PassportNumber = values[2]
                // };
                //await _clientRepository.CreateAsync(client);
            }

            await _clientRepository.SaveChangesAsync();
        }
    }
    
    //создание csv файла
    public async Task<string> GenerateClientsCsvAsync(IAsyncEnumerable<Client> clients, string path)
    {
        using var writer = new StreamWriter(path, false, Encoding.UTF8); 

        await writer.WriteLineAsync("ClientId,Name,PassportNumber"); // асинхронная запись строки в файл (не блокирует поток).

        await foreach (var client in clients)  //асинхронно перебираем поток клиентов (IAsyncEnumerable<Client>)
        { // Внутри цикла формируем строку CSV и пишем в файл асинхронно
            var name = client.Name.Contains(',') ? $"\"{client.Name}\"" : client.Name;
            await writer.WriteLineAsync($"{client.ClientId},{name},{client.PassportNumber}"); // записываем строку асинхронно, чтобы сервер не блокировался.
        }
        return path;
    }

}