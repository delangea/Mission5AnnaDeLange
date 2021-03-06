using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4Assignment.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext blah)
        {
            _logger = logger;
            _blahContext = blah;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Podcast()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = _blahContext.category.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Movies(Movie m)
        {
            if (ModelState.IsValid)
            {
                _blahContext.Add(m);
                _blahContext.SaveChanges();

                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = _blahContext.category.ToList();
                return View(m);
            }
        }
        public IActionResult MovieList()
        {
            var movies = _blahContext.responses.Include(a => a.Category).ToList();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _blahContext.category.ToList();
            var movie = _blahContext.responses.Single(x => x.MovieID == movieid);
            return View("Movies", movie);
        }
        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            if (ModelState.IsValid)
            {
                _blahContext.Update(m);
                _blahContext.SaveChanges();

                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = _blahContext.category.ToList();
                return View(m);
            }
        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = _blahContext.responses.Single(x => x.MovieID == movieid);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(Movie m)
        {
            _blahContext.responses.Remove(m);
            _blahContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
