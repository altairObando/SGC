namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG14Servicios
    {
        [Key]
        public int idServicio { get; set; }

        public int idFG14 { get; set; }

        public int item { get; set; }

        public int? cantidad { get; set; }

        public decimal precioUnitario { get; set; }

        public virtual FG14_CalibracionDosimetrica FG14_CalibracionDosimetrica { get; set; }
    }
}
