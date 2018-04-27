namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG39_Detalle
    {
        [Key]
        public int idFG39Detalle { get; set; }

        public int idFG39 { get; set; }

        public int Defiidad { get; set; }

        public int enProceso { get; set; }

        public int cerradas { get; set; }

        public virtual FG39_AccionesCorrectivasYPreventivas FG39_AccionesCorrectivasYPreventivas { get; set; }
    }
}
