namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG30CriteriosAuditoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG30CriteriosAuditoria()
        {
            FG30DetalleAuditoria = new HashSet<FG30DetalleAuditoria>();
        }

        [Key]
        public int idCriterio { get; set; }

        [Required]
        [StringLength(100)]
        public string criterio { get; set; }

        public bool disponible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG30DetalleAuditoria> FG30DetalleAuditoria { get; set; }
    }
}
