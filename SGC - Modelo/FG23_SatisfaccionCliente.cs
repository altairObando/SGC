namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG23_SatisfaccionCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG23_SatisfaccionCliente()
        {
            EvaluacionCertificados = new List<EvaluacionCertificados>();
            PrestacionServicio = new List<PrestacionServicio>();
            Puntualidad = new List<Puntualidad>();
            MotivacionInteres = new List<MotivacionInteres>();
        }

        [Key]
        public int idFG23 { get; set; }

        public int idGestion { get; set; }

        [StringLength(300)]
        public string opcional { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<EvaluacionCertificados> EvaluacionCertificados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<PrestacionServicio> PrestacionServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Puntualidad> Puntualidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<MotivacionInteres> MotivacionInteres { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
