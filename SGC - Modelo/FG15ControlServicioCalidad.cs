namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG15ControlServicioCalidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG15ControlServicioCalidad()
        {
            FG15_Especificaciones = new HashSet<FG15_Especificaciones>();
            FG16_Contrato = new HashSet<FG16_Contrato>();
        }

        [Key]
        public int idFG15 { get; set; }

        public int idGestion { get; set; }

        public int idCliente { get; set; }

        public bool formaPago { get; set; }

        [Required]
        [StringLength(100)]
        public string comentarios { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG15_Especificaciones> FG15_Especificaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG16_Contrato> FG16_Contrato { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
