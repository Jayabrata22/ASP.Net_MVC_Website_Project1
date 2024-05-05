using Microsoft.AspNetCore.Mvc;

namespace Website1.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Service()
        {
            return View();
        }
    }
}
