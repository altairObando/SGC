namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG22_EvaluacionPeri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG22_EvaluacionPeri()
        {
            FG22_Evaluadores = new HashSet<FG22_Evaluadores>();
        }

        [Key]
        public int idFG22 { get; set; }

        public int idGestion { get; set; }

        public int idProveedor { get; set; }

        public int especificacionTecnica { get; set; }

        public int devolucionProducto { get; set; }

        public int reclamosEfectuados { get; set; }

        public int certificacion { get; set; }

        public int servicionCliente { get; set; }

        public int tiempoEntrega { get; set; }

        public bool calificacionFinal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG22_Evaluadores> FG22_Evaluadores { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Proveedores Proveedores { get; set; }
    }
}
