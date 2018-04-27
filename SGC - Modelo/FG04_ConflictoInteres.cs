namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG04_ConflictoInteres
    {
        [Key]
        public int idFG04 { get; set; }

        public int idTipoConflicto { get; set; }

        public int idGestion { get; set; }

        [Required]
        [StringLength(100)]
        public string identificacion { get; set; }

        [Required]
        [StringLength(500)]
        public string medidas { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual TiposConflicto TiposConflicto { get; set; }
    }
}
