namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FormatoPlantilla")]
    public partial class FormatoPlantilla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormatoPlantilla()
        {
            FG08Detalle = new HashSet<FG08Detalle>();
            FG09HistoricoCambios = new HashSet<FG09HistoricoCambios>();
            Gestion = new HashSet<Gestion>();
        }

        [Key]
        public int idFormato { get; set; }

        public int idCodigoFG { get; set; }

        [Required]
        [StringLength(150)]
        public string titulo { get; set; }

        [Required]
        public string cuerpoDocumento { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaCreacion { get; set; }

        public double version { get; set; }

        public bool obsoleto { get; set; }

        public bool solicitudCambio { get; set; }

        public bool activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG08Detalle> FG08Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG09HistoricoCambios> FG09HistoricoCambios { get; set; }

        public virtual FormatoGestion FormatoGestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gestion> Gestion { get; set; }
    }
}
