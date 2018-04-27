namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG10Portadores
    {
        [Key]
        public int idFG10Portador { get; set; }

        public int idFG10 { get; set; }

        [Required]
        [StringLength(50)]
        public string nombreCompleto { get; set; }

        [Required]
        [StringLength(1)]
        public string sexo { get; set; }

        [Required]
        [StringLength(16)]
        public string cedula { get; set; }

        [Required]
        [StringLength(20)]
        public string cargo { get; set; }

        public virtual FG10_SolicitudDosExterna FG10_SolicitudDosExterna { get; set; }
    }
}
