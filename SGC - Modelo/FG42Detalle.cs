namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG42Detalle
    {
        [Key]
        public int idFG42Detalle { get; set; }

        public int idFG42 { get; set; }

        public int idEstados { get; set; }

        public int id_persona { get; set; }

        [Required]
        [StringLength(10)]
        public string compromisosEstablecidos { get; set; }

        [Required]
        [StringLength(10)]
        public string observaciones { get; set; }

        public virtual FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia { get; set; }

        public virtual FG42_Estados FG42_Estados { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
