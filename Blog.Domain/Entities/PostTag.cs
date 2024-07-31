namespace Blog.Domain.Entities;

public class PostTag : EntityBase
{
    public int PostId { get; set; }
    public Post Post { get; set; }
    public int TagId { get; set; }
    public Tag Tag { get; set; }

    public DateTime CreateAt { get; set; }
}