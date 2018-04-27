namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG44_Participantes
    {
        [Key]
        public int idFG44Participantes { get; set; }

        public int id_persona { get; set; }

        public int idFG44 { get; set; }

        public virtual FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
