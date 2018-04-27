namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG45_Participantes
    {
        [Key]
        public int idFG45Participantes { get; set; }

        public int idFG45 { get; set; }

        public int id_persona { get; set; }

        public virtual FG45_RevisionPorLaDireccion FG45_RevisionPorLaDireccion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
