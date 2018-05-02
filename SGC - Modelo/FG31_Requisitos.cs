namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG31_Requisitos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG31_Requisitos()
        {
            FG31_Criterio = new List<FG31_Criterio>();
        }

        [Key]
        public int idF31Requisitos { get; set; }

        [Required]
        [StringLength(50)]
        public string tituloRequisito { get; set; }

        public double ponderaje { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG31_Criterio> FG31_Criterio { get; set; }
    }
}
