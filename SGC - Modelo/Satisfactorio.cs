namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Satisfactorio")]
    public partial class Satisfactorio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Satisfactorio()
        {
            EvaluacionCertificados = new List<EvaluacionCertificados>();
            PrestacionServicio = new List<PrestacionServicio>();
            Puntualidad = new List<Puntualidad>();
        }

        [Key]
        public int idSatifaccion { get; set; }

        public bool satisfecho { get; set; }

        [StringLength(10)]
        public string explicacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<EvaluacionCertificados> EvaluacionCertificados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<PrestacionServicio> PrestacionServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Puntualidad> Puntualidad { get; set; }
    }
}
