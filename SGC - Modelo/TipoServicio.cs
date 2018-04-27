namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoServicio")]
    public partial class TipoServicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoServicio()
        {
            FG13_ProformaServicio = new HashSet<FG13_ProformaServicio>();
        }

        [Key]
        public int idTipoServicio { get; set; }

        [Required]
        [StringLength(250)]
        public string tipo_servicio { get; set; }

        public bool activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG13_ProformaServicio> FG13_ProformaServicio { get; set; }
    }
}
