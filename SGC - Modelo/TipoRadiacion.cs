namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoRadiacion")]
    public partial class TipoRadiacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoRadiacion()
        {
            ClienteRadiacion = new List<ClienteRadiacion>();
            FG10Radiaciones = new List<FG10Radiaciones>();
        }

        [Key]
        public int idTipoRadiacion { get; set; }

        [Required]
        [StringLength(50)]
        public string tipo { get; set; }

        public bool activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<ClienteRadiacion> ClienteRadiacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG10Radiaciones> FG10Radiaciones { get; set; }
    }
}
