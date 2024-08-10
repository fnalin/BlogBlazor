using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Repositories;

public class Repository<T> (BlogDbContext ctx) : IRepository<T> where T : EntityBase
{
    public async Task<IEnumerable<T>> GetAsync()
    {
        return await ctx.Set<T>().ToListAsync();
    }

    public async Task<T> GetAsync(int id)
    {
        var data = await ctx.Set<T>().FindAsync(id);
        
        if (data is null)
        {
            throw new Exception($"{typeof(T).Name} with id {id} not found");
        }
        
        return data!;
    }

    public async Task AddAsync(T entity)
    {
        await ctx.Set<T>().AddAsync(entity);
        await ctx.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        ctx.Set<T>().Update(entity);
        await ctx.SaveChangesAsync();
    }

    public async Task Delete(T entity)
    {
        ctx.Set<T>().Remove(entity);
        await ctx.SaveChangesAsync();
    }
}