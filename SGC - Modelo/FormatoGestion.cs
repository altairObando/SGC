namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormatoGestion")]
    public partial class FormatoGestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormatoGestion()
        {
            FormatoPlantilla = new HashSet<FormatoPlantilla>();
        }

        [Key]
        public int idCodigoFG { get; set; }

        public int idProceso { get; set; }

        [Required]
        [StringLength(10)]
        public string codigo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormatoPlantilla> FormatoPlantilla { get; set; }

        public virtual ProcesoGestion ProcesoGestion { get; set; }
    }
}
