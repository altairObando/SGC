namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG27_TiposImplementacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG27_TiposImplementacion()
        {
            FG27_TrabajosNoConformes = new HashSet<FG27_TrabajosNoConformes>();
        }

        [Key]
        public int idTipoImplementacion { get; set; }

        [Required]
        [StringLength(50)]
        public string tipoImplementacion { get; set; }

        public bool? activa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG27_TrabajosNoConformes> FG27_TrabajosNoConformes { get; set; }
    }
}
