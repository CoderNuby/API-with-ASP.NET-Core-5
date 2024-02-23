using API.Models;
using API.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Services.Implementations
{
    public class MovieService : IMovieService
    {
        private readonly IMovieReporitory _movieReporitory;
        private readonly IMapper _mapper;

        public MovieService(IMovieReporitory movieReporitory, IMapper mapper)
        {
            _movieReporitory = movieReporitory ?? throw new ArgumentNullException(nameof(movieReporitory));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public List<MovieDto> GetAllMovies()
        {
            var moviesDB = _movieReporitory.GetAll(d => d.Casts, d => d.Genres);

            var movies = _mapper.Map<IEnumerable<MovieDto>>(moviesDB);

            return movies.ToList();
        }

        public MovieDto GetMovieById(int id)
        {
            var movieDB = _movieReporitory.Get(d => d.Id == id, d => d.Casts, d => d.Genres).FirstOrDefault();

            if(movieDB == null)
                return null;

            var movie = _mapper.Map<MovieDto>(movieDB);

            return movie;
        }
    }
}
