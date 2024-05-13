using MVC_CodeFirst.Models.Entities;

namespace MVC_CodeFirst.Repositories.Abstracts
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        void AddMovie(Movie movie);
        void UpdateMovie(Movie movie);

        void DeleteMovie(int id);
    }
}
