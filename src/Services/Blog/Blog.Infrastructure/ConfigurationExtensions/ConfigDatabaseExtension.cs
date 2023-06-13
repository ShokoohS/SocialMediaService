namespace Blog.Infrastructure.ConfigurationExtensions;

public static class ConfigDatabaseExtension
{
    public static IServiceCollection AddBlogDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BlogDbContext>(options =>
            {
                options.UseNpgsql(configuration["ConnectionString"],
                    npgsqlOptionsAction: builder =>
                    {
                        builder.MigrationsAssembly(typeof(ConfigDatabaseExtension).Assembly.GetName().Name);
                        builder.EnableRetryOnFailure(maxRetryCount: 15, maxRetryDelay: TimeSpan.FromSeconds(30), errorCodesToAdd: null);
                        
                    });
                options.EnableDetailedErrors(true);
            });

        return services;
    }
}