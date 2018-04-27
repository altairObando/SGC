namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClienteRadiacion")]
    public partial class ClienteRadiacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idClienteRadiacion { get; set; }

        public int idCliente { get; set; }

        public int idTipoRadiacion { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual TipoRadiacion TipoRadiacion { get; set; }
    }
}
