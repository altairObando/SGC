namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG27_TrabajosNoConformes
    {
        [Key]
        public int idFG27 { get; set; }

        public int idGestion { get; set; }

        public int idCategoria { get; set; }

        public int idTipoImplementacion { get; set; }

        public int idLaboratorio { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaApertura { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaCierre { get; set; }

        [Required]
        [StringLength(25)]
        public string estado { get; set; }

        [Required]
        [StringLength(50)]
        public string eficaciaAcciones { get; set; }

        public virtual FG27_CategoriaHallazgo FG27_CategoriaHallazgo { get; set; }

        public virtual FG27_TiposImplementacion FG27_TiposImplementacion { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Laboratorio Laboratorio { get; set; }
    }
}
