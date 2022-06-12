using Microsoft.AspNetCore.Mvc;
using movieShoppingSITE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieShoppingSITE.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allMovies = _context.Movies;
                allMovies.ToList();
            return View(allMovies);
        }
    }
}
