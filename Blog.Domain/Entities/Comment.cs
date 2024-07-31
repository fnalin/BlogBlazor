namespace Blog.Domain.Entities;

public class Comment : EntityBase
{
    public string Author { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    public int PostId { get; set; }
    public Post Post { get; set; }  = null!;
}