namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Riesgos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Riesgos()
        {
            FG05_MatrizDeRiesgos = new HashSet<FG05_MatrizDeRiesgos>();
        }

        [Key]
        public int idRiesgo { get; set; }

        [Required]
        [StringLength(25)]
        public string codigo { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG05_MatrizDeRiesgos> FG05_MatrizDeRiesgos { get; set; }
    }
}
