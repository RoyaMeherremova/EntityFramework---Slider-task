using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_Sophia.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
