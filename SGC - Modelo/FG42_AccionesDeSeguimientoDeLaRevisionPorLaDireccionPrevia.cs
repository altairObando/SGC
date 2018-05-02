namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia()
        {
            FG42Detalle = new List<FG42Detalle>();
        }

        [Key]
        public int idFG42 { get; set; }

        public int idGestion { get; set; }

        public int id_persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG42Detalle> FG42Detalle { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
