using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Maps;

public class CommentMap: IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable(nameof(Comment));
        builder.HasKey(x => x.Id);
        builder.Property(x=>x.Id).ValueGeneratedOnAdd();
        
        builder.Property(x => x.Author).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Content).IsRequired().HasMaxLength(1000);

        builder.HasOne(x => x.Post).WithMany(x => x.Comments)
            .HasForeignKey(x => x.PostId)
            .OnDelete(DeleteBehavior.ClientNoAction);

    }
}