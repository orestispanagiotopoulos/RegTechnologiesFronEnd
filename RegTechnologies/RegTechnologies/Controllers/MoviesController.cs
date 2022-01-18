using Microsoft.AspNetCore.Mvc;
using RegTechnologies.Models;
using RegTechnologies.Services;
using System.Collections.Generic;
using System.Linq;

namespace RegTechnologies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;
        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            // return Ok(MoviesDataStorage.Current.Movies);

            var movieEntities = _movieRepository.GetMovies();

            var result = new List<MovieWithoutCommentsDto>();

            foreach (var movieEntity in movieEntities)
            {
                result.Add(new MovieWithoutCommentsDto
                {
                    Id = movieEntity.Id,
                    Title = movieEntity.Title
                });
            }

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {
            var movie = _movieRepository.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }

            var movieResult = new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Rating = movie.Rating,
                Duration = movie.Duration,
                Year = movie.Year,
                Popularity = movie.Popularity,
            };

            foreach(var comment in movie.Comments)
            {
                movieResult.Comments.Add(
                    new CommentDto
                    {
                        Id = comment.Id,
                        Author = comment.Author,
                        Date = comment.Date,
                        Text = comment.Text
                    });
            }

            return Ok(movieResult);
        }
    }
}
