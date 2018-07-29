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
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Raazi" };
            //return View(movie);
            //return Content("Hi there");
            //return HttpNotFound();
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
    }
}