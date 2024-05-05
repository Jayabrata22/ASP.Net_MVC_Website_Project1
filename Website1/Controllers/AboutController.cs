using Microsoft.AspNetCore.Mvc;

namespace Website1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
