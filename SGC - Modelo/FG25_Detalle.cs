namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG25_Detalle
    {
        [Key]
        public int idFG25Detalle { get; set; }

        public int idFG25 { get; set; }

        public int id_persona { get; set; }

        [Required]
        [StringLength(50)]
        public string causas { get; set; }

        [Required]
        [StringLength(50)]
        public string acciones { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaEjecucion { get; set; }

        public virtual FG25_AtencionReclamos FG25_AtencionReclamos { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
