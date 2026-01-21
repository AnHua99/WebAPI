using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
