using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_Sophia.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
