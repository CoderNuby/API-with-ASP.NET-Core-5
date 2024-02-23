
using API.Models;
using API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger _logger;
        private readonly ILocalMailService _localMailService;
        private readonly ICastService _castService;

        public CastController(ILogger<CastController> logger, ILocalMailService localMailService, ICastService castService) 
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _localMailService = localMailService ?? throw new ArgumentNullException(nameof(localMailService));
            _castService = castService ?? throw new ArgumentNullException(nameof(castService));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var casts = _castService.GetAllCasts();

            return Ok(casts);
        }

        [HttpGet("{movieId}")]
        public IActionResult GetAll(int movieId)
        {
            var casts = _castService.GetCastsFromMovie(movieId);

            if (casts == null)
                return NotFound("Movie with the current id not found");
            return Ok(casts);
        }

        [HttpGet("{movieId}/{castId}")]
        public IActionResult Get(int movieId, Guid castId)
        {
            try
            {
                var cast = _castService.GetCast(movieId, castId);

                if (cast == null)
                    return NotFound("cast not found");

                return Ok(cast);
            }
            catch (Exception)
            {
                _logger.LogCritical($"An error has occurred when cast was searched, id {castId}");
                return StatusCode(500, "An internal error server was occured");
            }
        }

        [HttpGet("AllMovies/{castId}")]
        public IActionResult GetAll(Guid castId)
        {
            var cast = _castService.GetCast(castId);

            if (cast == null)
                return NotFound("cast not found");
            return Ok(cast);
        }

        [HttpPost("{movieId}")]
        public IActionResult Add(int movieId, [FromBody] CastForCreationDto cast)
        {
            if (cast == null || cast.Name == null)
                return BadRequest("Name is required");

            var castCreted = _castService.CreateCast(movieId, cast);
            if (castCreted == null)
                return BadRequest("Movie not found");

            return Created("Cast created successfully", castCreted);
        }

        [HttpPut("{movieId}/{id}")]
        public IActionResult Update(int movieId, Guid id, [FromBody] CastForUpdateDto cast)
        {
            if (cast == null || cast.Name == null)
                return BadRequest("Name is required");

            var castUpdated = _castService.UpdateCast(movieId, id, cast);
            if (castUpdated == null)
                return NotFound("Movie or cast can't be found");

            return Ok("Cast updated successfully");
        }

        [HttpPatch("{movieId}/{id}")]
        public IActionResult Update(int movieId, Guid id, [FromBody] JsonPatchDocument<CastForUpdateDto> patchDocument)
        {
            var cast = _castService.UpdateCast(movieId, id, patchDocument);
            if (cast == null)
                return NotFound("Cast or Movie not found");

            return Ok("Cast updated successfully");
        }

        [HttpDelete("{movieId}/{id}")]
        public IActionResult Delete(int movieId, Guid id) 
        {
            var cast = _castService.DeleteCast(movieId, id);
            _localMailService.Send($"Cast eliminated", $"The cast with id {id} was eleminated.");

            return Ok("Cast deleted successfully");
        }
    }
}
