namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG25_AtencionReclamos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG25_AtencionReclamos()
        {
            FG25_Detalle = new List<FG25_Detalle>();
        }

        [Key]
        public int idFG25 { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        [Required]
        [StringLength(250)]
        public string detalleReclamo { get; set; }

        [Required]
        [StringLength(100)]
        public string solucion { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        public bool cerrado { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaCierre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG25_Detalle> FG25_Detalle { get; set; }
    }
}
