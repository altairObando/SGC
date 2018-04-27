namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG31_Evaluacion
    {
        [Key]
        public int idEvaluacion { get; set; }

        public int idFG31 { get; set; }

        public int idCriterio { get; set; }

        public double ponderado { get; set; }

        public double puntaje { get; set; }

        [Required]
        [StringLength(100)]
        public string observacion { get; set; }

        public virtual FG31_CalificacionAuditores FG31_CalificacionAuditores { get; set; }

        public virtual FG31_Criterio FG31_Criterio { get; set; }
    }
}
