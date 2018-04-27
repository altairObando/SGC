using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SGC___Modelo;

namespace SGC___Vista.Controllers.Codigos
{
    public class PGController : Controller
    {
        private Modelo db = new Modelo();

        // GET: PG
        public ActionResult Index()
        {
            return View(db.ProcesoGestion.ToList());
        }

        // GET: PG/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProcesoGestion procesoGestion = db.ProcesoGestion.Find(id);
            if (procesoGestion == null)
            {
                return HttpNotFound();
            }
            return View(procesoGestion);
        }

        // GET: PG/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PG/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idProceso,codigoProceso,significado")] ProcesoGestion procesoGestion)
        {
            if (ModelState.IsValid)
            {
                db.ProcesoGestion.Add(procesoGestion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(procesoGestion);
        }

        // GET: PG/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProcesoGestion procesoGestion = db.ProcesoGestion.Find(id);
            if (procesoGestion == null)
            {
                return HttpNotFound();
            }
            return View(procesoGestion);
        }

        // POST: PG/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idProceso,codigoProceso,significado")] ProcesoGestion procesoGestion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(procesoGestion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(procesoGestion);
        }

        // GET: PG/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProcesoGestion procesoGestion = db.ProcesoGestion.Find(id);
            if (procesoGestion == null)
            {
                return HttpNotFound();
            }
            return View(procesoGestion);
        }

        // POST: PG/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProcesoGestion procesoGestion = db.ProcesoGestion.Find(id);
            db.ProcesoGestion.Remove(procesoGestion);
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
