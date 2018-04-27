namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG31_Criterio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG31_Criterio()
        {
            FG31_Evaluacion = new HashSet<FG31_Evaluacion>();
        }

        [Key]
        public int idCriterio { get; set; }

        public int idF31Requisitos { get; set; }

        [Required]
        [StringLength(100)]
        public string criterio { get; set; }

        public bool disponible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG31_Evaluacion> FG31_Evaluacion { get; set; }

        public virtual FG31_Requisitos FG31_Requisitos { get; set; }
    }
}
