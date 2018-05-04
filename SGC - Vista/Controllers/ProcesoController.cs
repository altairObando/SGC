
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SGC___Modelo;

namespace SGC___Vista.Controllers
{
    [Authorize]
    public class ProcesoController : Controller
    {
        private Modelo db = new Modelo();

        // GET: Proceso
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult getProcesos()
        {
            var P = db.Proceso.Include(x => x.Cliente)
                              .Include(y => y.EstadoGestion);
            var result = from item in P
                         select new {
                             institucion = item.Cliente.nombreInstitucion,
                             estado = item.EstadoGestion.estado,
                             finicio = item.fechaInicio,
                             ffin = item.fechaFin,
                             anulado = item.anulado,
                             id = item.idProceso
                         };
            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Editar(int? id)
        {

            ViewBag.idEstadoGestion = new SelectList(db.EstadoGestion, "idEstadoGestion", "estado");
            ViewBag.idCliente = new SelectList(db.Cliente, "idCliente", "nombreInstitucion");


            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            if (id == 0)
                return View(new Proceso());

            var p = db.Proceso.Find(id);
            if (p == null)
                return HttpNotFound();
            return View(p);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Editar([Bind(Include ="idProceso, idEstadoGestion, idCliente, fechaInicio, fechaFin, anulado")]Proceso proceso)
        {
            if(ModelState.IsValid)
            {
                if(proceso.idProceso == 0)
                {
                    db.Proceso.Add(proceso);
                    db.SaveChanges();
                    return Json(new { success = true, message = "Guardado!" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    db.Entry(proceso).State = EntityState.Modified;
                    db.SaveChanges();
                    return Json(new { success = true, message = "Actualizado!" }, JsonRequestBehavior.AllowGet);
                }
            }
            ViewBag.idEstadoGestion = new SelectList(db.EstadoGestion, "idEstadoGestion", "estado");
            ViewBag.idCliente = new SelectList(db.Cliente, "idCliente", "nombreInstitucion");
            return Json(new { success = false, message = "Error!" }, JsonRequestBehavior.AllowGet);
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
