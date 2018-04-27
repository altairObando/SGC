namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG35_hallazgos
    {
        [Key]
        public int idHallazgo { get; set; }

        public int idFG35 { get; set; }

        [Required]
        [StringLength(150)]
        public string evidencia { get; set; }

        [Required]
        [StringLength(250)]
        public string hallazgos { get; set; }

        [Required]
        [StringLength(250)]
        public string criterio { get; set; }

        public virtual FG35_LevantamientoDeEvidencia FG35_LevantamientoDeEvidencia { get; set; }
    }
}
