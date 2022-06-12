using Microsoft.AspNetCore.Mvc;
using movieShoppingSITE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieShoppingSITE.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allProducers = _context.Producers;
            allProducers.ToList();
            return View(allProducers);
        }
    }
}
