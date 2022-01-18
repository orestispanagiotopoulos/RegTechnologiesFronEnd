using Microsoft.EntityFrameworkCore;
using RegTechnologies.Contexts;
using RegTechnologies.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RegTechnologies.Services
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _context;
        public MovieRepository(MovieContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.OrderBy(m => m.Rating).ToList();
        }

        public Movie GetMovie(int movieId)
        {
             return _context.Movies.Include(c => c.Comments)
                    .Where(m => m.Id == movieId).FirstOrDefault();
        }
    }
}
