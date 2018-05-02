namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModeloEquipo")]
    public partial class ModeloEquipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModeloEquipo()
        {
            Equipo = new List<Equipo>();
        }

        [Key]
        public int idModeloEquipo { get; set; }

        [Column("modeloEquipo")]
        [StringLength(25)]
        public string modeloEquipo1 { get; set; }

        public bool acivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Equipo> Equipo { get; set; }
    }
}
