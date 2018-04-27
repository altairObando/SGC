namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG32_ListaVerificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG32_ListaVerificacion()
        {
            FG32_Lista = new HashSet<FG32_Lista>();
        }

        [Key]
        public int idFG32 { get; set; }

        public int idGestion { get; set; }

        public int id_persona { get; set; }

        public int Responsable { get; set; }

        public int idLaboratorio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG32_Lista> FG32_Lista { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Laboratorio Laboratorio { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Persona Persona1 { get; set; }
    }
}
