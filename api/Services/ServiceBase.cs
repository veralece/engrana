using Engrana.Domain;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Service;

//todo consider other generic operations
/// <summary>
/// Generic service that performs basic CRUD operations
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="context"></param>
public abstract class ServiceBase<T>(EngranaContext context)
    where T : EntityBase
{
    protected readonly EngranaContext _context = context;
    protected readonly DbSet<T> _dbSet = context.Set<T>();

    public async Task<T?> AddAsync(T entity)
    {
        var entry = await _dbSet.AddAsync(entity);
        int result = await _context.SaveChangesAsync();
        if (result > 0)
            return entry.Entity;
        return default;
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync();
        }
        return 0;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<int> UpdateAsync(T entity)
    {
        _dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        return await _context.SaveChangesAsync();
    }

    //todo develop the trigger to queue a workflow with the entity
    //pull all triggers for the affected entity type and run the trigger conditions.
    // public async Task CheckTrigger(T Entity) { }
}
