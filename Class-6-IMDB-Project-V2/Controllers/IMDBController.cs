using Class_6_IMDB_Project_V2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Class_6_IMDB_Project_V2.Controllers
{
    public class IMDBController : Controller
    {
        public IMDBContext db { get; set; }

        public IMDBController()
        {
            db = new IMDBContext();
        }

        public IActionResult Index()
        {
            List<Actor> actors = db.Actors.ToList();

            return View(actors);
        }



        public IActionResult ListMovies(int? Id)
        {
            Actor actor = db.Actors.First(a => a.Id == Id);
            var MovieActorList = db.MovieActors.Include(m => m.Movie).Where(m => m.ActorId == actor.Id);

            ViewBag.Actor = actor;

            return View(MovieActorList);
        }




        // GET
        public IActionResult GenreIndex()
        {
            ViewBag.Genres = new SelectList(db.Genres, "Id", "Name");


            return View();
        }

        [HttpPost]
        public IActionResult GenreIndex(int GenreId)
        {
            Genre genre = db.Genres.First(g => g.Id == GenreId);
            List<Movie> movies = db.Movies.Where(m => m.GenreId == GenreId).ToList();

            ViewBag.Genre = genre;

            return View("MoviesByGenre", movies);
        }


        public IActionResult ActorByGenre()
        {
            ViewBag.Genres = new SelectList(db.Genres, "Id", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult ActorByGenre(int GenreId)
        {
            Genre genre = db.Genres.First(g => g.Id == GenreId);
            //List<Actor> actors = db.Actors.Where(a => a.GenreId == GenreId).ToList();
            
            // return a list of actors
            // we are returing a list of movieActors

            // within the movieactor:
            // print all actors
            // in a movie that has a GenreId that mataches our passed in GenreId



            var MovieActorList = db.MovieActors.Include(m => m.Movie).Include(a => a.Actor).Where(m => m.Movie.GenreId == GenreId).ToList();

            //ViewBag.Genre = genre;

            return View("ActorByGenreView", MovieActorList);
        }



    }
}
