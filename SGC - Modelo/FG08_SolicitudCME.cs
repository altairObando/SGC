namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG08_SolicitudCME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG08_SolicitudCME()
        {
            FG08Detalle = new HashSet<FG08Detalle>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idFG08 { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaSolicitud { get; set; }

        [Required]
        [StringLength(250)]
        public string justificacion { get; set; }

        public int idGestion { get; set; }

        public int id_persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG08Detalle> FG08Detalle { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
