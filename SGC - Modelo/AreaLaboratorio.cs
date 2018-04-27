namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AreaLaboratorio")]
    public partial class AreaLaboratorio
    {
        [Key]
        public int idAreaLaboratorio { get; set; }

        public int idLaboratorio { get; set; }

        [Required]
        [StringLength(50)]
        public string area { get; set; }

        public bool activo { get; set; }

        public virtual Laboratorio Laboratorio { get; set; }
    }
}
