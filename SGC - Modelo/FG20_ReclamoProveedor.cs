namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG20_ReclamoProveedor
    {
        [Key]
        public int idFG20 { get; set; }

        public int idGestion { get; set; }

        public int idFG19 { get; set; }

        [Column(TypeName = "date")]
        public DateTime fenvarchareclamo { get; set; }

        [Required]
        [StringLength(300)]
        public string detalleReclamo { get; set; }

        [StringLength(300)]
        public string observaciones { get; set; }

        public int tipo { get; set; }

        public virtual FG19_SeguimientoControl FG19_SeguimientoControl { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
