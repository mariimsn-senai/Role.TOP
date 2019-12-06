using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Login";
            return View();
        }
    }
}