using BankSystem.Application.Dtos;
using BankSystem.Domain.Entities;

namespace BankSystem.Application.IService;

public interface IClientService
{
    Task<ClientDto> RegisterClientAsync(CreateClientDto createClientDto);
    
    Task<ClientDto> GetClientByIdAsync(Guid id);
    Task<IEnumerable<ClientDto>> GetAllClientsAsync();
    // Task<ClientDto> GetClientByEmailAsync(string email);
    // Task<ClientDto> GetClientsByPhoneNumberAsync(string phoneNumber);

    Task<ClientDto> UpdateClientAsync(Guid clientId, string newName);
    
    //Task DeleteClientByIdAsync(Guid id);
    //Task DeleteClientByEmailAsync(string email);
}