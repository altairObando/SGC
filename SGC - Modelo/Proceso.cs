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
            Gestion = new List<Gestion>();
            Involucrado = new List<Involucrado>();
        }

        [Key]
        public int idProceso { get; set; }

        public int? idEstadoGestion { get; set; }

        public int? idCliente { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Text)]
        [Display(Name ="Fecha de Inicio")]    
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:dd/MM/yy}")]    
        public DateTime fechaInicio { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Text)]
        [Display(Name = "Fecha de Fin")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yy}")]
        public DateTime? fechaFin { get; set; }

        [Display(Name ="Anulado")]
        public bool anulado { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual EstadoGestion EstadoGestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Gestion> Gestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Involucrado> Involucrado { get; set; }
    }
}
