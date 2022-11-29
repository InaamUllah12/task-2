using Microsoft.AspNetCore.Mvc;

namespace WAD_TASK_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
