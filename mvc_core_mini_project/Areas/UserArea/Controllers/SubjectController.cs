using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mvc_core_mini_project.CustFilter;
using mvc_core_mini_project.Models;
using mvc_core_mini_project.Reposiratories;

namespace mvc_core_mini_project.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [CustomFilter]
    public class SubjectController : Controller
    {
        SubjectInterface si;
       
        public SubjectController(SubjectInterface si)
        {
            this.si = si;
        }
        public IActionResult Index()
        {
            return View(this.si.GetAllSubjects());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Subject rec)
        {
            if (ModelState.IsValid)
            {
                this.si.Add(rec);
                return RedirectToAction("Index");
            }
         
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.si.GetSubjectById(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Subject rec)
        {
            if (ModelState.IsValid)
            {
                this.si.Edit(rec);
                return RedirectToAction("Index");
            }
         
            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.si.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.si.GetSubjectById(id);
            return View(rec);
        }
    }
}
