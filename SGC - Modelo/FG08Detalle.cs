namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG08Detalle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG08Detalle()
        {
            FG09HistoricoCambios = new List<FG09HistoricoCambios>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idFG08Detalle { get; set; }

        public int idFG08 { get; set; }

        public int idFormato { get; set; }

        public int idTipo { get; set; }

        public bool aprobado { get; set; }

        public virtual FG08_SolicitudCME FG08_SolicitudCME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG09HistoricoCambios> FG09HistoricoCambios { get; set; }

        public virtual FormatoPlantilla FormatoPlantilla { get; set; }

        public virtual TipoSolicitud TipoSolicitud { get; set; }
    }
}
