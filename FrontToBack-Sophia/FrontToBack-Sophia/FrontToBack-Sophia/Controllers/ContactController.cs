using Microsoft.AspNetCore.Mvc;

namespace FrontToBack_Sophia.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
