using Blog.Domain.Entities;

namespace Blog.Domain.Contracts.Repositories;

public interface IRepository<T> where T : EntityBase
{
    //CRUD
    Task<IEnumerable<T>> GetAsync();
    Task<T> GetAsync(int id);
    
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task Delete(T entity);
    
}