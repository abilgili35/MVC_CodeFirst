using MVC_CodeFirst.Models.Entities;

namespace MVC_CodeFirst.Repositories.Abstracts
{
    public interface IDirectorRepository
    {
        List<Director> GetAllDirectors();
        Director GetDirectorById(int id);
        void AddDirector(Director director);
        void UpdateDirector(Director director);

        void DeleteDirector(int id);
    }
}
