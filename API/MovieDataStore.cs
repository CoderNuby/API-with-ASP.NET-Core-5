using API.Entities;
using API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace API
{
    public class MovieDataStore
    {
        public static MovieDataStore Current { get; } = new MovieDataStore();
        public List<Movie> Movies { get; set; }
        public List<Cast> Casts { get; set; }
        public List<Genre> Genres { get; set; }
        public MovieDataStore()
        {
            Movies = new List<Movie>();
            Casts = new List<Cast>();
            Genres = new List<Genre>();
            using (StreamReader r = new StreamReader("MovieData.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array.movies)
                {
                    var movieDto = new MovieDto()
                    {
                        Id = item.id,
                        Title = item.title,
                        Year = item.year,
                        Runtime = item.runtime,
                        Director = item.director,
                        Plot = item.plot,
                        PosterUrl = item.posterUrl
                    };
                    
                    var movie = new Movie()
                    {
                        Id = movieDto.Id,
                        Title = movieDto.Title,
                        Year = movieDto.Year,
                        Runtime = movieDto.Runtime,
                        Director = movieDto.Director,
                        Plot = movieDto.Plot,
                        PosterUrl = movieDto.PosterUrl,
                    };

                    var genres = item.genres.ToObject<List<string>>();

                    foreach (var genre in genres)
                    {
                        Genres.Add(new Genre()
                        {
                            Id = Guid.NewGuid(),
                            MovieId = movieDto.Id,
                            Name = genre
                        });
                    }

                    string actors = item.actors;
                    foreach (var actor in actors.Split(","))
                    {
                        var castDto = new CastDto()
                        {
                            Id = Guid.NewGuid(),
                            Name = actor
                        };

                        var cast = new Cast()
                        {
                            Id = castDto.Id,
                            MovieId = movie.Id,
                            Name = castDto.Name
                        };

                        Casts.Add(cast);
                    }
                    Movies.Add(movie);
                }
            }
        }
    }
}
