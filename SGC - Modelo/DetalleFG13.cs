namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DetalleFG13
    {
        [Key]
        [StringLength(10)]
        public string idDetalle { get; set; }

        public int idFG13 { get; set; }

        public int cantidad { get; set; }

        public double costoUnidad { get; set; }

        public virtual FG13_ProformaServicio FG13_ProformaServicio { get; set; }
    }
}
