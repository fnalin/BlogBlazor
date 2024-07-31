using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Maps;

public class PostMap: IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable(nameof(Post));
        builder.HasKey(x => x.Id);
        builder.Property(x=>x.Id).ValueGeneratedOnAdd();
        
        builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Content).IsRequired().HasMaxLength(1000);

        builder.Property(x => x.CreatedAt).HasColumnType("datetime2");
        builder.Property(x => x.UpdateAt).HasColumnType("datetime2");

        builder.HasOne(x => x.Category).WithMany(x => x.Posts)
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.ClientNoAction);
        
        builder.HasMany(x => x.Tags)
            .WithOne(x => x.Post)
            .HasForeignKey(x => x.PostId)
            .OnDelete(DeleteBehavior.ClientNoAction);
    }
}