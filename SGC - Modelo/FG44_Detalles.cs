namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG44_Detalles
    {
        [Key]
        public int idFG44Detalles { get; set; }

        public int idFG44 { get; set; }

        public int id_persona { get; set; }

        [Required]
        [StringLength(1000)]
        public string descripcion { get; set; }

        [Required]
        [StringLength(1000)]
        public string accionesdeMejora { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaInicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaFin { get; set; }

        [Required]
        [StringLength(1000)]
        public string recursos { get; set; }

        public virtual FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
