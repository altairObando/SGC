namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG38_Detalle
    {
        [Key]
        public int idFG38Detalle { get; set; }

        public int idFG38 { get; set; }

        [Required]
        [StringLength(150)]
        public string Objetivos { get; set; }

        [Required]
        [StringLength(10)]
        public string ValorActual { get; set; }

        [Required]
        [StringLength(1000)]
        public string Metas { get; set; }

        [Required]
        [StringLength(1000)]
        public string observaciones { get; set; }

        public virtual FG38_CumplimientoDeObjetivos FG38_CumplimientoDeObjetivos { get; set; }
    }
}
