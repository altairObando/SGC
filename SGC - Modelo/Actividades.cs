namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Actividades
    {
        [Key]
        public int idActividad { get; set; }

        public int idFG03 { get; set; }

        [Required]
        [StringLength(150)]
        public string Actividad { get; set; }

        [Required]
        [StringLength(150)]
        public string Organizacion { get; set; }

        [Required]
        [StringLength(150)]
        public string Relacion { get; set; }

        public virtual FG03_ConflictoInteres FG03_ConflictoInteres { get; set; }
    }
}
