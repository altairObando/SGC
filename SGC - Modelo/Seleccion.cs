namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seleccion")]
    public partial class Seleccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seleccion()
        {
            EvaluacionCertificados = new List<EvaluacionCertificados>();
            MotivacionInteres = new List<MotivacionInteres>();
            PrestacionServicio = new List<PrestacionServicio>();
            Puntualidad = new List<Puntualidad>();
        }

        [Key]
        public int idSeleccion { get; set; }

        public int idPregunta { get; set; }

        public int idOpcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<EvaluacionCertificados> EvaluacionCertificados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<MotivacionInteres> MotivacionInteres { get; set; }

        public virtual Opcion Opcion { get; set; }

        public virtual Pregunta Pregunta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<PrestacionServicio> PrestacionServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Puntualidad> Puntualidad { get; set; }
    }
}
