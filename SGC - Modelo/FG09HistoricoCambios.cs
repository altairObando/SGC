namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG09HistoricoCambios
    {
        [Key]
        public int idFG09Historico { get; set; }

        public int? idFG08Detalle { get; set; }

        public int? idFormato { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaCambio { get; set; }

        [Required]
        [StringLength(10)]
        public string IdFG09 { get; set; }

        public virtual FG08Detalle FG08Detalle { get; set; }

        public virtual FG09_ControlCambios FG09_ControlCambios { get; set; }

        public virtual FormatoPlantilla FormatoPlantilla { get; set; }
    }
}
