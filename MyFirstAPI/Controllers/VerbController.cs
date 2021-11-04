using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAPI.Controllers
{
    [ApiController] // not associated with views
    [Route("Verb")]
    public class VerbController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}


//200 - 299 sucessful stats codes
//300 - 399 warning codes
//400 - 499 error on user part code 
//500 - 599 error on the server