using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Attributes;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.OData;
using ODataWebApi.Models;

namespace ODataWebApi.Controllers
{
    public class CustomersController : ODataController
    {
        private static Random random = new Random();
        private static List<Customer> customers = new List<Customer>(
            Enumerable.Range(1, 3).Select(idx => new Customer
            {
                Id = idx,
                Name = $"Customer {idx}",
                Credit = random.Next(1,100),
            }));

        public CustomersController()
        {
        }

        [HttpGet]
        public string SayHello(string message)
        {
            return $"Hello {message}";
        }

        [HttpGet]
        public string SayHello2([FromRoute]int key, string message)
        {
            return $"Hello {message}, {key}";
        }

        [HttpPost]
        public string SomeAction(ODataActionParameters p)
        {
            return $"Hello {p["name"]}";
        }

        [HttpPost]
        public string SomeAction2(ODataActionParameters p)
        {
            return $"Hello {(p["order"] as Order).Amount}";
        }
    }
}
