namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG26_AtencionReclamos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG26_AtencionReclamos()
        {
            FG26_Acciones = new List<FG26_Acciones>();
        }

        [Key]
        public int idFG26 { get; set; }

        public int idGestion { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        [Required]
        [StringLength(250)]
        public string generadoPor { get; set; }

        [Required]
        [StringLength(250)]
        public string identificadoPor { get; set; }

        [Required]
        [StringLength(50)]
        public string docInvolucrado { get; set; }

        [Required]
        [StringLength(250)]
        public string descripcion { get; set; }

        [Required]
        [StringLength(250)]
        public string causa { get; set; }

        [Required]
        [StringLength(250)]
        public string efecto { get; set; }

        [Required]
        [StringLength(100)]
        public string recibidoPor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG26_Acciones> FG26_Acciones { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
