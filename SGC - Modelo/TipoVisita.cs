namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoVisita")]
    public partial class TipoVisita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoVisita()
        {
            FG02_CConfidencialidad = new List<FG02_CConfidencialidad>();
        }

        [Key]
        public int idTipoVisita { get; set; }

        [Required]
        [StringLength(25)]
        public string descripcion { get; set; }

        public bool activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG02_CConfidencialidad> FG02_CConfidencialidad { get; set; }
    }
}
