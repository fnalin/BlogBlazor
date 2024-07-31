using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Maps;

public class PostTagMap: IEntityTypeConfiguration<PostTag>
{
    public void Configure(EntityTypeBuilder<PostTag> builder)
    {
        builder.ToTable(nameof(PostTag));
        builder.HasKey(x => x.Id);
        builder.Property(x=>x.Id).ValueGeneratedOnAdd();
        
        builder.Property(x => x.CreateAt).HasColumnType("datetime2")
            .HasDefaultValueSql("GETDATE()");
        
        
    }
}