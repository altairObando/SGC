namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG40_Detalle
    {
        [Key]
        public int idFG40Detalle { get; set; }

        public int idFG40 { get; set; }

        [Required]
        [StringLength(1000)]
        public string legislacion { get; set; }

        [Required]
        [StringLength(1000)]
        public string cambionMetodologiaOServicios { get; set; }

        [Required]
        [StringLength(1000)]
        public string cambiosEstructuraUOtros { get; set; }

        [Required]
        [StringLength(1000)]
        public string noHay { get; set; }

        public virtual FG40_CambiosQuePuedanAfectarAllSGC FG40_CambiosQuePuedanAfectarAllSGC { get; set; }
    }
}
