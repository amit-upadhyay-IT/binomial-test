using BinoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BinoApp.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Raazi" };
            //return View(movie);
            //return Content("Hi there");
            //return HttpNotFound();
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }


        // GET: /movies/edit/1 -> This is an example of the parameter embedded with the URL
        // GET: /movies/edit?id=1 ->Again the same action will be called, this is example of query string
        public ActionResult Edit(int movieId)
        {
            return Content("movieId = " + movieId);
        }

        /*
        // GET: http://localhost:50914/movies/edit?movieId=1
        // this will not work for /movies/edit/1, because the name of the parameter in our default route is id, not movieId.
         public ActionResult Edit(int movieId)
        {
            return Content("movieId = " + movieId);
        }
        */
    }
}
 