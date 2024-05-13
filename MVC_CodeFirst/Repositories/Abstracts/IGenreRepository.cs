using MVC_CodeFirst.Models.Entities;

namespace MVC_CodeFirst.Repositories.Abstracts
{
    public interface IGenreRepository
    {
        List<Genre> GetAllGenres();
        Genre GetGenreById(int id);
        void AddGenre(Genre genre);
        void UpdateGenre(Genre genre);

        void DeleteGenre(int id);
    }
}
