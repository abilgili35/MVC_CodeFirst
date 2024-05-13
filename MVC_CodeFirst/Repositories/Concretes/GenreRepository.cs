using MVC_CodeFirst.Models.Context;
using MVC_CodeFirst.Models.Entities;
using MVC_CodeFirst.Repositories.Abstracts;

namespace MVC_CodeFirst.Repositories.Concretes
{
    public class GenreRepository : IGenreRepository
    {
        private MovieProjectContext _context = new MovieProjectContext();

        public void AddGenre(Genre genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();
        }

        public void DeleteGenre(int id)
        {
            var deleted = GetGenreById(id);
            if (deleted != null)
            {
                _context.Genres.Remove(deleted);
                _context.SaveChanges();
            }
        }

        public List<Genre> GetAllGenres()
        {
            return _context.Genres.ToList();
        }

        public Genre GetGenreById(int id)
        {
            var genre = _context.Genres.Find(id);
            return genre;
        }

        public void UpdateGenre(Genre genre)
        {
            var updated = GetGenreById(genre.ID);
            if (updated != null)
            {
                updated.Name = genre.Name;
                _context.SaveChanges();
            }
        }
    }
}
