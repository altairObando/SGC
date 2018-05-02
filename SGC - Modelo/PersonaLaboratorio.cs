namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonaLaboratorio")]
    public partial class PersonaLaboratorio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonaLaboratorio()
        {
            FG34_ReunionInicialAuditoriaInterna = new List<FG34_ReunionInicialAuditoriaInterna>();
            FG35_LevantamientoDeEvidencia = new List<FG35_LevantamientoDeEvidencia>();
        }

        [Key]
        public int idPersonaLaboratorio { get; set; }

        public int idLaboratorio { get; set; }

        public int id_persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG34_ReunionInicialAuditoriaInterna> FG34_ReunionInicialAuditoriaInterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG35_LevantamientoDeEvidencia> FG35_LevantamientoDeEvidencia { get; set; }

        public virtual Laboratorio Laboratorio { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
