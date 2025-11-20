using BankSystem.Application.IRepository;
using BankSystem.Domain.Entities;
using BankSystem.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.Infrastructure.Repository;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly BankSystemDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(BankSystemDbContext context)
    {
        _dbSet = context.Set<TEntity>();
        _context = context;
    }


    public async Task CreateAsync(TEntity? entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public async Task DeleteClientAsync()
    {
        _dbSet.RemoveRange();
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity? entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<TEntity?> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    
}