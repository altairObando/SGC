namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG21_Evaluadores
    {
        [Key]
        public int idFG21Ev { get; set; }

        public int idFG21 { get; set; }

        public int id_persona { get; set; }

        public virtual FG21_EvaluacionInicial FG21_EvaluacionInicial { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
