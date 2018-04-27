namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG26_Acciones
    {
        [Key]
        public int idFG26Acciones { get; set; }

        public int idFG26 { get; set; }

        [Required]
        [StringLength(250)]
        public string descripcion { get; set; }

        [Required]
        [StringLength(250)]
        public string resultados { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        [StringLength(250)]
        public string observaciones { get; set; }

        [Required]
        [StringLength(50)]
        public string solucionadorNombre { get; set; }

        public bool? solucionado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaSolucion { get; set; }

        public virtual FG26_AtencionReclamos FG26_AtencionReclamos { get; set; }
    }
}
