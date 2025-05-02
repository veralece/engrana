using Engrana.Configuration;
using Engrana.Domain.Configuration;
using Engrana.Infrastructure;

namespace Engrana.Services;

//todo update to use DT Records instead
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

    Task CheckEntityWorkflows(Guid guid, ActionType actionType);
    Task CheckEntityWorkflows(T entity, ActionType actionType);
}
