using EFcoreProject1Core.Models;

namespace EFcoreProject1Core.Repositories;

public interface IGenericRepository<T> where T : IdName, new()
{
    Task Insert(T entity);
    Task<T?> GetAsync(int id);
    IQueryable<T> GetAll();
    void Delete(T entity);
    Task<int> CommitAsync();
}
