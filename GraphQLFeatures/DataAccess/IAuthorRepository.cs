using GraphQLFeatures.Models;

namespace GraphQLFeatures.DataAccess
{
    public interface IAuthorRepository
    {
        public List<Author> GetAuthors();
        public Author GetAuthorById(int id);
        public Task<Author> CreateAuthor(Author author);
    }
}
