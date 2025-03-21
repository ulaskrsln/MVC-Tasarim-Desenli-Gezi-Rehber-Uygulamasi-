using Microsoft.AspNetCore.Mvc;

namespace TravelApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
