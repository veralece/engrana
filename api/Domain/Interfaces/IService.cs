using Engrana.Domain.Configuration;

namespace Engrana.Domain;

/// <summary>
/// Generic service that performs basic CRUD operations
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="context"></param>
public interface IService<T>
    where T : EntityBase
{
    Task<T?> AddAsync(T entity);

    Task<int> DeleteAsync(Guid id);

    Task<IEnumerable<T>> GetAllAsync();

    Task<T?> GetByIdAsync(Guid id);
    Task<int> UpdateAsync(T entity);

    Task CheckTrigger(T entity, TriggerType triggerType);
}
