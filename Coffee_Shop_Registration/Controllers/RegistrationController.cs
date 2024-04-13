using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_Registration.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string firstName, string email, string password)
        {
            ViewData["FirstName"] = firstName;
            return View("Result");
        }
    }
}
