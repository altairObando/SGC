namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG36_ReunionCierreAuditoriaInterna
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG36_ReunionCierreAuditoriaInterna()
        {
            FG36Participantes = new HashSet<FG36Participantes>();
        }

        [Key]
        public int id_fg36 { get; set; }

        public int idGestion { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        [Required]
        [StringLength(1500)]
        public string exposicion { get; set; }

        [Required]
        [StringLength(1500)]
        public string presentacion { get; set; }

        [Required]
        [StringLength(500)]
        public string concretar { get; set; }

        [StringLength(500)]
        public string otros { get; set; }

        [Required]
        [StringLength(10)]
        public string conclusiones { get; set; }

        public DateTime horaTerminacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG36Participantes> FG36Participantes { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
