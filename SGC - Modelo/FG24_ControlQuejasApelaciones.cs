namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG24_ControlQuejasApelaciones
    {
        [Key]
        public int idFG24 { get; set; }

        public int idGestion { get; set; }

        public bool tipoQueja { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        [Required]
        [StringLength(250)]
        public string descripcion { get; set; }

        [Required]
        [StringLength(250)]
        public string causa { get; set; }

        [Required]
        [StringLength(250)]
        public string resolucion { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        public bool tipoAccion { get; set; }

        public bool solucionado { get; set; }

        public bool cerrado { get; set; }

        [Column(TypeName = "date")]
        public DateTime ultimaFecha { get; set; }

        public virtual Gestion Gestion { get; set; }
    }
}
