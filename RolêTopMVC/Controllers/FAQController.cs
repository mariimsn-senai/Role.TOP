using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult FAQ()
        {
            ViewData["NomeView"] = "FAQ";
            return View();
        }
    }
}