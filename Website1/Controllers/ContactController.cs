using Microsoft.AspNetCore.Mvc;

namespace Website1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Submit(string name, string email, string message)
        {
            if (string.IsNullOrEmpty(name))
            {
                ModelState.AddModelError("Name", "Name is required.");
            }
            if (string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError("Email", "Email is required.");
            }
            if (string.IsNullOrEmpty(message))
            {
                ModelState.AddModelError("Message", "Message is required.");
            }

            // If there are validation errors, return the view with errors
            if (!ModelState.IsValid)
            {
                return View("Contact");
            }

            TempData["SuccessMessage"] = "Thank you for your submission! We have received your message.";

            // Render the original view with the popup message
            return RedirectToAction("Contact");

        }
    }
}
