namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG37Participantes
    {
        [Key]
        public int idFG37Participantes { get; set; }

        public int idFG37 { get; set; }

        public int id_persona { get; set; }

        public virtual FG37_InformeAuditoriaInterna FG37_InformeAuditoriaInterna { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
