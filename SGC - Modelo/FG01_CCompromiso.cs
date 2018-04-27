namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG01_CCompromiso
    {
        [Key]
        public int idFG01 { get; set; }

        public int idGestion { get; set; }

        public int id_persona { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
