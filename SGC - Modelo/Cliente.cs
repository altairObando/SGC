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
            FG14_CalibracionDosimetrica = new List<FG14_CalibracionDosimetrica>();
            FG15ControlServicioCalidad = new List<FG15ControlServicioCalidad>();
            FG16_Contrato = new List<FG16_Contrato>();
            FG17_ContratoPorIncorporacion = new List<FG17_ContratoPorIncorporacion>();
            Proceso = new List<Proceso>();
            ClienteRadiacion = new List<ClienteRadiacion>();
            FG10_SolicitudDosExterna = new List<FG10_SolicitudDosExterna>();
            FG12_EntregaEquipos = new List<FG12_EntregaEquipos>();
            FG13_ProformaServicio = new List<FG13_ProformaServicio>();
        }

        [Key]
        public int idCliente { get; set; }

        public int idTipoCliente { get; set; }

        [Required]
        [StringLength(75)]
        [Display(Name = "Institución")]
        public string nombreInstitucion { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name ="Dirección")]
        public string direccion { get; set; }

        [Required]
        [StringLength(15)]
        [Phone]
        [Display(Name ="Telefono")]
        public string telefono { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name ="Cod. Minsa")]
        public string codigoMinsa { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Ciudad")]
        public string ciudad { get; set; }

        [StringLength(25)]
        [Display(Name ="Numero RUC")]
        public string ruc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG14_CalibracionDosimetrica> FG14_CalibracionDosimetrica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG15ControlServicioCalidad> FG15ControlServicioCalidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG16_Contrato> FG16_Contrato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG17_ContratoPorIncorporacion> FG17_ContratoPorIncorporacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Proceso> Proceso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<ClienteRadiacion> ClienteRadiacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG10_SolicitudDosExterna> FG10_SolicitudDosExterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG12_EntregaEquipos> FG12_EntregaEquipos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG13_ProformaServicio> FG13_ProformaServicio { get; set; }

        public virtual TipoCliente TipoCliente { get; set; }
    }
}
