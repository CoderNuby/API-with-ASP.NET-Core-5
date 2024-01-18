using API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace API
{
    public class MovieDataStore
    {
        public static MovieDataStore Current { get; } = new MovieDataStore();
        public List<MovieDto > Movies { get; set; }
        public MovieDataStore()
        {
            Movies = new List<MovieDto>();
            using (StreamReader r = new StreamReader("MovieData.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array.movies)
                {
                    var movie = new MovieDto()
                    {
                        Id = item.id,
                        Title = item.title,
                        Year = item.year,
                        Runtime = item.runtime,
                        Genres = item.genres.ToObject<List<string>>(),
                        Director = item.director,
                        Plot = item.plot,
                        PosterUrl = item.posterUrl
                    };

                    string actors = item.actors;

                    movie.Casts = new List<CastDto>();
                    foreach (var actor in actors.Split(","))
                    {
                        var cast = new CastDto()
                        {
                            Id = Guid.NewGuid(),
                            Name = actor
                        };

                        movie.Casts.Add(cast);
                    }

                    Movies.Add(movie);
                }
            }
            
        }
    }
}
