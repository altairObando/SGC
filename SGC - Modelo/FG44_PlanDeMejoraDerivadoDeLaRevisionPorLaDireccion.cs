namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion()
        {
            FG44_Detalles = new HashSet<FG44_Detalles>();
            FG44_Participantes = new HashSet<FG44_Participantes>();
        }

        [Key]
        public int idFG44 { get; set; }

        public int idGestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG44_Detalles> FG44_Detalles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG44_Participantes> FG44_Participantes { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
