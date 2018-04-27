namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Evaluadores
    {
        [Key]
        public int idEvaluador { get; set; }

        public int idFG33PlanAuditoria { get; set; }

        public int id_persona { get; set; }

        public virtual FG33_PlanAuditoriaInterna FG33_PlanAuditoriaInterna { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
