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
            EvaluacionCertificados = new HashSet<EvaluacionCertificados>();
            MotivacionInteres = new HashSet<MotivacionInteres>();
            PrestacionServicio = new HashSet<PrestacionServicio>();
            Puntualidad = new HashSet<Puntualidad>();
        }

        [Key]
        public int idSeleccion { get; set; }

        public int idPregunta { get; set; }

        public int idOpcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvaluacionCertificados> EvaluacionCertificados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MotivacionInteres> MotivacionInteres { get; set; }

        public virtual Opcion Opcion { get; set; }

        public virtual Pregunta Pregunta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrestacionServicio> PrestacionServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Puntualidad> Puntualidad { get; set; }
    }
}
