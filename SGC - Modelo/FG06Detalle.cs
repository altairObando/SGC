namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG06Detalle
    {
        [Key]
        public int idFG06Detalle { get; set; }

        public int idFG06 { get; set; }

        [Required]
        [StringLength(100)]
        public string controlGestion { get; set; }

        [Required]
        [StringLength(100)]
        public string controlOperativo { get; set; }

        [Required]
        [StringLength(100)]
        public string responsable { get; set; }

        [Required]
        [StringLength(100)]
        public string periocidicidad { get; set; }

        [Required]
        [StringLength(100)]
        public string indicador { get; set; }

        [Required]
        [StringLength(100)]
        public string riesgoInherente { get; set; }

        public virtual FG06_TratamientoRiesgos FG06_TratamientoRiesgos { get; set; }
    }
}
