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
            AreaLaboratorio = new HashSet<AreaLaboratorio>();
            FG27_TrabajosNoConformes = new HashSet<FG27_TrabajosNoConformes>();
            FG28_ImplementacionAcc = new HashSet<FG28_ImplementacionAcc>();
            FG30DetalleAuditoria = new HashSet<FG30DetalleAuditoria>();
            FG32_ListaVerificacion = new HashSet<FG32_ListaVerificacion>();
            FG33Detalle = new HashSet<FG33Detalle>();
            PersonaLaboratorio = new HashSet<PersonaLaboratorio>();
        }

        [Key]
        public int idLaboratorio { get; set; }

        [Required]
        [StringLength(25)]
        public string nombreLab { get; set; }

        public bool activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AreaLaboratorio> AreaLaboratorio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG27_TrabajosNoConformes> FG27_TrabajosNoConformes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG28_ImplementacionAcc> FG28_ImplementacionAcc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG30DetalleAuditoria> FG30DetalleAuditoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG32_ListaVerificacion> FG32_ListaVerificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG33Detalle> FG33Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaLaboratorio> PersonaLaboratorio { get; set; }
    }
}
