using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities;

namespace Blog.Data.Repositories;

public class CategoryRepository(BlogDbContext ctx) : Repository<Category>(ctx), ICategoryRepository;