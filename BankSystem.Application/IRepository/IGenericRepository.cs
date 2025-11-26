using BankSystem.Application.Dtos;
using BankSystem.Domain.Entities;

namespace BankSystem.Application.IRepository;

public interface IGenericRepository<TEntity>  where TEntity : class
{
    Task CreateAsync(TEntity? entity);
    Task DeleteClientAsync();
    Task UpdateAsync(TEntity? entity);
    Task<TEntity?> GetByIdAsync(Guid id);
    Task<IEnumerable<Client>> GetAllAsync();
    Task SaveChangesAsync();
}