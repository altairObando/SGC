namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstadoSolicitud")]
    public partial class EstadoSolicitud
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstadoSolicitud()
        {
            FG10Estados = new List<FG10Estados>();
        }

        [Key]
        public int idEstadoSolicitud { get; set; }

        [Required]
        [StringLength(25)]
        public string estado { get; set; }

        public bool activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG10Estados> FG10Estados { get; set; }
    }
}
