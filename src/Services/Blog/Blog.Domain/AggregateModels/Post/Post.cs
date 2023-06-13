
namespace Blog.Domain.AggregateModels.Post;

public class Post : Entity, IAggregateRoot
{
    public string Name { get; private set; }
    public string Content { get; private set; }
    public string ImageURL { get; private set; }
    public Post() { }
    public Post(string name, string content, string imageUrl) : base()
    {
        Id = Guid.NewGuid();
        Name = string.IsNullOrWhiteSpace(name) ? throw new BlogDomainException("Name can not be null") : name;
        Content = content;
        //var regex = @"(https?:\/\/.*\.(?:png|jpg))";
        //var match = Regex.Match(imageUrl, regex, RegexOptions.IgnoreCase);

        //if (!match.Success && !string.IsNullOrEmpty(imageUrl))
        //{
        //    throw new BlogDomainException("Name can not be null");
        //}
        ImageURL = imageUrl;

    }
}