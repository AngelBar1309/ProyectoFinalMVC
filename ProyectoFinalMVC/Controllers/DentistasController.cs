using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoFinalMVC.Models;

namespace ProyectoFinalMVC.Controllers
{
    public class DentistasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Dentistas
        public ActionResult Index()
        {
            return View(db.dentistas.ToList());
        }

        // GET: Dentistas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dentistas dentistas = db.dentistas.Find(id);
            if (dentistas == null)
            {
                return HttpNotFound();
            }
            return View(dentistas);
        }

        // GET: Dentistas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dentistas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "dentistasID,nombre,especialidad,telefono,direccion")] Dentistas dentistas)
        {
            if (ModelState.IsValid)
            {
                db.dentistas.Add(dentistas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dentistas);
        }

        // GET: Dentistas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dentistas dentistas = db.dentistas.Find(id);
            if (dentistas == null)
            {
                return HttpNotFound();
            }
            return View(dentistas);
        }

        // POST: Dentistas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "dentistasID,nombre,especialidad,telefono,direccion")] Dentistas dentistas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dentistas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dentistas);
        }

        // GET: Dentistas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dentistas dentistas = db.dentistas.Find(id);
            if (dentistas == null)
            {
                return HttpNotFound();
            }
            return View(dentistas);
        }

        // POST: Dentistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dentistas dentistas = db.dentistas.Find(id);
            db.dentistas.Remove(dentistas);
            db.SaveChanges();
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
