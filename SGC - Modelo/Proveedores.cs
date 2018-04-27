namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proveedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedores()
        {
            FG19_SeguimientoControl = new HashSet<FG19_SeguimientoControl>();
            FG21_EvaluacionInicial = new HashSet<FG21_EvaluacionInicial>();
            FG22_EvaluacionPeri = new HashSet<FG22_EvaluacionPeri>();
            ProveedoresCalificados = new HashSet<ProveedoresCalificados>();
        }

        [Key]
        public int idProveedor { get; set; }

        [Required]
        [StringLength(100)]
        public string productoServicio { get; set; }

        [Required]
        [StringLength(100)]
        public string direccion { get; set; }

        [Required]
        [StringLength(20)]
        public string telefono { get; set; }

        [Required]
        [StringLength(100)]
        public string nombreContacto { get; set; }

        [Required]
        [StringLength(150)]
        public string email { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaIngreso { get; set; }

        public bool proveedorCalificado { get; set; }

        public bool activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG19_SeguimientoControl> FG19_SeguimientoControl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG21_EvaluacionInicial> FG21_EvaluacionInicial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG22_EvaluacionPeri> FG22_EvaluacionPeri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProveedoresCalificados> ProveedoresCalificados { get; set; }
    }
}
