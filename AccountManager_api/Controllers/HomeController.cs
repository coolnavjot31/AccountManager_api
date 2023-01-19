using Microsoft.AspNetCore.Mvc;

namespace AccountManager_api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
