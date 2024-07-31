namespace Blog.Domain.Entities;

public class Post : EntityBase
{
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdateAt { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public IEnumerable<Comment> Comments { get; set; } = new List<Comment>();
    
    public IEnumerable<PostTag> Tags { get; set; } = new List<PostTag>();
}