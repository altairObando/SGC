namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Equipo")]
    public partial class Equipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipo()
        {
            FG15_Especificaciones = new HashSet<FG15_Especificaciones>();
            EquiposEntrega = new HashSet<EquiposEntrega>();
        }

        [Key]
        public int idEquipo { get; set; }

        [Required]
        [StringLength(30)]
        public string noSerie { get; set; }

        public int idTipoEquipo { get; set; }

        public int idFabricanteEquipo { get; set; }

        public int idModeloEquipo { get; set; }

        public int idMarcaInstrumento { get; set; }

        [StringLength(500)]
        public string especificaciones { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaFabricacion { get; set; }

        [Required]
        [StringLength(200)]
        public string ubicacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG15_Especificaciones> FG15_Especificaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquiposEntrega> EquiposEntrega { get; set; }

        public virtual fabricanteEquipo fabricanteEquipo { get; set; }

        public virtual MarcaInstrumento MarcaInstrumento { get; set; }

        public virtual ModeloEquipo ModeloEquipo { get; set; }

        public virtual TipoEquipo TipoEquipo { get; set; }
    }
}
