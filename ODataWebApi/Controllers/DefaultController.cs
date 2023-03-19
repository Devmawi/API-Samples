using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Attributes;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.OData;

namespace ODataWebApi.Controllers
{
    public class DefaultController : ODataController
    {
        public DefaultController()
        {
        }

       
        [HttpGet("odata/ExecuteSomeFunction2")]
        public string ExecuteSomeFunction2()
        {
            return "TEST";
        }

        [HttpPost("odata/ExecuteSomeAction2")]
        public string ExecuteSomeAction2()
        {
            return "TEST";
        }
    }
}
