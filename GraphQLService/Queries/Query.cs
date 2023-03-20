using GraphQLService.Models;

namespace GraphQLService.Queries
{
    public class Query
    {
        public Book GetBook() =>
            new Book
            {
                Title = "C# in depth.",
                Price = 10,
                Author = new Author
                {
                    Name = "Jon Skeet"
                }
            };
    }

}
