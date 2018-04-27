namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proceso")]
    public partial class Proceso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proceso()
        {
            Gestion = new HashSet<Gestion>();
            Involucrado = new HashSet<Involucrado>();
            Servicio = new HashSet<Servicio>();
        }

        [Key]
        public int idProceso { get; set; }

        [Display(Name ="Estado")]
        public int? idEstadoGestion { get; set; }

        [Column(TypeName = "date")]
        [Display(Name ="Fecha Inicio")]
        public DateTime fechaInicio { get; set; }

        [Column(TypeName = "date")]
        [Display(Name ="Finalizado")]
        public DateTime? fechaFin { get; set; }

        [Display(Name = "Proceso Anulado")]
        public bool anulado { get; set; }
        [NotMapped]
        public int Documentos {
            get { return Gestion.Count; }
        }
        public virtual EstadoGestion EstadoGestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gestion> Gestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Involucrado> Involucrado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicio> Servicio { get; set; }
    }
}
