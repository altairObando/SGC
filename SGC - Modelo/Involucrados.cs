namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Involucrados
    {
        [Key]
        public int idInvolucrado { get; set; }

        public int idFG35 { get; set; }

        public int id_persona { get; set; }

        public virtual FG35_LevantamientoDeEvidencia FG35_LevantamientoDeEvidencia { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
