using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var movies = MovieDataStore.Current.Movies;
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var movie = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == id);
            if (movie == null)
                return NotFound("The movie with the current id doesn't exist");
            return Ok(movie);
        }
    }
}
