namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG02_CConfidencialidad
    {
        [Key]
        public int id_FG02 { get; set; }

        public int id_persona { get; set; }

        public int? idGestion { get; set; }

        public int idTipoVisita { get; set; }

        public bool? otros { get; set; }

        [StringLength(150)]
        public string otrosDescripcion { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual TipoVisita TipoVisita { get; set; }
    }
}
