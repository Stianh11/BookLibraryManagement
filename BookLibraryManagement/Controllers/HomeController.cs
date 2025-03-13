using Microsoft.AspNetCore.Mvc;

namespace BookLibraryManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
