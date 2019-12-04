using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class Clientee2Controller : Controller
    {
        public IActionResult Cliente()
        {
            ViewData["NomeView"] = "Cliente";
            return View();
        }
    }
}