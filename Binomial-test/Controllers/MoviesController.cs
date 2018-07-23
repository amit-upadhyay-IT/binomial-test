using Binomial_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Binomial_test.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Raazi" };  // in a real world application we often get a model from a db
            return View(movie);
        }
    }
}