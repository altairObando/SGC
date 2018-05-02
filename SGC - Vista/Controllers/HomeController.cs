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
    public class HomeController : Controller
    {
        private Modelo db = new Modelo();
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Este metodo permite obtener el estado de los procesos que se estan ejecutando
        /// </summary>
        /// <returns>Resultado en formato JSON</returns>
        public ActionResult getEstados()
        {
            var estados = db.Proceso.Include(x => x.EstadoGestion);

            int EnProceso = estados.Where(x => x.EstadoGestion.estado == "En Proceso").Count();
            int EnCalibracion = estados.Where(x => x.EstadoGestion.estado == "En Calibración").Count();
            int Entrega = estados.Where(x => x.EstadoGestion.estado == "Entrega de Equipos").Count();
            int Revision = estados.Where(x => x.EstadoGestion.estado == "En Revision").Count();

            return Json(new {proceso = EnProceso, calibracion = EnCalibracion,
                             entrega = Entrega, revision = Revision}, JsonRequestBehavior.AllowGet);
        }
    }
}