namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Involucrado")]
    public partial class Involucrado
    {
        [Key]
        public int idPersonal { get; set; }

        public int id_persona { get; set; }

        public int idProceso { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Proceso Proceso { get; set; }
    }
}
