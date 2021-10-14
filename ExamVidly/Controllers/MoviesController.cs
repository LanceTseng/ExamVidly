using System.Collections.Generic;
using System.Web.Mvc;
using ExamVidly.Models;

namespace ExamVidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie/Index
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Wall-e"}
            };
        }

        #region OlderCode

        //// GET: Movie/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie()
        //    {
        //        Name = "Sherk!"
        //    };

        //    var customers = new List<Customer>()
        //    {
        //        new Customer() {Name = "Customer 1"},
        //        new Customer() {Name = "Customer 2"},
        //    };

        //    var viewModel = new RandomMovieViewModel()
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };

        //    #region return type

        //    //return Content("H W");
        //    //return new EmptyResult();
        //    //return new HttpNotFound();
        //    //return RedirectToAction("Index", "Home", new {Page = 1, SortBy = "name"});

        //    #endregion

        //    #region Pass para type (Magic String)

        //    //ViewData["Movie"] = movie;
        //    //ViewBag.Movie = movie;

        //    #endregion

        //    //ViewBag.viewModel = viewModel;

        //    return View(viewModel);

        //}

        //public ActionResult Edit(int Id)
        //{
        //    return Content("Id="+Id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (sortBy.IsNullOrWhiteSpace())
        //        sortBy = "Name";

        //    return Content($@"pageIndex={pageIndex}&sortBy={sortBy}");
        //}

        //[Route("movies/released/{year:regex(\\d4)}/{month:regex(\\d2):range(1,12)}")]
        //public ActionResult ByReleaseYear(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

        #endregion OlderCode
    }
}