namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TiposConflicto")]
    public partial class TiposConflicto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TiposConflicto()
        {
            FG04_ConflictoInteres = new HashSet<FG04_ConflictoInteres>();
        }

        [Key]
        public int idTipoConflicto { get; set; }

        [Required]
        [StringLength(250)]
        public string descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG04_ConflictoInteres> FG04_ConflictoInteres { get; set; }
    }
}
