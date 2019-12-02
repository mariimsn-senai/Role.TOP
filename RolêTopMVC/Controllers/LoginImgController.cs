using Microsoft.AspNetCore.Mvc;

namespace RolêTopMVC.Controllers
{
    public class LoginImgController : Controller
    {
        public IActionResult LoginImg()
        {
            ViewData["NomeView"] = "LoginImg";
            return View();
        }
    }
}