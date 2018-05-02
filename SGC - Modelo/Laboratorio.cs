namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Laboratorio")]
    public partial class Laboratorio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Laboratorio()
        {
            AreaLaboratorio = new List<AreaLaboratorio>();
            FG27_TrabajosNoConformes = new List<FG27_TrabajosNoConformes>();
            FG28_ImplementacionAcc = new List<FG28_ImplementacionAcc>();
            FG30DetalleAuditoria = new List<FG30DetalleAuditoria>();
            FG32_ListaVerificacion = new List<FG32_ListaVerificacion>();
            FG33Detalle = new List<FG33Detalle>();
            PersonaLaboratorio = new List<PersonaLaboratorio>();
        }

        [Key]
        public int idLaboratorio { get; set; }

        [Required]
        [StringLength(25)]
        public string nombreLab { get; set; }

        public bool activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<AreaLaboratorio> AreaLaboratorio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG27_TrabajosNoConformes> FG27_TrabajosNoConformes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG28_ImplementacionAcc> FG28_ImplementacionAcc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG30DetalleAuditoria> FG30DetalleAuditoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG32_ListaVerificacion> FG32_ListaVerificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG33Detalle> FG33Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<PersonaLaboratorio> PersonaLaboratorio { get; set; }
    }
}
