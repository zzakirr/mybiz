using Microsoft.AspNetCore.Mvc;
using MyMy.DAL;
using MyMy.Models;
using System.Linq;

namespace MyMy.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SlidersController : Controller
    {
        private readonly AppDbContext _context;

        public SlidersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Sliders.ToList();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Sliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }


    }
}
