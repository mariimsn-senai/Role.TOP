using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "FAQ";
            return View();
        }
    }
}