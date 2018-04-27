namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG38_CumplimientoDeObjetivos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG38_CumplimientoDeObjetivos()
        {
            FG38_Detalle = new HashSet<FG38_Detalle>();
            FG38_Involucrados = new HashSet<FG38_Involucrados>();
        }

        [Key]
        public int idFG38 { get; set; }

        public int idGestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG38_Detalle> FG38_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG38_Involucrados> FG38_Involucrados { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
