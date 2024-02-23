using API.Repositories;
using API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService) 
        {
            _movieService = movieService ?? throw new ArgumentNullException(nameof(movieService));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var movies = _movieService.GetAllMovies();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var movie = _movieService.GetMovieById(id);
            if (movie == null)
                return NotFound("The movie with the current id doesn't exist");
            return Ok(movie);
        }
    }
}
