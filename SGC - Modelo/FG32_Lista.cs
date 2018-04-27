namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG32_Lista
    {
        [Key]
        public int idFG32Lista { get; set; }

        public int idFG32 { get; set; }

        public bool cumple { get; set; }

        [StringLength(250)]
        public string observaciones { get; set; }

        public virtual FG32_ListaVerificacion FG32_ListaVerificacion { get; set; }
    }
}
