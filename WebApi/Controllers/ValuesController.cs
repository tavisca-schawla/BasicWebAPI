using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("go/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        [HttpGet("{salutation}")]
        public ActionResult<string> Get(string salutation)
        {
            return salutation == "hi" ? "hello" : salutation == "hello" ? "hi" : "Invalid";
        }

    }

    [Route("api/[controller]")]
    [ApiController]
    public class HiHelloController : ControllerBase
    {       
        
        [HttpGet("{salutation}")]
        public ActionResult<string> Get(string salutation)
        {
            return salutation == "hi" ? "hello" : salutation == "hello" ? "hi" : "Invalid";
        }

        
    }
}
