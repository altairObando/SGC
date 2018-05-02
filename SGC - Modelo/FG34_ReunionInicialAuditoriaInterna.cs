namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG34_ReunionInicialAuditoriaInterna
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG34_ReunionInicialAuditoriaInterna()
        {
            FG34Participantes = new List<FG34Participantes>();
        }

        [Key]
        public int idFG34 { get; set; }

        [Required]
        [StringLength(1000)]
        public string objetivos { get; set; }

        [Required]
        [StringLength(100)]
        public string alcance { get; set; }

        [Required]
        [StringLength(1000)]
        public string acuerdos { get; set; }

        public int idPersonaLaboratorio { get; set; }

        public int idGestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG34Participantes> FG34Participantes { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual PersonaLaboratorio PersonaLaboratorio { get; set; }
    }
}
