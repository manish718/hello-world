using DeltaXMovie.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeltaXMovie.Controllers
{
    public class MovieController : Controller
    {
        private DeltaXMovieDBContext _context;
        public MovieController()
        {
            _context = new DeltaXMovieDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movie
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            var actors = _context.Actors.ToList();
            var producer = _context.Producers.ToList();
            var movie_cast = _context.Movie_Cast.ToList();
            dynamic mymodel = new ExpandoObject();
            mymodel.Movies = movies;
            mymodel.Actors = actors;
            mymodel.Producer = producer;
            mymodel.Movie_cast = movie_cast;
            return View(mymodel);
        }
    }
}