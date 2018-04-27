namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG12_EntregaEquipos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG12_EntregaEquipos()
        {
            EquiposEntrega = new HashSet<EquiposEntrega>();
        }

        [Key]
        public int idFG12 { get; set; }

        public int idGestion { get; set; }

        public int idCliente { get; set; }

        public DateTime fenvarcharecepcion { get; set; }

        public int cantidadGM { get; set; }

        public int cantidadCI { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquiposEntrega> EquiposEntrega { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
