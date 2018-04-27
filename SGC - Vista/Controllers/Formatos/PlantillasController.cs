using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SGC___Modelo;

namespace SGC___Vista.Controllers.Formatos
{
    public class PlantillasController : Controller
    {
        private Modelo db = new Modelo();

        // GET: Plantillas
        public ActionResult Index()
        {
            var formatoPlantilla = db.FormatoPlantilla.Include(f => f.FormatoGestion);
            return View(formatoPlantilla.ToList());
        }

        // GET: Plantillas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormatoPlantilla formatoPlantilla = db.FormatoPlantilla.Find(id);
            if (formatoPlantilla == null)
            {
                return HttpNotFound();
            }
            formatoPlantilla.cuerpoDocumento = VistaPrevia(formatoPlantilla.cuerpoDocumento, id);
            return View(formatoPlantilla);
        }

        private string VistaPrevia(string htmlRaw, int? id)
        {
            switch (id)
            {
                case 1: htmlRaw = previsualisar.FG01(htmlRaw); break;
                case 2: htmlRaw = previsualisar.FG02(htmlRaw); break;
                case 3: htmlRaw = previsualisar.FG03(htmlRaw); break;    
                default:
                    break;
            }
            return htmlRaw;
        }

        // GET: Plantillas/Create
        public ActionResult Create()
        {
            ViewBag.idCodigoFG = new SelectList(db.FormatoGestion, "idCodigoFG", "codigo");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "idFormato,idCodigoFG,titulo,cuerpoDocumento,fechaCreacion,version,obsoleto,solicitudCambio,activo")] FormatoPlantilla formatoPlantilla)
        {
            if (ModelState.IsValid)
            {
                db.FormatoPlantilla.Add(formatoPlantilla);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idCodigoFG = new SelectList(db.FormatoGestion, "idCodigoFG", "codigo", formatoPlantilla.idCodigoFG);
            return View(formatoPlantilla);
        }

        // GET: Plantillas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormatoPlantilla formatoPlantilla = db.FormatoPlantilla.Find(id);
            if (formatoPlantilla == null)
            {
                return HttpNotFound();
            }
            ViewBag.idCodigoFG = new SelectList(db.FormatoGestion, "idCodigoFG", "codigo", formatoPlantilla.idCodigoFG);
            return View(formatoPlantilla);
        }

        // POST: Plantillas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "idFormato,idCodigoFG,titulo,cuerpoDocumento,fechaCreacion,version,obsoleto,solicitudCambio,activo")] FormatoPlantilla formatoPlantilla)
        {
            if (ModelState.IsValid)
            {
                db.Entry(formatoPlantilla).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idCodigoFG = new SelectList(db.FormatoGestion, "idCodigoFG", "codigo", formatoPlantilla.idCodigoFG);
            return View(formatoPlantilla);
        }

        // GET: Plantillas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormatoPlantilla formatoPlantilla = db.FormatoPlantilla.Find(id);
            if (formatoPlantilla == null)
            {
                return HttpNotFound();
            }
            return View(formatoPlantilla);
        }

        // POST: Plantillas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FormatoPlantilla formatoPlantilla = db.FormatoPlantilla.Find(id);
            db.FormatoPlantilla.Remove(formatoPlantilla);
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
