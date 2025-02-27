using Microsoft.AspNetCore.Mvc;

namespace ASPNET.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }public IActionResult Register()
        {
            return View();
        }
    }
}
