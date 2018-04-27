namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MotivacionInteres
    {
        [Key]
        public int idMotivacion { get; set; }

        public int idFG23 { get; set; }

        public int idSeleccion { get; set; }

        public virtual FG23_SatisfaccionCliente FG23_SatisfaccionCliente { get; set; }

        public virtual Seleccion Seleccion { get; set; }
    }
}
