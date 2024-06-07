using Microsoft.AspNetCore.Mvc;
using mvc_core_mini_project.Models;
using mvc_core_mini_project.Reposiratories;
using mvc_core_mini_project.CustFilter;


namespace mvc_core_mini_project.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [CustomFilter]
    public class AuthorController : Controller
    {
        AuthorInterface ai;
        public AuthorController(AuthorInterface ai)
        {
            this.ai = ai;
        }
        public IActionResult Index()
        {
            return View(this.ai.GetAllAuthors());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Author rec)
        {
            if (ModelState.IsValid)
            {
                this.ai.Add(rec);
                return RedirectToAction("Index");
            }

            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.ai.GetAuthorById(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Author rec)
        {
            if (ModelState.IsValid)
            {
                this.ai.Edit(rec);
                return RedirectToAction("Index");
            }

            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.ai.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.ai.GetAuthorById(id);
            return View(rec);
        }
    }
}
