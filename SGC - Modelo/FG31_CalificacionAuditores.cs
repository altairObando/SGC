namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG31_CalificacionAuditores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG31_CalificacionAuditores()
        {
            FG31_Evaluacion = new List<FG31_Evaluacion>();
        }

        [Key]
        public int idFG31 { get; set; }

        public int idGestion { get; set; }

        public int id_persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG31_Evaluacion> FG31_Evaluacion { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
