namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG17_ContratoPorIncorporacion
    {
        [Key]
        public int idFG17 { get; set; }

        public int idCliente { get; set; }

        public int idGestion { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
