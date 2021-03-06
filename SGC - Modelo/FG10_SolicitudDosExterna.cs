namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG10_SolicitudDosExterna
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG10_SolicitudDosExterna()
        {
            FG10Portadores = new List<FG10Portadores>();
            FG10Radiaciones = new List<FG10Radiaciones>();
            FG10Estados = new List<FG10Estados>();
            Representante = new List<Representante>();
            FG11_AcuerdoServicio = new List<FG11_AcuerdoServicio>();
        }

        [Key]
        public int idFG10 { get; set; }

        public int idGestion { get; set; }

        public int idCliente { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG10Portadores> FG10Portadores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG10Radiaciones> FG10Radiaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG10Estados> FG10Estados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Representante> Representante { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG11_AcuerdoServicio> FG11_AcuerdoServicio { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
