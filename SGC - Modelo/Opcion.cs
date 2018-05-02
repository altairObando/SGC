namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Opcion")]
    public partial class Opcion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Opcion()
        {
            Seleccion = new List<Seleccion>();
        }

        [Key]
        public int idOpcion { get; set; }

        [Column("opcion")]
        [Required]
        [StringLength(10)]
        public string opcion1 { get; set; }

        public bool disponible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Seleccion> Seleccion { get; set; }
    }
}
