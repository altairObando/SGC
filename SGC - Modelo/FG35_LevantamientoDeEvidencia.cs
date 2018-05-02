namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG35_LevantamientoDeEvidencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG35_LevantamientoDeEvidencia()
        {
            FG35_hallazgos = new List<FG35_hallazgos>();
            Involucrados = new List<Involucrados>();
        }

        [Key]
        public int idFG35 { get; set; }

        public int idGestion { get; set; }

        public int idPersonaLaboratorio { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public DateTime hora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG35_hallazgos> FG35_hallazgos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Involucrados> Involucrados { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual PersonaLaboratorio PersonaLaboratorio { get; set; }
    }
}
