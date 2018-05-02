namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarcaInstrumento")]
    public partial class MarcaInstrumento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MarcaInstrumento()
        {
            Equipo = new List<Equipo>();
        }

        [Key]
        public int idMarcaInstrumento { get; set; }

        [Column("marcaInstrumento")]
        [Required]
        [StringLength(30)]
        public string marcaInstrumento1 { get; set; }

        public bool activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Equipo> Equipo { get; set; }
    }
}
