
namespace Blog.Domain.AggregateModels.Post
{
    public interface IPostRepository : IRepository<Post>
    {
        Post Add(Post post);

        void Update(Post post);

        Task<Post> GetAsync(int postId);
    }
}
