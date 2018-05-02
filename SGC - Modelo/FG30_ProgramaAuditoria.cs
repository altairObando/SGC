namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG30_ProgramaAuditoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG30_ProgramaAuditoria()
        {
            FG30DetalleAuditoria = new List<FG30DetalleAuditoria>();
        }

        [Key]
        public int idFG30 { get; set; }

        public int idGestion { get; set; }

        public int id_persona { get; set; }

        [Required]
        [StringLength(100)]
        public string objetivo { get; set; }

        [Required]
        [StringLength(100)]
        public string alcance { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_inicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG30DetalleAuditoria> FG30DetalleAuditoria { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
