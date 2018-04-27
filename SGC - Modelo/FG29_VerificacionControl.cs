namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG29_VerificacionControl
    {
        [Key]
        public int idFG29 { get; set; }

        public int idTipo { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string resultados { get; set; }

        [Required]
        [StringLength(100)]
        public string descripcion { get; set; }

        [Required]
        [StringLength(100)]
        public string accionCorrectora { get; set; }

        public int idGestion { get; set; }

        public virtual FG29TiposRegistro FG29TiposRegistro { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
