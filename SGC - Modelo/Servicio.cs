namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Servicio")]
    public partial class Servicio
    {
        [Key]
        public int idServicio { get; set; }

        public int idCliente { get; set; }

        public int? idProceso { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Proceso Proceso { get; set; }
    }
}
