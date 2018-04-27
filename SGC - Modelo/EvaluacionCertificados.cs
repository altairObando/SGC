namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EvaluacionCertificados
    {
        [Key]
        public int idEvaluacion { get; set; }

        public int idFG23 { get; set; }

        public int idSeleccion { get; set; }

        public int idSatifaccion { get; set; }

        public virtual FG23_SatisfaccionCliente FG23_SatisfaccionCliente { get; set; }

        public virtual Satisfactorio Satisfactorio { get; set; }

        public virtual Seleccion Seleccion { get; set; }
    }
}
