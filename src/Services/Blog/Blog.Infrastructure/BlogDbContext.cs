namespace Blog.Infrastructure;

public class BlogDbContext : DbContext, IUnitOfWork
{
    private readonly IMediator _mediator;
    public const string DEFAULT_SCHEMA = "blog";
    public BlogDbContext(DbContextOptions<BlogDbContext> options, IMediator mediator) : base(options)
    {
        _mediator = mediator;
    }
    public DbSet<Post> Posts { get; set; }
    public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        await _mediator.DispatchDomainEventsAsync(this);
        await SaveChangesAsync(cancellationToken);
        return true;
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new PostsEntityConfiguration());

    }

}