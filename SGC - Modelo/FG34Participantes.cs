namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG34Participantes
    {
        [Key]
        public int idFG34Participante { get; set; }

        public int idFG34 { get; set; }

        public int id_persona { get; set; }

        public virtual FG34_ReunionInicialAuditoriaInterna FG34_ReunionInicialAuditoriaInterna { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
