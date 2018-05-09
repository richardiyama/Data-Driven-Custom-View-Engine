using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CustomViewEngine.Core;
using CustomViewEngine.Models;

namespace CustomViewEngine.Controllers
{
    public class DataFormController : Controller
    {
        private CustomViewEngineContext db = new CustomViewEngineContext();

        //
        // GET: /DataForm/

        public ActionResult Index()
        {
            return View(db.DataForms.ToList());
        }

        //
        // GET: /DataForm/Details/5

        public ActionResult Details(int id = 0)
        {
            DataForm dataform = db.DataForms.Find(id);
            if (dataform == null)
            {
                return HttpNotFound();
            }
            return View(dataform);
        }

        //
        // GET: /DataForm/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DataForm/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DataForm dataform)
        {
            if (ModelState.IsValid)
            {
                db.DataForms.Add(dataform);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dataform);
        }

        //
        // GET: /DataForm/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DataForm dataform = db.DataForms.Find(id);
            if (dataform == null)
            {
                return HttpNotFound();
            }
            return View(dataform);
        }

        //
        // POST: /DataForm/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DataForm dataform)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dataform).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dataform);
        }

        //
        // GET: /DataForm/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DataForm dataform = db.DataForms.Find(id);
            if (dataform == null)
            {
                return HttpNotFound();
            }
            return View(dataform);
        }

        //
        // POST: /DataForm/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DataForm dataform = db.DataForms.Find(id);
            db.DataForms.Remove(dataform);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}