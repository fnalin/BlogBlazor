using System.ComponentModel.DataAnnotations;

namespace Blog.Domain.Entities;


public class Category : EntityBase
{
   
    public string Name { get; set; } = null!;
    
    public IEnumerable<Post> Posts { get; set; } = new List<Post>();
}