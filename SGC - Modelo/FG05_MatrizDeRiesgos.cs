namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG05_MatrizDeRiesgos
    {
        [Key]
        public int idFG05 { get; set; }

        public int? idGestion { get; set; }

        public int idRiesgo { get; set; }

        [StringLength(100)]
        public string analisisCausa { get; set; }

        [StringLength(100)]
        public string efecto { get; set; }

        [StringLength(1000)]
        public string importancia { get; set; }

        [StringLength(1000)]
        public string probalbilidad { get; set; }

        [StringLength(1000)]
        public string impacto { get; set; }

        [StringLength(100)]
        public string nivel { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Riesgos Riesgos { get; set; }
    }
}
