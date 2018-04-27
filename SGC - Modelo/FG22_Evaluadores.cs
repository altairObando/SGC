namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG22_Evaluadores
    {
        [Key]
        public int idFG22Eval { get; set; }

        public int Persona_id_persona { get; set; }

        public int idFG22 { get; set; }

        public virtual FG22_EvaluacionPeri FG22_EvaluacionPeri { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
