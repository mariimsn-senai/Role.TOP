using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            ViewData["NomeView"] = "Login";
            return View();
        }
    }
}