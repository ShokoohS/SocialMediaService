namespace Blog.Infrastructure.ConfigurationExtensions;

public static class TodayRecruitContextSeedExtension
{
    public static async Task TodayRecruitMigrateAndSeed(this IHost app)
    {

        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider
            .GetRequiredService<BlogDbContext>();

        await context.Database.MigrateAsync();
        await context.SaveChangesAsync();
        SeedDefaultPost(context);
        await context.SaveChangesAsync();
    }



    private static async void SeedDefaultPost(BlogDbContext blogDbContext)
    {
        if (!blogDbContext.Posts.Any())
        {
            await blogDbContext.Posts.AddRangeAsync(new List<Post>
            {
                new("Welcome", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "https://zanoo.ir/wp-content/uploads/2022/07/drmoayedfar.jpg")
            });

        }
    }



}