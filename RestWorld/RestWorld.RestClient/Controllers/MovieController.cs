using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWorld.RestClient.Controllers
{
    [Route("fred/[controller]")]
    [Produces("application/json")]
    [ApiController]//Names do matter web api
    public class MovieController:Controller
    {
        private readonly List<string> movies = new List<string>()
        {
            "Titanic",
            "Star Wars",
            "Angry Birds"
        };

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await Task.Run(() =>
            {
                return Ok(movies);
            });
            
            //200-series
            // return NoContent();//200-series
            // return NotFound();//400-series
            // return Redirect();//300-series
            // return BadRequest();//500-series
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok("time to post");
        }

    }
    

}