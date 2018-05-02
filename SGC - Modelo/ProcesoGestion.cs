namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcesoGestion")]
    public partial class ProcesoGestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcesoGestion()
        {
            FormatoGestion = new List<FormatoGestion>();
        }

        [Key]
        public int idProceso { get; set; }

        [Required]
        [StringLength(20)]
        public string codigoProceso { get; set; }

        [Required]
        [StringLength(150)]
        public string significado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FormatoGestion> FormatoGestion { get; set; }
    }
}
