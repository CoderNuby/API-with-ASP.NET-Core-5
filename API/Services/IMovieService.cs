using API.Models;
using System.Collections.Generic;

namespace API.Services
{
    public interface IMovieService
    {
        List<MovieDto> GetAllMovies();
        MovieDto GetMovieById(int id);
    }
}
