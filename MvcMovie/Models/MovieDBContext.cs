using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}


