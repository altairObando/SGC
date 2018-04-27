namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EquiposEntrega")]
    public partial class EquiposEntrega
    {
        [Key]
        public int idEquiposEntrega { get; set; }

        public int? idFG12 { get; set; }

        public int? idEquipo { get; set; }

        public virtual Equipo Equipo { get; set; }

        public virtual FG12_EntregaEquipos FG12_EntregaEquipos { get; set; }
    }
}
