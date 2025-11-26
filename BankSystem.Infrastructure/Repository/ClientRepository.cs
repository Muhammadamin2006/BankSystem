using BankSystem.Application.IRepository;
using BankSystem.Domain.Entities;
using BankSystem.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.Infrastructure.Repository;

public class ClientRepository : IClientRepository
{
    private readonly BankSystemDbContext _bankSystemDbContext;

    public ClientRepository(BankSystemDbContext bankSystemDbContext)
    {
        _bankSystemDbContext = bankSystemDbContext;
    }


    public async Task CreateAsync(Client? client)
    {
        await _bankSystemDbContext.AddAsync(client).ConfigureAwait(false);
        await _bankSystemDbContext.SaveChangesAsync();
    }

    public async Task DeleteClientAsync()
    {
        _bankSystemDbContext.Clients.RemoveRange();
        await _bankSystemDbContext.SaveChangesAsync();
    }

    public async Task DeleteClientByIdAsync(Guid id)
    {
        var client = await GetByIdAsync(id);
        if (client != null)
            _bankSystemDbContext.Remove(client);
        await _bankSystemDbContext.SaveChangesAsync();
    }

    // public Task DeleteClientByEmailAsync(string email)
    // { 
    //     var emailexist =  await Ge
    // }

    
    public Task UpdateAsync(Client? client)
    {
        _bankSystemDbContext.Clients.Update(client);
        return _bankSystemDbContext.SaveChangesAsync();
    }

    public async Task<Client?> GetByIdAsync(Guid id)
    {
        return await _bankSystemDbContext.Clients.FirstOrDefaultAsync(g => g.ClientId == id);
    }

    public async Task<IEnumerable<Client>> GetAllAsync()
    {
        return await _bankSystemDbContext.Clients.ToListAsync();
    }


    public async Task<Client?> GetByPassportNumberAsync(string passportNumber)
    {
        return await _bankSystemDbContext.Clients.FirstOrDefaultAsync(g => g.PassportNumber == passportNumber);
    }

    public IAsyncEnumerable<Client> GetAllForCsvAsync()
    {
        return _bankSystemDbContext.Clients.AsAsyncEnumerable();
        //  AsAsyncEnumerable() → позволяет перебирать данные из базы по мере их считывания, а не загружать весь список сразу в память.
        //  Это особенно важно, если клиентов миллионы.
    }


    public async Task SaveChangesAsync()
    {
        await _bankSystemDbContext.SaveChangesAsync();
    }

    // public async Task<Client?> GetClientByEmailAsync(string email)
    // {
    //     return await _bankSystemDbContext.Clients.FirstOrDefaultAsync(c => c.Email == email);
    // }
    //
    // public async Task<Client?> GetClientByPhoneNumberAsync(string phoneNumber)
    // {
    //     return await _bankSystemDbContext.Clients.FirstOrDefaultAsync(c => c.PhoneNumber == phoneNumber);
    // }

    public async Task<bool> IdExistAsync(Guid clientId)
    {
        return await _bankSystemDbContext.Clients.AnyAsync(c => c.ClientId == clientId);
    }

    // public async Task<bool> EmailExistAsync(string email)
    // {
    //     return await _bankSystemDbContext.Clients.AnyAsync(c => c != null && c.Email == email);
    // }

    public async Task<bool> PassportNumberExistAsync(string passportNumber)
    {
        return await _bankSystemDbContext.Clients.AnyAsync(c => c.PassportNumber == passportNumber);
    }


    // public async Task<bool> PhoneNumberExistAsync(string phoneNumber)
    // {
    //     return await _bankSystemDbContext.Clients.AnyAsync(c => c != null && c.PhoneNumber == phoneNumber);
    // }

    // public async Task DeleteClientByEmailAsync(string email)
    // {
    //     _clients.Remove(_clients.FirstOrDefault(c => c != null && c.Email == email));
    //     await _bankSystemDbContext.SaveChangesAsync();
    // }
    //
    // public async Task DeleteClientByPhoneNumberAsync(string phoneNumber)
    // {
    //     _clients.Remove(_clients.FirstOrDefault(c => c != null && c.PhoneNumber == phoneNumber));
    //     await _bankSystemDbContext.SaveChangesAsync();
    // }
    //
    // public async Task DeleteAllClientsAsync(Client client)
    // {
    //     _clients.RemoveRange();
    //     await _bankSystemDbContext.SaveChangesAsync();
    // }
}