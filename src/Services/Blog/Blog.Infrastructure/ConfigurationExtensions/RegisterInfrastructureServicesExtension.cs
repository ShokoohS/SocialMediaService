namespace Blog.Infrastructure.ConfigurationExtensions;
public static class RegisterInfrastructureServicesExtension
{
    public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IPostRepository, PostRepository>();
        return services;
    }
}