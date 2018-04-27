namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Representante")]
    public partial class Representante
    {
        [Key]
        public int idRepresentante { get; set; }

        public int id_persona { get; set; }

        public int idFG10 { get; set; }

        public virtual FG10_SolicitudDosExterna FG10_SolicitudDosExterna { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
