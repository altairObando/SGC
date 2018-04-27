namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG09_ControlCambios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG09_ControlCambios()
        {
            FG09HistoricoCambios = new HashSet<FG09HistoricoCambios>();
        }

        [Key]
        [StringLength(10)]
        public string IdFG09 { get; set; }

        public int idGestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG09HistoricoCambios> FG09HistoricoCambios { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
