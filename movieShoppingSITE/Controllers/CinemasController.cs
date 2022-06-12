using Microsoft.AspNetCore.Mvc;
using movieShoppingSITE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieShoppingSITE.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allCinemas = _context.Cinemas;
            allCinemas.ToList();
            return View(allCinemas);
        }
    }
}
