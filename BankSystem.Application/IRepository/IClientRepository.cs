using BankSystem.Application.Dtos;
using BankSystem.Domain.Entities;

namespace BankSystem.Application.IRepository;

public interface IClientRepository : IGenericRepository<Client>
{
    //Task<Client?> GetClientByEmailAsync(string email);
    //Task<Client?> GetClientByPhoneNumberAsync(string phoneNumber);
    
    Task<bool> IdExistAsync(Guid clientId);
    //Task<bool> EmailExistAsync(string email);
    Task<bool> PassportNumberExistAsync(string passportNumber);
    Task<Client?> GetByPassportNumberAsync(string passportNumber);
    //Task<bool> PhoneNumberExistAsync(string   phoneNumber);

    IAsyncEnumerable<Client> GetAllForCsvAsync();
    Task DeleteClientByIdAsync(Guid id);
    //Task DeleteClientByEmailAsync(string email);

    // Task DeleteClientByEmailAsync(string email);
    // Task DeleteClientByPhoneNumberAsync(string phoneNumber);
    // Task DeleteAllClientsAsync(Client client);
}


