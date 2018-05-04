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
    [Authorize]
    public class EstadoGestionController : Controller
    {
        private Modelo db = new Modelo();

        // GET: EstadoGestion
        public ActionResult Index()
        {
            return View(db.EstadoGestion.ToList());
        }

        // GET: EstadoGestion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoGestion estadoGestion = db.EstadoGestion.Find(id);
            if (estadoGestion == null)
            {
                return HttpNotFound();
            }
            return View(estadoGestion);
        }

        // GET: EstadoGestion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoGestion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEstadoGestion,estado")] EstadoGestion estadoGestion)
        {
            if (ModelState.IsValid)
            {
                db.EstadoGestion.Add(estadoGestion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estadoGestion);
        }

        // GET: EstadoGestion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoGestion estadoGestion = db.EstadoGestion.Find(id);
            if (estadoGestion == null)
            {
                return HttpNotFound();
            }
            return View(estadoGestion);
        }

        // POST: EstadoGestion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idEstadoGestion,estado")] EstadoGestion estadoGestion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estadoGestion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estadoGestion);
        }

        // GET: EstadoGestion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstadoGestion estadoGestion = db.EstadoGestion.Find(id);
            if (estadoGestion == null)
            {
                return HttpNotFound();
            }
            return View(estadoGestion);
        }

        // POST: EstadoGestion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EstadoGestion estadoGestion = db.EstadoGestion.Find(id);
            db.EstadoGestion.Remove(estadoGestion);
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
