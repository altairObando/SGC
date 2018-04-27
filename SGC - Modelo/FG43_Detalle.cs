namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG43_Detalle
    {
        [Key]
        public int idFG43Detalle { get; set; }

        public int idFG43 { get; set; }

        public int noConformidadesDefinidas { get; set; }

        public int noConformidadesCerradas { get; set; }

        [StringLength(1000)]
        public string observaciones { get; set; }

        public virtual FG43_EstadoDeEnsayosYCalibracionesNoConformes FG43_EstadoDeEnsayosYCalibracionesNoConformes { get; set; }
    }
}
