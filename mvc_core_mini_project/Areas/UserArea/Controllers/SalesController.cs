using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mvc_core_mini_project.CustFilter;
using mvc_core_mini_project.Models;
using mvc_core_mini_project.Reposiratories;

namespace mvc_core_mini_project.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [CustomFilter]
    public class SalesController : Controller
    {
        SalesInterface si;
        CustomerInterface ci;
        BookInterface bi;
        CustsalvmInterface csi;
        public SalesController(SalesInterface si, CustomerInterface ci,BookInterface bi, CustsalvmInterface csi)
        {
            this.si = si;
            this.ci = ci;
            this.bi = bi;
            this.csi = csi;
        }
        public IActionResult Index()
        {
            ViewBag.CustomerId = new SelectList(this.ci.GetAllCustomers(), "CustomerId", "CustomerName");
            ViewBag.BookId = new SelectList(this.bi.GetAllBooks(), "BookId", "BookName");
            return View(this.si.GetAllSales());
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CustomerId = new SelectList(this.ci.GetAllCustomers(), "CustomerId", "CustomerName");
            ViewBag.BookId = new SelectList(this.bi.GetAllBooks(), "BookId", "BookName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(custsalVM rec)
        {
            ViewBag.CustomerId = new SelectList(this.ci.GetAllCustomers(), "CustomerId", "CustomerName",rec.CustomerId);
            ViewBag.BookId = new SelectList(this.bi.GetAllBooks(), "BookId", "BookName",rec.BookId);
            if (ModelState.IsValid)
            {
                this.csi.Add(rec);
                return RedirectToAction("Index");
            }

            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.csi.GetId(id);
            ViewBag.CustomerId = new SelectList(this.ci.GetAllCustomers(), "CustomerId", "CustomerName",rec.CustomerId);
            ViewBag.BookId = new SelectList(this.bi.GetAllBooks(), "BookId", "BookName",rec.BookId);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(custsalVM rec)
        {
            ViewBag.CustomerId = new SelectList(this.ci.GetAllCustomers(), "CustomerId", "CustomerName",rec.CustomerId);
            ViewBag.BookId = new SelectList(this.bi.GetAllBooks(), "BookId", "BookName", rec.BookId);
            if (ModelState.IsValid)
            {
                this.csi.Edit(rec);
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
        public IActionResult 
            Details(Int64 id)
        {
            var rec = this.si.GetSalesById(id);
            ViewBag.CustomerId = new SelectList(this.ci.GetAllCustomers(), "CustomerId", "CustomerName", rec.CustomerId);
            ViewBag.BookId = new SelectList(this.bi.GetAllBooks(), "BookId", "BookName", rec.BookId);
            return View(rec);
        }
    }
}
