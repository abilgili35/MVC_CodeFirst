using MVC_CodeFirst.Models.Context;
using MVC_CodeFirst.Models.Entities;
using MVC_CodeFirst.Repositories.Abstracts;

namespace MVC_CodeFirst.Repositories.Concretes
{
    public class MovieRepository : IMovieRepository
    {
        private MovieProjectContext _context = new MovieProjectContext();

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(int id)
        {
            var deleted = GetMovieById(id);
            if (deleted != null)
            {
                _context.Movies.Remove(deleted);
                _context.SaveChanges();
            }
        }

        public List<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            var movie = _context.Movies.Find(id);
            return movie;
        }

        public void UpdateMovie(Movie movie)
        {
            var updated = GetMovieById(movie.ID);
            if (updated != null)
            {
                updated.Title = movie.Title;
                updated.Description = movie.Description;
                _context.SaveChanges();
            }
        }
    }
}
