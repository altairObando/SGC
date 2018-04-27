namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG28_PlanAccion
    {
        [Key]
        public int idPlanAccion { get; set; }

        public int idFG28 { get; set; }

        public int id_persona { get; set; }

        [Required]
        [StringLength(100)]
        public string accion { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public virtual FG28_ImplementacionAcc FG28_ImplementacionAcc { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
