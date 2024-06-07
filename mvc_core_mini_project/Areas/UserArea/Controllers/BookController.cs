using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mvc_core_mini_project.CustFilter;
using mvc_core_mini_project.Models;
using mvc_core_mini_project.Reposiratories;

namespace mvc_core_mini_project.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [CustomFilter]
    public class BookController : Controller
    {
        BookInterface bi;
        AuthorInterface ai;
        SubjectInterface si;
        public BookController(BookInterface bi, AuthorInterface ai, SubjectInterface si)
        {
            this.bi = bi;
            this.ai = ai;
            this.si = si;
        }
        public IActionResult Index()
        {
            ViewBag.SubjectId = new SelectList(this.si.GetAllSubjects(), "SubjectId", "SubjectName");
            ViewBag.AuthorId = new SelectList(this.ai.GetAllAuthors(), "AuthorId", "AuthorName");
            return View(this.bi.GetAllBooks());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.SubjectId = new SelectList(this.si.GetAllSubjects(), "SubjectId", "SubjectName");
            ViewBag.AuthorId = new SelectList(this.ai.GetAllAuthors(), "AuthorId", "AuthorName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book rec)
        {
            ViewBag.SubjectId = new SelectList(this.si.GetAllSubjects(), "SubjectId", "SubjectName",rec.SubjectId);
            ViewBag.AuthorId = new SelectList(this.ai.GetAllAuthors(), "AuthorId", "AuthorName",rec.AuthorId);
            if (ModelState.IsValid)
            {
                this.bi.Add(rec);
                return RedirectToAction("Index");
            }

            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.bi.GetBookById(id);
            ViewBag.SubjectId = new SelectList(this.si.GetAllSubjects(), "SubjectId", "SubjectName",rec.SubjectId);
            ViewBag.AuthorId = new SelectList(this.ai.GetAllAuthors(), "AuthorId", "AuthorName",rec.AuthorId);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Book rec)
        {
            ViewBag.SubjectId = new SelectList(this.si.GetAllSubjects(), "SubjectId", "SubjectName", rec.SubjectId);
            ViewBag.AuthorId = new SelectList(this.ai.GetAllAuthors(), "AuthorId", "AuthorName", rec.AuthorId);
            if (ModelState.IsValid)
            {
                this.bi.Edit(rec);
                return RedirectToAction("Index");
            }

            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.bi.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.bi.GetBookById(id);
            ViewBag.SubjectId = new SelectList(this.si.GetAllSubjects(), "SubjectId", "SubjectName", rec.SubjectId);
            ViewBag.AuthorId = new SelectList(this.ai.GetAllAuthors(), "AuthorId", "AuthorName", rec.AuthorId);
            return View(rec);
        }
    }
}
