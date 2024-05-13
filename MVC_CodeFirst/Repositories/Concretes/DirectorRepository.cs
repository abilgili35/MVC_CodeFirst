using Microsoft.EntityFrameworkCore;
using MVC_CodeFirst.Models.Context;
using MVC_CodeFirst.Models.Entities;
using MVC_CodeFirst.Repositories.Abstracts;

namespace MVC_CodeFirst.Repositories.Concretes
{
    public class DirectorRepository : IDirectorRepository
    {
        private MovieProjectContext _context = new MovieProjectContext();

        public void AddDirector(Director director)
        {
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public void DeleteDirector(int id)
        {
            var deleted = GetDirectorById(id);

            if (deleted != null)
            {
                _context.Directors.Remove(deleted);
                _context.SaveChanges();
            }
        }

        public List<Director> GetAllDirectors()
        {
            return _context.Directors.ToList();
        }

        public Director GetDirectorById(int id)
        {
            var director = _context.Directors.Find(id);
            return director;
        }

        public void UpdateDirector(Director director)
        {
            var updated = GetDirectorById(director.ID);
            if (updated != null)
            {
                updated.Firstname = director.Firstname;
                updated.Lastname = director.Lastname;
                _context.SaveChanges();
            }
        }
    }
}
