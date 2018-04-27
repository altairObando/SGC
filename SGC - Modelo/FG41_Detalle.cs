namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG41_Detalle
    {
        [Key]
        public int idFG41Detalle { get; set; }

        public int idArea { get; set; }

        public int id_persona { get; set; }

        [Required]
        [StringLength(1000)]
        public string accionesPropuestas { get; set; }

        public virtual Area Area { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
