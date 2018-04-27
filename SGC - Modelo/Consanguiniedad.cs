namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consanguiniedad")]
    public partial class Consanguiniedad
    {
        [Key]
        public int idConsanguiniedad { get; set; }

        public int? idFG03 { get; set; }

        [StringLength(100)]
        public string nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string parentesco { get; set; }

        public virtual FG03_ConflictoInteres FG03_ConflictoInteres { get; set; }
    }
}
