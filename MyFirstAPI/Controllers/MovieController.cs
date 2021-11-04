using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace MyFirstAPI.Controllers
{
    [ApiController] // not associated with views
    [Route("Movie")]
    public class MovieController : Controller
    {

        //[HttpGet]
        //public string Get()
        //{
        //    var movie = new Movie() { Title = "Shrek", Genre = "Animated", Year = 2001 }; //instance of movie
        //    string json = JsonConvert.SerializeObject(movie);

        //    return json;
        //}

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    var movie = new Movie() { Title = "Shrek", Genre = "Animated", Year = 2001 }; //instance of movie
        //    //string json = JsonConvert.SerializeObject(movie);

        //    return new OkObjectResult(movie);
        //}


        [HttpPost]
 
        public IActionResult Index(Movie movie)
        {
            if (movie == null)
            {
                return BadRequest();
            }else
            {
                return new OkObjectResult(movie);
            }
        }
            [HttpGet]
        public IActionResult Index()
        {
            var movie = new Movie() { Title = "Shrek", Genre = "Animated", Year = 2001 }; //instance of movie
            string json = JsonConvert.SerializeObject(movie);

            var result = new OkObjectResult(movie);
            result.StatusCode = 401; // forced this to be an error status code. Use this for if/then or switch states that faild validation in a speific way

            return new OkObjectResult(movie);
        }



            //[HttpGet]
            //public Movie Index()
            //{
            //    var movie = new Movie() { Title = "Shrek", Genre = "Animated", Year = 2001 }; //instance of movie
            //    return movie;
            //}

        }
}
