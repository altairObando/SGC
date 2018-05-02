namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG13_ProformaServicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG13_ProformaServicio()
        {
            DetalleFG13 = new List<DetalleFG13>();
        }

        [Key]
        public int idFG13 { get; set; }

        public int idGestion { get; set; }

        public int idCliente { get; set; }

        public int idTipoServicio { get; set; }

        [StringLength(250)]
        public string observaciones { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<DetalleFG13> DetalleFG13 { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual TipoServicio TipoServicio { get; set; }
    }
}
