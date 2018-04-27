namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG15_Especificaciones
    {
        [Key]
        public int idFG15Espec { get; set; }

        public int idFG15 { get; set; }

        public int idEquipo { get; set; }

        public int cantidad { get; set; }

        public double precioUnitario { get; set; }

        public virtual Equipo Equipo { get; set; }

        public virtual FG15ControlServicioCalidad FG15ControlServicioCalidad { get; set; }
    }
}
