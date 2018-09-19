using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPNET.Bootcamp.DataAccess.Context;
using ASPNET.Bootcamp.DataAccess.Models;
using ASPNET.Bootcamp.Common.Interfaces;
using ASPNET.Bootcamp.DataAccess.Params;

namespace ASPNET.Bootcamp.Controllers
{
    public class SuppliersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private readonly ISupplierService _supplierService;

        public SuppliersController() { }

        public SuppliersController(ISupplierService supplierService)
        {
            this._supplierService = supplierService;
        }

        // GET: Suppliers
        public async Task<ActionResult> Index()
        {
            var get = _supplierService.Get();
            return View(get);
        }

        // GET: Suppliers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            var get = _supplierService.Get(id);
            return View(get);
        }

        // GET: Suppliers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Suppliers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(SupplierParam param)
        {
            if (ModelState.IsValid)
            {
                _supplierService.Insert(param);
                return RedirectToAction("Index");
            }

            return View(param);
        }

        // GET: Suppliers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            var get = _supplierService.Get(id);
            return View(get);
        }

        // POST: Suppliers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(SupplierParam param)
        {
            if (ModelState.IsValid)
            {
                _supplierService.Update(param.Id, param);
                return RedirectToAction("Index");
            }
            return View(param);
        }

        // GET: Suppliers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            var get = _supplierService.Get(id);
            return View(get);
        }

        // POST: Suppliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            _supplierService.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
