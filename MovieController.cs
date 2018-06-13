using DeltaXMovie.Models;
using System;
using System.Collections.Generic;
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
            var Producer = _context.Producers.SingleOrDefault(a=>a.Producer_ID==movies.FirstOrDefault().Movie_ID);
            var viewModel = new Movies();
            ViewBag["a"] = Producer;
            foreach (var item in movies)
            {
                viewModel.Movie_ID = item.Movie_ID;
            }
           
                
            
            
               
            
            return View(viewModel);
        }
    }
}