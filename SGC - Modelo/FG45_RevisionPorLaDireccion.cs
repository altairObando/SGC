namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG45_RevisionPorLaDireccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG45_RevisionPorLaDireccion()
        {
            FG45_Participantes = new List<FG45_Participantes>();
        }

        [Key]
        public int idFG45 { get; set; }

        public int idGestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG45_Participantes> FG45_Participantes { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
