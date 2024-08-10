using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Repositories;

public class PostRepository(BlogDbContext ctx) : Repository<Post>(ctx), IPostRepository
{
    private readonly BlogDbContext _ctx = ctx;

    public async Task<IEnumerable<Post>> GetByTitleContainsAsync(string title)
    {
        return await _ctx.Posts.Where(x=>x.Title.Contains(title)).ToListAsync();
    }
}