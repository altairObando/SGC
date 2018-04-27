namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG14_CalibracionDosimetrica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG14_CalibracionDosimetrica()
        {
            FG14Servicios = new HashSet<FG14Servicios>();
        }

        [Key]
        public int idFG14 { get; set; }

        public int idGestion { get; set; }

        public int idCliente { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaProgramacion { get; set; }

        public bool formaPago { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG14Servicios> FG14Servicios { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
