namespace GraphQLService.Models
{
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public Author Author { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
    }

}
