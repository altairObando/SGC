namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            FG14_CalibracionDosimetrica = new HashSet<FG14_CalibracionDosimetrica>();
            FG15ControlServicioCalidad = new HashSet<FG15ControlServicioCalidad>();
            FG16_Contrato = new HashSet<FG16_Contrato>();
            FG17_ContratoPorIncorporacion = new HashSet<FG17_ContratoPorIncorporacion>();
            Servicio = new HashSet<Servicio>();
            ClienteRadiacion = new HashSet<ClienteRadiacion>();
            FG10_SolicitudDosExterna = new HashSet<FG10_SolicitudDosExterna>();
            FG12_EntregaEquipos = new HashSet<FG12_EntregaEquipos>();
            FG13_ProformaServicio = new HashSet<FG13_ProformaServicio>();
        }

        [Key]
        public int idCliente { get; set; }

        public int idTipoCliente { get; set; }

        [Required]
        [StringLength(75)]
        public string nombreInstitucion { get; set; }

        [Required]
        [StringLength(150)]
        public string direccion { get; set; }

        [Required]
        [StringLength(15)]
        public string telefono { get; set; }

        [Required]
        [StringLength(20)]
        public string codigoMinsa { get; set; }

        [Required]
        [StringLength(100)]
        public string ciudad { get; set; }

        [StringLength(25)]
        public string ruc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG14_CalibracionDosimetrica> FG14_CalibracionDosimetrica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG15ControlServicioCalidad> FG15ControlServicioCalidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG16_Contrato> FG16_Contrato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG17_ContratoPorIncorporacion> FG17_ContratoPorIncorporacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicio> Servicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteRadiacion> ClienteRadiacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG10_SolicitudDosExterna> FG10_SolicitudDosExterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG12_EntregaEquipos> FG12_EntregaEquipos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG13_ProformaServicio> FG13_ProformaServicio { get; set; }

        public virtual TipoCliente TipoCliente { get; set; }
    }
}
