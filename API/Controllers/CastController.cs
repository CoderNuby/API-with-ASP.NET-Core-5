
using API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.Common;
using System.Linq;
using System.Xml.XPath;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class CastController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var casts = MovieDataStore.Current.Movies.SelectMany(x => x.Casts).ToList();

            return Ok(casts);
        }

        [HttpGet("{movieId}")]
        public IActionResult GetAll(int movieId)
        {
            var casts = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId).Casts;

            if (casts == null)
                return NotFound("Movie with the current id not found");
            return Ok(casts);
        }

        [HttpGet("{movieId}/{castId}")]
        public IActionResult GetAll(int movieId, Guid castId)
        {
            var cast = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId).Casts.FirstOrDefault(x => x.Id == castId);

            if (cast == null)
                return NotFound("cast not found");
            return Ok(cast);
        }

        [HttpGet("AllMovies/{castId}")]
        public IActionResult GetAll(Guid castId)
        {
            var cast = MovieDataStore.Current.Movies.SelectMany(x => x.Casts).ToList().FirstOrDefault(x => x.Id == castId);

            if (cast == null)
                return NotFound("cast not found");
            return Ok(cast);
        }

        [HttpPost("{movieId}")]
        public IActionResult Add(int movieId, [FromBody] CastForCreationDto cast)
        {
            var movie = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);
            if (movie == null)
                return NotFound("Movie not found");
            if (cast == null || cast.Name == null)
                return BadRequest("Name is required");
            cast.Id = Guid.NewGuid();
            movie.Casts.Add(new CastDto()
            {
                Id = cast.Id,
                Name = cast.Name
            });
            return Created("Cast created successfully", cast);
        }

        [HttpPut("{movieId}/{id}")]
        public IActionResult Update(int movieId, Guid id, [FromBody] CastForUpdateDto cast)
        {
            var movie = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);
            if (movie == null)
                return NotFound("Movie not found");
            if (cast == null || cast.Name == null)
                return BadRequest("Name is required");
            var castFromStore = movie.Casts.FirstOrDefault(x => x.Id == id);
            if (castFromStore == null)
                return NotFound("Cast not found");
            castFromStore.Name = cast.Name;
            return Ok("Cast created successfully");
        }

        [HttpPatch("{movieId}/{id}")]
        public IActionResult Update(int movieId, Guid id, [FromBody] JsonPatchDocument<CastForUpdateDto> patchDocument)
        {
            var movie = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);
            if (movie == null)
                return NotFound("Movie not found");
            var castFromStore = movie.Casts.FirstOrDefault(x => x.Id == id);
            if (castFromStore == null)
                return NotFound("Cast not found");
            var castToPatch = new CastForUpdateDto() 
            {
                Name = castFromStore.Name
            };
            patchDocument.ApplyTo(castToPatch, ModelState);

            if (!TryValidateModel(castToPatch))
                return BadRequest("Name required");
            castFromStore.Name = castToPatch.Name;
            return Ok("Cast updated successfully");
        }

        [HttpDelete("{movieId}/{id}")]
        public IActionResult Delete(int movieId, Guid id) 
        {
            var movie = MovieDataStore.Current.Movies.FirstOrDefault(x => x.Id == movieId);
            if (movie == null)
                return NotFound("Movie not found");
            var castFromStore = movie.Casts.FirstOrDefault(x => x.Id == id);
            if (castFromStore == null)
                return NotFound("Cast not found");
            movie.Casts.Remove(castFromStore);

            return Ok("Cast deleted successfully");
        }
    }
}
