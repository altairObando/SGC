namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG10Estados
    {
        [Key]
        public int idFG10Estados { get; set; }

        public int idEstadoSolicitud { get; set; }

        public int? idFG10 { get; set; }

        public virtual EstadoSolicitud EstadoSolicitud { get; set; }

        public virtual FG10_SolicitudDosExterna FG10_SolicitudDosExterna { get; set; }
    }
}
