using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class LoginImgController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "LoginImg";
            return View();
        }
    }
}