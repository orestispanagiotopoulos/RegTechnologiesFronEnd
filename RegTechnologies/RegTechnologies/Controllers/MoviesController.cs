using Microsoft.AspNetCore.Mvc;
using RegTechnologies.Services;
using System.Linq;

namespace RegTechnologies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(MoviesDataStorage.Current.Movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {
            // find movie
            var movieToReturn = MoviesDataStorage.Current.Movies
                .FirstOrDefault(c => c.Id == id);

            if (movieToReturn == null)
            {
                return NotFound();
            }

            return Ok(movieToReturn);
        }
    }
}
