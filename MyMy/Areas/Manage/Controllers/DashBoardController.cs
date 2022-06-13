using Microsoft.AspNetCore.Mvc;

namespace MyMy.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
