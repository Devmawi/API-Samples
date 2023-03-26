using GraphQLFeatures.Models;

namespace GraphQLFeatures.DataAccess
{
    public interface IBlogPostRepository
    {
        public List<BlogPost> GetBlogPosts();
        public BlogPost GetBlogPostById(int id);
    }
}
