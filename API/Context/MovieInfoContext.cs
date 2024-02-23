using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace API.Context
{
    public class MovieInfoContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public MovieInfoContext(DbContextOptions<MovieInfoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(MovieDataStore.Current.Movies);
            modelBuilder.Entity<Cast>().HasData(MovieDataStore.Current.Casts);
            modelBuilder.Entity<Genre>().HasData(MovieDataStore.Current.Genres);
            base.OnModelCreating(modelBuilder);
        }
    }
}
