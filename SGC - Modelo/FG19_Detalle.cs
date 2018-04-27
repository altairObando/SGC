namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG19_Detalle
    {
        [Key]
        public int idFG19Detalle { get; set; }

        public int idFG19 { get; set; }

        [Required]
        [StringLength(25)]
        public string prodServicio { get; set; }

        [Required]
        [StringLength(25)]
        public string especificaciones { get; set; }

        public int cantidad { get; set; }

        [Required]
        [StringLength(50)]
        public string observaciones { get; set; }

        public virtual FG19_SeguimientoControl FG19_SeguimientoControl { get; set; }
    }
}
