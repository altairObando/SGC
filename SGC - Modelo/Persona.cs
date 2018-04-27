namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Persona")]
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            Evaluadores = new HashSet<Evaluadores>();
            FG01_CCompromiso = new HashSet<FG01_CCompromiso>();
            FG02_CConfidencialidad = new HashSet<FG02_CConfidencialidad>();
            FG08_SolicitudCME = new HashSet<FG08_SolicitudCME>();
            FG21_Evaluadores = new HashSet<FG21_Evaluadores>();
            FG22_Evaluadores = new HashSet<FG22_Evaluadores>();
            FG25_Detalle = new HashSet<FG25_Detalle>();
            FG28_ImplementacionAcc = new HashSet<FG28_ImplementacionAcc>();
            FG28_PlanAccion = new HashSet<FG28_PlanAccion>();
            FG28_RevisionSeguimiento = new HashSet<FG28_RevisionSeguimiento>();
            FG30_ProgramaAuditoria = new HashSet<FG30_ProgramaAuditoria>();
            FG31_CalificacionAuditores = new HashSet<FG31_CalificacionAuditores>();
            FG32_ListaVerificacion = new HashSet<FG32_ListaVerificacion>();
            FG32_ListaVerificacion1 = new HashSet<FG32_ListaVerificacion>();
            FG34Participantes = new HashSet<FG34Participantes>();
            FG36Participantes = new HashSet<FG36Participantes>();
            FG37Participantes = new HashSet<FG37Participantes>();
            FG38_Involucrados = new HashSet<FG38_Involucrados>();
            FG39_AccionesCorrectivasYPreventivas = new HashSet<FG39_AccionesCorrectivasYPreventivas>();
            FG40_CambiosQuePuedanAfectarAllSGC = new HashSet<FG40_CambiosQuePuedanAfectarAllSGC>();
            FG41_Detalle = new HashSet<FG41_Detalle>();
            FG41_RecomendacionesDeMejora = new HashSet<FG41_RecomendacionesDeMejora>();
            FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia = new HashSet<FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia>();
            FG42Detalle = new HashSet<FG42Detalle>();
            FG43_EstadoDeEnsayosYCalibracionesNoConformes = new HashSet<FG43_EstadoDeEnsayosYCalibracionesNoConformes>();
            FG44_Detalles = new HashSet<FG44_Detalles>();
            FG44_Participantes = new HashSet<FG44_Participantes>();
            FG45_Participantes = new HashSet<FG45_Participantes>();
            Involucrado = new HashSet<Involucrado>();
            Involucrados = new HashSet<Involucrados>();
            PersonaLaboratorio = new HashSet<PersonaLaboratorio>();
            Representante = new HashSet<Representante>();
        }

        [Key]
        public int id_persona { get; set; }

        public int idCargo { get; set; }

        [Required]
        [StringLength(20)]
        public string cedula { get; set; }

        [Required]
        [StringLength(50)]
        public string nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string apellido_paterno { get; set; }

        [StringLength(50)]
        public string apellidoMaterno { get; set; }

        [StringLength(15)]
        public string telefono { get; set; }

        public bool activo { get; set; }

        public virtual Cargo Cargo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluadores> Evaluadores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG01_CCompromiso> FG01_CCompromiso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG02_CConfidencialidad> FG02_CConfidencialidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG08_SolicitudCME> FG08_SolicitudCME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG21_Evaluadores> FG21_Evaluadores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG22_Evaluadores> FG22_Evaluadores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG25_Detalle> FG25_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG28_ImplementacionAcc> FG28_ImplementacionAcc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG28_PlanAccion> FG28_PlanAccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG28_RevisionSeguimiento> FG28_RevisionSeguimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG30_ProgramaAuditoria> FG30_ProgramaAuditoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG31_CalificacionAuditores> FG31_CalificacionAuditores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG32_ListaVerificacion> FG32_ListaVerificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG32_ListaVerificacion> FG32_ListaVerificacion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG34Participantes> FG34Participantes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG36Participantes> FG36Participantes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG37Participantes> FG37Participantes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG38_Involucrados> FG38_Involucrados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG39_AccionesCorrectivasYPreventivas> FG39_AccionesCorrectivasYPreventivas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG40_CambiosQuePuedanAfectarAllSGC> FG40_CambiosQuePuedanAfectarAllSGC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG41_Detalle> FG41_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG41_RecomendacionesDeMejora> FG41_RecomendacionesDeMejora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia> FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG42Detalle> FG42Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG43_EstadoDeEnsayosYCalibracionesNoConformes> FG43_EstadoDeEnsayosYCalibracionesNoConformes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG44_Detalles> FG44_Detalles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG44_Participantes> FG44_Participantes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG45_Participantes> FG45_Participantes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Involucrado> Involucrado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Involucrados> Involucrados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaLaboratorio> PersonaLaboratorio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Representante> Representante { get; set; }
    }
}
