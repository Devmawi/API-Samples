using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataWebApi.Models;
using System.Numerics;

namespace ODataWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ODataController
    {
        private static Random random = new Random();
        private static List<Article> articles = new List<Article>(
            Enumerable.Range(1, 3).Select(idx => new Article
            {
                Id = idx,
                ItemNumber = $"Article {idx}",
                Orders = new List<Order>(
                    Enumerable.Range(1, 2).Select(dx => new Order
                    {
                        Id = (idx - 1) * 2 + dx,
                        Amount = random.Next(1, 9) * 10
                    }))
            }));


        private readonly ILogger<ArticlesController> _logger;

        public ArticlesController(ILogger<ArticlesController> logger)
        {
            _logger = logger;
        }

        [EnableQuery]
        public ActionResult Get()
        {
            return Ok(articles);
        }

        [EnableQuery]
        public ActionResult Get([FromRoute] int key)
        {
            return Ok(articles.Find(a => a.Id == key));
        }

        [HttpPost("/odata/Articles({key})/Default.Rate")] // !!! With namespace
        
        public IActionResult Rate([FromODataUri] string key)
        {
            var article = articles.Find(a => a.Id == int.Parse(key));
            if (article != null)
                article.Rating++;
            return Ok(article?.Rating ?? 0);
        }

        [HttpGet("/odata/ExecuteSomeFunction()")]
        public IActionResult ExecuteSomeFunction()
        {
            
            return Ok("Hello");
        }

    }
}