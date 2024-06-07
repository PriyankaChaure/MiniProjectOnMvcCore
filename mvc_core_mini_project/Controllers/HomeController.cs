using Microsoft.AspNetCore.Mvc;
using mvc_core_mini_project.Models.LoginVM;
using mvc_core_mini_project.Reposiratories;

namespace mvc_core_mini_project.Controllers
{
    public class HomeController : Controller
    {
        UserLoginInterface uli;
        public HomeController(UserLoginInterface uli)
        {
            this.uli = uli;
        }

        public IActionResult Index()
        {
            return RedirectToAction("SignIn");
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(UserLogin rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.uli.SignIn(rec);
                if (res.IsLoggedIn)
                {
                    HttpContext.Session.SetString("Uname",res.UserName);
                    HttpContext.Session.SetString("UID", res.LoggedInID.ToString());
                    return RedirectToAction("Index", "UserAreaHome", new { area = "UserArea" });
                }
                else
                {
                    ModelState.AddModelError("", res.Message);
                    return View(rec);
                }
            }

            return View(rec);
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SignUp(UserLoginVM rec)
        {
            if (ModelState.IsValid)
            {
               this.uli.Registration(rec);
                return RedirectToAction("SignIn");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View();
        }
    }
}
