namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FG28_ImplementacionAcc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FG28_ImplementacionAcc()
        {
            FG28_PlanAccion = new List<FG28_PlanAccion>();
            FG28_RevisionSeguimiento = new List<FG28_RevisionSeguimiento>();
        }

        [Key]
        public int idFG28 { get; set; }

        public int idGestion { get; set; }

        public int idLaboratorio { get; set; }

        public int id_persona { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public int tipoAccion { get; set; }

        [Required]
        [StringLength(250)]
        public string descripcion { get; set; }

        [Required]
        [StringLength(500)]
        public string analisis { get; set; }

        public bool accionesEfectivas { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaCierre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG28_PlanAccion> FG28_PlanAccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG28_RevisionSeguimiento> FG28_RevisionSeguimiento { get; set; }

        public virtual Gestion Gestion { get; set; }

        public virtual Laboratorio Laboratorio { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
