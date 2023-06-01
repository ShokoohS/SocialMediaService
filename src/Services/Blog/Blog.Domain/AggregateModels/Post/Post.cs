
namespace Blog.Domain.AggregateModels.Post
{
    public class Post : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Content { get; private set; }
        public string ImageURL { get; private set; }

        public Post(string name, string content, string imageUrl)
        {
            Name = name;
            Content = content;
            ImageURL = imageUrl;
        }
    }
}
