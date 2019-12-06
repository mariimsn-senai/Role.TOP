using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class AdmController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "ADM";
            return View();
        }
    }
}