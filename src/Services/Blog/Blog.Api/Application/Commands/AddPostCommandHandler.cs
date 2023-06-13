namespace Blog.Api.Application.Commands;

public class AddPostCommandHandler : IRequestHandler<AddPostCommand, Guid>
{
    private readonly IPostRepository _postRepository;

    public AddPostCommandHandler(IPostRepository iPostRepository)
    {
        _postRepository = iPostRepository ?? throw new ArgumentNullException(nameof(iPostRepository));
    }
    public async Task<Guid> Handle(AddPostCommand request, CancellationToken cancellationToken)
    {
        var post = new Post(request.Title, request.Content, request.ImageURL);
        _postRepository.Add(post);
        await _postRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        
        return post.Id; 
    }
}