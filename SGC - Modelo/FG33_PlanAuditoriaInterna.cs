namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG33_PlanAuditoriaInterna
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG33_PlanAuditoriaInterna()
        {
            Evaluadores = new HashSet<Evaluadores>();
            FG33Detalle = new HashSet<FG33Detalle>();
        }

        [Key]
        public int idFG33PlanAuditoria { get; set; }

        public int idGestion { get; set; }

        [Required]
        [StringLength(150)]
        public string objetivo { get; set; }

        [Required]
        [StringLength(150)]
        public string criterio { get; set; }

        [Required]
        [StringLength(150)]
        public string alcance { get; set; }

        [Required]
        [StringLength(50)]
        public string cliclo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluadores> Evaluadores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG33Detalle> FG33Detalle { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
