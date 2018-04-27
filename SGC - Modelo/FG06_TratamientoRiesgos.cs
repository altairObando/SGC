namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG06_TratamientoRiesgos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG06_TratamientoRiesgos()
        {
            FG06Detalle = new HashSet<FG06Detalle>();
        }

        [Key]
        public int idFG06 { get; set; }

        public int idGestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG06Detalle> FG06Detalle { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
