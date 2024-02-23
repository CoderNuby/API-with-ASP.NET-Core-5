using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Runtime { get; set; }
        public string Director { get; set; }
        public string Plot { get; set; }
        public string PosterUrl { get; set; }
        public ICollection<Cast> Casts { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}
