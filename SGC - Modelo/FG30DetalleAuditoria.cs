namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG30DetalleAuditoria
    {
        [Key]
        public int idDetalleAuditoria { get; set; }

        public int idFG30 { get; set; }

        public int idLaboratorio { get; set; }

        public int idCriterio { get; set; }

        [Required]
        [StringLength(100)]
        public string objeto { get; set; }

        [Required]
        [StringLength(50)]
        public string alcance { get; set; }

        public int noEvaluaciones { get; set; }

        public int horasProgramadas { get; set; }

        [Required]
        [StringLength(50)]
        public string ciclo { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public virtual FG30_ProgramaAuditoria FG30_ProgramaAuditoria { get; set; }

        public virtual FG30CriteriosAuditoria FG30CriteriosAuditoria { get; set; }

        public virtual Laboratorio Laboratorio { get; set; }
    }
}
