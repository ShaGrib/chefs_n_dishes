using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using chefs_n_dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace chefs_n_dishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            List<Chef> AllChefs = _context.Chefs.Include(d => d.Dishes).ToList();
            ViewBag.AllChefs = AllChefs;
            return View();
        }

        [Route("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> AllDishes = _context.Dishes.Include(c => c.Chef).ToList();
            ViewBag.AllDishes = AllDishes;
            return View();
        }

        [Route("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Process(Chef newChef)
        {
            if (ModelState.IsValid)
            {
                int Today = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                int DOB = int.Parse(newChef.DateOfBirth.ToString("yyyyMMdd"));
                int Age = (Today - DOB) / 10000;
                if (Age >= 18)
                {
                    _context.Add(newChef);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("DateOfBirth", "Chef must be at least 18 Years old");
                    return View("New");
                }
            }
            else
            {
                return View("New");
            }
        }

        [Route("dishes/new")]
        public IActionResult DishesNew()
        {
            List<Chef> AllChefs = _context.Chefs.OrderByDescending(c => c.ChefId).ToList();
            ViewBag.AllChefs = AllChefs;
            return View();
        }

        [HttpPost("dishes/create")]
        public IActionResult DishesProcess(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("DishesNew");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
