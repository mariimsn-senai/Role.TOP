using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class Clientee2Controller : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cliente";
            return View();
        }
    }
}