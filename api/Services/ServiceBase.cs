using Engrana.Domain;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Service;

/// <summary>
/// Generic service that performs basic CRUD operations
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="context"></param>
public abstract class ServiceBase<T>(EngranaContext context)
    where T : EntityBase
{
    protected readonly EngranaContext _context = context;
    private readonly DbSet<T> _dbSet = context.Set<T>();

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task UpdateAsync(T entity)
    {
        _dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
