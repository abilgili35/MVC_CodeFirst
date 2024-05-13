using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirst.Repositories.Abstracts;

namespace MVC_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public HomeController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IActionResult Index()
        {
            return View(_movieRepository.GetAllMovies());
        }

        public IActionResult Details(int id)
        {
            return View(_movieRepository.GetMovieById(id));
        }

    }
}
