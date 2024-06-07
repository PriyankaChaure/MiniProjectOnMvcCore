using Microsoft.AspNetCore.Mvc;
using mvc_core_mini_project.CustFilter;

namespace mvc_core_mini_project.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [CustomFilter]
    public class UserAreaHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
