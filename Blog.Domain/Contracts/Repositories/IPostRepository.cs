using Blog.Domain.Entities;

namespace Blog.Domain.Contracts.Repositories;

public interface IPostRepository : IRepository<Post>
{
    Task<IEnumerable<Post>> GetByTitleContainsAsync(string title);
}