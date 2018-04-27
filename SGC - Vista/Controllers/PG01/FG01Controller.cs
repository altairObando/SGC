using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SGC___Modelo;

namespace SGC___Vista.Controllers.PG01
{
    public class FG01Controller : Controller
    {
        private Modelo db = new Modelo();

        // GET: FG01
        public ActionResult Index()
        {
            var fG01_CCompromiso = db.FG01_CCompromiso.Include(f => f.Gestion).Include(f => f.Persona);
            return View(fG01_CCompromiso.ToList());
        }

        // GET: FG01/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FG01_CCompromiso fG01_CCompromiso = db.FG01_CCompromiso.Find(id);
            if (fG01_CCompromiso == null)
            {
                return HttpNotFound();
            }
            return View(fG01_CCompromiso);
        }

        // GET: FG01/Create
        public ActionResult Create()
        {
            ViewBag.idGestion = new SelectList(db.Gestion, "idGestion", "idGestion");
            ViewBag.idPersona = new SelectList(db.Persona, "id_persona", "nombres");
            return View();
        }

        // POST: FG01/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idFG01,idGestion,idPersonaCargo")] FG01_CCompromiso fG01_CCompromiso)
        {
            if (ModelState.IsValid)
            {
                db.FG01_CCompromiso.Add(fG01_CCompromiso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idGestion = new SelectList(db.Gestion, "idGestion", "idGestion", fG01_CCompromiso.idGestion);
            ViewBag.idPersona = new SelectList(db.Persona, "id_persona", "nombres", fG01_CCompromiso.id_persona);
            return View(fG01_CCompromiso);
        }

        // GET: FG01/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FG01_CCompromiso fG01_CCompromiso = db.FG01_CCompromiso.Find(id);
            if (fG01_CCompromiso == null)
            {
                return HttpNotFound();
            }
            ViewBag.idGestion = new SelectList(db.Gestion, "idGestion", "idGestion", fG01_CCompromiso.idGestion);
            ViewBag.idPersonaCargo = new SelectList(db.Persona, "id_persona", "nombres", fG01_CCompromiso.id_persona);
            return View(fG01_CCompromiso);
        }

        // POST: FG01/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idFG01,idGestion,idPersonaCargo")] FG01_CCompromiso fG01_CCompromiso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fG01_CCompromiso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idGestion = new SelectList(db.Gestion, "idGestion", "idGestion", fG01_CCompromiso.idGestion);
            ViewBag.idPersonaCargo = new SelectList(db.Persona, "id_persona", "nombres", fG01_CCompromiso.id_persona);
            return View(fG01_CCompromiso);
        }

        // GET: FG01/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FG01_CCompromiso fG01_CCompromiso = db.FG01_CCompromiso.Find(id);
            if (fG01_CCompromiso == null)
            {
                return HttpNotFound();
            }
            return View(fG01_CCompromiso);
        }

        // POST: FG01/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FG01_CCompromiso fG01_CCompromiso = db.FG01_CCompromiso.Find(id);
            db.FG01_CCompromiso.Remove(fG01_CCompromiso);
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
