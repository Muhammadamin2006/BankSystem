using BankSystem.Application.Extension;
using BankSystem.Application.IRepository;
using BankSystem.Application.IService;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientCsvService _csvService;
        private readonly IClientRepository _clientRepository;

        public ClientsController(IClientCsvService csvService, IClientRepository clientRepository)
        {
            _csvService = csvService;
            _clientRepository = clientRepository;
        }

        [HttpPost("upload-csv")]
        public async Task<IActionResult> UploadCsv(IFormFile file)
        {
            try
            {
                await _csvService.ProcessCsvFromFormFileAsync(file);
                return Ok(new { message = "CSV успешно обработан" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        
        [HttpPost("generate-csv")]
        public async Task<IActionResult> GenerateCsv()
        {
            var clientsStream = _clientRepository.GetAllForCsvAsync(); // возвращает поток клиентов — это важно, чтобы не загружать все записи в память сразу
            var path = Path.Combine(Directory.GetCurrentDirectory(), "clients_export.csv"); //текущая папка проекта/сервера автоматически берет путь 

            await _csvService.GenerateClientsCsvAsync(clientsStream, path); //передаём поток клиентов и путь к файлу
            return Ok(new { Message = "CSV сгенерирован", FilePath = path });
        }

        
        
    }
}