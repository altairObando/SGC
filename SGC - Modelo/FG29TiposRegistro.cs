namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG29TiposRegistro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG29TiposRegistro()
        {
            FG29_VerificacionControl = new List<FG29_VerificacionControl>();
        }

        [Key]
        public int idTipo { get; set; }

        [Required]
        [StringLength(250)]
        public string tipoRegistro { get; set; }

        public bool permanente { get; set; }

        public int peridoNoPermanente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG29_VerificacionControl> FG29_VerificacionControl { get; set; }
    }
}
