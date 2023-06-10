namespace Blog.Infrastructure.Repositories;

public class PostRepository : IPostRepository
{
    private BlogDbContext _dbContext;

    public PostRepository(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IUnitOfWork UnitOfWork => _dbContext;
    public Post Add(Post post)
    {
        return _dbContext.Posts.Add(post).Entity;
    }

    public void Update(Post post)
    {
        throw new NotImplementedException();
    }

    public Task<Post> GetAsync(int postId)
    {
        throw new NotImplementedException();
    }
}