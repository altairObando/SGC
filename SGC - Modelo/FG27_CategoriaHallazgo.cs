namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG27_CategoriaHallazgo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG27_CategoriaHallazgo()
        {
            FG27_TrabajosNoConformes = new List<FG27_TrabajosNoConformes>();
        }

        [Key]
        public int idCategoria { get; set; }

        [Required]
        [StringLength(60)]
        public string descripcion { get; set; }

        public bool? activa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG27_TrabajosNoConformes> FG27_TrabajosNoConformes { get; set; }
    }
}
