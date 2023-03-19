namespace ODataWebApi.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string ItemNumber { get; set; }
        public int Rating { get; set; } = 0;
        public List<Order> Orders { get; set; }
    }
}
