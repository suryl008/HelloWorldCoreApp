using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldCoreApp.Controllers
{
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        
        // GET api/values
        [HttpGet]
        [Route("api/Crowe/HelloWorld")]
        public string Get()
        {            
            string result = string.Empty;
            result = "Hello World";
            return result;
        }        
    }
}
