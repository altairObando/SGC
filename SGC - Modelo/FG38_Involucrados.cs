namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG38_Involucrados
    {
        [Key]
        public int idF38Involucrado { get; set; }

        public int idFG38 { get; set; }

        public int id_persona { get; set; }

        public virtual FG38_CumplimientoDeObjetivos FG38_CumplimientoDeObjetivos { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
