namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG37_InformeAuditoriaInterna
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG37_InformeAuditoriaInterna()
        {
            FG37Participantes = new List<FG37Participantes>();
        }

        [Key]
        public int idFG37 { get; set; }

        public int idGestion { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public DateTime hora { get; set; }

        [Required]
        [StringLength(250)]
        public string alcance { get; set; }

        [Required]
        [StringLength(250)]
        public string objetivo { get; set; }

        [Required]
        [StringLength(250)]
        public string referenciaNormativa { get; set; }

        [Required]
        [StringLength(500)]
        public string observaciones { get; set; }

        [Required]
        [StringLength(500)]
        public string noConformidades { get; set; }

        [Required]
        [StringLength(500)]
        public string conclusiones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG37Participantes> FG37Participantes { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
