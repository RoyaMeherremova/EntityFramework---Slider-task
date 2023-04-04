using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_Sophia.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
