namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG19_SeguimientoControl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG19_SeguimientoControl()
        {
            FG19_Detalle = new HashSet<FG19_Detalle>();
            FG20_ReclamoProveedor = new HashSet<FG20_ReclamoProveedor>();
        }

        [Key]
        public int idFG19 { get; set; }

        [Required]
        [StringLength(25)]
        public string noFactura { get; set; }

        public int idGestion { get; set; }

        public int idProveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG19_Detalle> FG19_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG20_ReclamoProveedor> FG20_ReclamoProveedor { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Proveedores Proveedores { get; set; }
    }
}
