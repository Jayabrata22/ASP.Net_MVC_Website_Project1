using Microsoft.AspNetCore.Mvc;

namespace Website1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
