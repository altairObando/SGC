namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG36Participantes
    {
        [Key]
        public int idFG36Participantes { get; set; }

        public int id_fg36 { get; set; }

        public int id_persona { get; set; }

        public virtual FG36_ReunionCierreAuditoriaInterna FG36_ReunionCierreAuditoriaInterna { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
