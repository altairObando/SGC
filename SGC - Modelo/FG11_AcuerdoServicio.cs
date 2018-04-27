namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG11_AcuerdoServicio
    {
        [Key]
        public int idFG11 { get; set; }

        public int idGestion { get; set; }

        public int? idFG10 { get; set; }

        public virtual FG10_SolicitudDosExterna FG10_SolicitudDosExterna { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
