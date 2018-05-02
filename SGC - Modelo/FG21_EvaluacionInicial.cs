namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG21_EvaluacionInicial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG21_EvaluacionInicial()
        {
            FG21_Evaluadores = new List<FG21_Evaluadores>();
        }

        [Key]
        public int idFG21 { get; set; }

        public int idGestion { get; set; }

        public int idProveedor { get; set; }

        public double preg1 { get; set; }

        public double preg2 { get; set; }

        public double preg3 { get; set; }

        public double preg4 { get; set; }

        public double preg5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG21_Evaluadores> FG21_Evaluadores { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Proveedores Proveedores { get; set; }
    }
}
