

namespace Blog.Infrastructure.Migrations;

public class BlogContextDesignTimeFactory : IDesignTimeDbContextFactory<BlogDbContext>
{
    public BlogDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BlogDbContext>();

        optionsBuilder.UseNpgsql(".", options => options.MigrationsAssembly(GetType().Assembly.GetName().Name));

        return new BlogDbContext(optionsBuilder.Options, null);
    }
}

