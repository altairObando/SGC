namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstadoGestion")]
    public partial class EstadoGestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstadoGestion()
        {
            Proceso = new List<Proceso>();
        }

        [Key]
        public int idEstadoGestion { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Estado")]
        public string estado { get; set; }
        [Display(Name ="Disponible")]
        public bool disponible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Proceso> Proceso { get; set; }
    }
}
