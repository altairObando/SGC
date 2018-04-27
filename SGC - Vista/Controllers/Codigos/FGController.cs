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
    public class FGController : Controller
    {
        private Modelo db = new Modelo();

        // GET: FG
        public ActionResult Index()
        {
            var formatoGestion = db.FormatoGestion.Include(f => f.ProcesoGestion);
            return View(formatoGestion.ToList());
        }

        // GET: FG/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormatoGestion formatoGestion = db.FormatoGestion.Find(id);
            if (formatoGestion == null)
            {
                return HttpNotFound();
            }
            return View(formatoGestion);
        }

        // GET: FG/Create
        public ActionResult Create()
        {
            ViewBag.idProceso = new SelectList(db.ProcesoGestion, "idProceso", "codigoProceso");
            return View();
        }

        // POST: FG/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCodigoFG,idProceso,codigo")] FormatoGestion formatoGestion)
        {
            if (ModelState.IsValid)
            {
                db.FormatoGestion.Add(formatoGestion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idProceso = new SelectList(db.ProcesoGestion, "idProceso", "codigoProceso", formatoGestion.idProceso);
            return View(formatoGestion);
        }

        // GET: FG/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormatoGestion formatoGestion = db.FormatoGestion.Find(id);
            if (formatoGestion == null)
            {
                return HttpNotFound();
            }
            ViewBag.idProceso = new SelectList(db.ProcesoGestion, "idProceso", "codigoProceso", formatoGestion.idProceso);
            return View(formatoGestion);
        }

        // POST: FG/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCodigoFG,idProceso,codigo")] FormatoGestion formatoGestion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(formatoGestion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idProceso = new SelectList(db.ProcesoGestion, "idProceso", "codigoProceso", formatoGestion.idProceso);
            return View(formatoGestion);
        }

        // GET: FG/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormatoGestion formatoGestion = db.FormatoGestion.Find(id);
            if (formatoGestion == null)
            {
                return HttpNotFound();
            }
            return View(formatoGestion);
        }

        // POST: FG/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FormatoGestion formatoGestion = db.FormatoGestion.Find(id);
            db.FormatoGestion.Remove(formatoGestion);
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
