namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG10Radiaciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idFG10R { get; set; }

        public int idFG10 { get; set; }

        public int idTipoRadiacion { get; set; }

        public virtual FG10_SolicitudDosExterna FG10_SolicitudDosExterna { get; set; }

        public virtual TipoRadiacion TipoRadiacion { get; set; }
    }
}
