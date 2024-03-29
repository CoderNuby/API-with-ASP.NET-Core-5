﻿using System;
using System.Collections.Generic;

namespace API.Models
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Runtime { get; set; }
        public IEnumerable<GenreDto> Genres { get; set; }
        public string Director { get; set; }
        public IEnumerable<CastDto> Casts { get; set; }
        public string Plot { get; set; }
        public string PosterUrl { get; set; }
    }
}
