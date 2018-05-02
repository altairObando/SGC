namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG03_ConflictoInteres
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG03_ConflictoInteres()
        {
            Actividades = new List<Actividades>();
            Consanguiniedad = new List<Consanguiniedad>();
        }

        [Key]
        public int idFG03 { get; set; }

        public int idGestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Actividades> Actividades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Consanguiniedad> Consanguiniedad { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
