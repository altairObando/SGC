namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProveedoresCalificados
    {
        [Key]
        public int idProvCalf { get; set; }

        public int idFG18 { get; set; }

        public int idProveedor { get; set; }

        public virtual FG18_ListaProveedores FG18_ListaProveedores { get; set; }

        public virtual Proveedores Proveedores { get; set; }
    }
}
