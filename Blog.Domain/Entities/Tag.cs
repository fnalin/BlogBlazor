namespace Blog.Domain.Entities;

public class Tag : EntityBase
{
    public string Name { get; set; } = null!;
    public IEnumerable<PostTag> Posts { get; set; } = new List<PostTag>();
    
    
}