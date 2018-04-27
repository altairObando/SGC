namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG16_Contrato
    {
        [Key]
        public int idFG16 { get; set; }

        public int idCliente { get; set; }

        public int idGestion { get; set; }

        public int? idFG15 { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual FG15ControlServicioCalidad FG15ControlServicioCalidad { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
