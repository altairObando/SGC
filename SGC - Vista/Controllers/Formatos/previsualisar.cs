using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGC___Vista.Controllers.Formatos
{
    public static class previsualisar
    {
        private static string nombreCompleto = "Noel Antonio Obando Espinoza ";
        private static string cedula = " 001-221190-0025A ";
        private static string fecha = DateTime.Now.ToShortDateString();
        private static string checkbox = "<input type='checkbox' />";
        
        /// <summary>
        /// Permite tener una vista previa del FG01 
        /// usando los parametros @nombreCompleto y @cedula
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string FG01(string html)
        {

            return html.Replace("@nombreCompleto", nombreCompleto)
                .Replace("@cedula", cedula);
        }

        internal static string FG02(string htmlRaw)
        {
            
            return htmlRaw.Replace("@fecha", DateTime.Now.ToShortDateString())
                .Replace("@check1", checkbox)
                .Replace("@check2", checkbox)
                .Replace("@check3", checkbox)
                .Replace("@check4", checkbox)
                .Replace("@check5", checkbox)
                .Replace("@check6", checkbox)
                .Replace("@otrosEspecificacion", "__________________")
                .Replace("@nombreCompleto", nombreCompleto)
                .Replace("@cedula", cedula);
        }

        internal static string FG03(string htmlRaw)
        {
            string tabla = "<table class='table table-responsive'>" +
                            "<thead><tr><th>Actividad</th><th>Organización</th>" +
                            "<th>Relación con la organización</th></tr></thead>" +
                            "<tbody><tr></tr><td>_</td><td>_</td><td>_</td>" +
                            "<tr><td>_</td><td>_</td><td>_</td></tr>" +
                            "<tr><td>_</td><td>_</td><td>_</td></tr></tbody></table>";
            return htmlRaw
                .Replace("@nombreCompleto", nombreCompleto)
                .Replace("@cargo", "Desarrollador")
                .Replace("@anio", DateTime.Now.Year.ToString())
                .Replace("@mes", DateTime.Now.Month.ToString())
                .Replace("@dia", DateTime.Now.Day.ToString())
                .Replace("@tablaActividades", tabla)
                .Replace("@cedula", cedula);
        }
    }
}