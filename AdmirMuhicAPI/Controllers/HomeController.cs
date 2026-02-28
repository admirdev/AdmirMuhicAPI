using Microsoft.AspNetCore.Mvc;

namespace AdmirMuhicAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
