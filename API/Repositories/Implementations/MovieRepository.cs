using API.Context;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace API.Repositories.Implementations
{
    public class MovieRepository : Repository<Movie>, IMovieReporitory
    {
        public MovieRepository(MovieInfoContext context) : base(context)
        {
        }
    }
}
