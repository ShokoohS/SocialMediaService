
namespace Blog.Infrastructure.EntityConfigurations;

public class PostsEntityConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable("Post", schema: BlogDbContext.DEFAULT_SCHEMA);
        builder.Ignore(b => b.DomainEvents);
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Name).IsRequired();

    }

}