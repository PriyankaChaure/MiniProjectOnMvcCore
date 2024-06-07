using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mvc_core_mini_project.CustFilter;
using mvc_core_mini_project.Models;
using mvc_core_mini_project.Reposiratories;

namespace mvc_core_mini_project.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [CustomFilter]
    public class CustomerController : Controller
    {
        CustomerInterface ci;

        public CustomerController(CustomerInterface ci)
        {
            this.ci = ci;
        }
        public IActionResult Index()
        {
            return View(this.ci.GetAllCustomers());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer rec)
        {
            if (ModelState.IsValid)
            {
                this.ci.Add(rec);
                return RedirectToAction("Index");
            }

            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.ci.GetCustomerById(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Customer rec)
        {
            if (ModelState.IsValid)
            {
                this.ci.Edit(rec);
                return RedirectToAction("Index");
            }

            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.ci.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.ci.GetCustomerById(id);
            return View(rec);
        }
    }
}
