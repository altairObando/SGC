namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG33Detalle
    {
        [Key]
        public int idFG33Detalle { get; set; }

        public int idFG33PlanAuditoria { get; set; }

        public int idLaboratorio { get; set; }

        [Required]
        [StringLength(100)]
        public string actividades { get; set; }

        [Column(TypeName = "date")]
        public DateTime dia { get; set; }

        public int horas { get; set; }

        [Required]
        [StringLength(25)]
        public string codigoDoc { get; set; }

        public virtual FG33_PlanAuditoriaInterna FG33_PlanAuditoriaInterna { get; set; }

        public virtual Laboratorio Laboratorio { get; set; }
    }
}
