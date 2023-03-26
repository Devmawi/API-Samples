using GraphQLFeatures.DataAccess;
using GraphQLFeatures.Models;
using HotChocolate.Resolvers;

namespace GraphQLFeatures.GraphQL
{
    public class BlogPostResolver
    {
        private readonly IBlogPostRepository
        _blogPostRepository;
        public BlogPostResolver([Service]
        IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }
        public IEnumerable<BlogPost> GetBlogPosts(
        Author author, IResolverContext ctx)
        {
            return _blogPostRepository.GetBlogPosts()
            .Where(b => b.AuthorId == author.Id);
        }
    }
}
