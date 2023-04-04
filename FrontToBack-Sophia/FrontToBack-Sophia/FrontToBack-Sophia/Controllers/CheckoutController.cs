using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_Sophia.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
