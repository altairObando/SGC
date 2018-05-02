namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoEquipo")]
    public partial class TipoEquipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoEquipo()
        {
            Equipo = new List<Equipo>();
        }

        [Key]
        public int idTipoEquipo { get; set; }

        [Column("tipoEquipo")]
        [Required]
        [StringLength(25)]
        public string tipoEquipo1 { get; set; }

        public bool activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Equipo> Equipo { get; set; }
    }
}
