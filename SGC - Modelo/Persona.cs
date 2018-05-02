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
            Evaluadores = new List<Evaluadores>();
            FG01_CCompromiso = new List<FG01_CCompromiso>();
            FG02_CConfidencialidad = new List<FG02_CConfidencialidad>();
            FG08_SolicitudCME = new List<FG08_SolicitudCME>();
            FG21_Evaluadores = new List<FG21_Evaluadores>();
            FG22_Evaluadores = new List<FG22_Evaluadores>();
            FG25_Detalle = new List<FG25_Detalle>();
            FG28_ImplementacionAcc = new List<FG28_ImplementacionAcc>();
            FG28_PlanAccion = new List<FG28_PlanAccion>();
            FG28_RevisionSeguimiento = new List<FG28_RevisionSeguimiento>();
            FG30_ProgramaAuditoria = new List<FG30_ProgramaAuditoria>();
            FG31_CalificacionAuditores = new List<FG31_CalificacionAuditores>();
            FG32_ListaVerificacion = new List<FG32_ListaVerificacion>();
            FG32_ListaVerificacion1 = new List<FG32_ListaVerificacion>();
            FG34Participantes = new List<FG34Participantes>();
            FG36Participantes = new List<FG36Participantes>();
            FG37Participantes = new List<FG37Participantes>();
            FG38_Involucrados = new List<FG38_Involucrados>();
            FG39_AccionesCorrectivasYPreventivas = new List<FG39_AccionesCorrectivasYPreventivas>();
            FG40_CambiosQuePuedanAfectarAllSGC = new List<FG40_CambiosQuePuedanAfectarAllSGC>();
            FG41_Detalle = new List<FG41_Detalle>();
            FG41_RecomendacionesDeMejora = new List<FG41_RecomendacionesDeMejora>();
            FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia = new List<FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia>();
            FG42Detalle = new List<FG42Detalle>();
            FG43_EstadoDeEnsayosYCalibracionesNoConformes = new List<FG43_EstadoDeEnsayosYCalibracionesNoConformes>();
            FG44_Detalles = new List<FG44_Detalles>();
            FG44_Participantes = new List<FG44_Participantes>();
            FG45_Participantes = new List<FG45_Participantes>();
            Involucrado = new List<Involucrado>();
            Involucrados = new List<Involucrados>();
            PersonaLaboratorio = new List<PersonaLaboratorio>();
            Representante = new List<Representante>();
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
        public virtual List<Evaluadores> Evaluadores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG01_CCompromiso> FG01_CCompromiso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG02_CConfidencialidad> FG02_CConfidencialidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG08_SolicitudCME> FG08_SolicitudCME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG21_Evaluadores> FG21_Evaluadores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG22_Evaluadores> FG22_Evaluadores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG25_Detalle> FG25_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG28_ImplementacionAcc> FG28_ImplementacionAcc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG28_PlanAccion> FG28_PlanAccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG28_RevisionSeguimiento> FG28_RevisionSeguimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG30_ProgramaAuditoria> FG30_ProgramaAuditoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG31_CalificacionAuditores> FG31_CalificacionAuditores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG32_ListaVerificacion> FG32_ListaVerificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG32_ListaVerificacion> FG32_ListaVerificacion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG34Participantes> FG34Participantes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG36Participantes> FG36Participantes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG37Participantes> FG37Participantes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG38_Involucrados> FG38_Involucrados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG39_AccionesCorrectivasYPreventivas> FG39_AccionesCorrectivasYPreventivas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG40_CambiosQuePuedanAfectarAllSGC> FG40_CambiosQuePuedanAfectarAllSGC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG41_Detalle> FG41_Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG41_RecomendacionesDeMejora> FG41_RecomendacionesDeMejora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia> FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG42Detalle> FG42Detalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG43_EstadoDeEnsayosYCalibracionesNoConformes> FG43_EstadoDeEnsayosYCalibracionesNoConformes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG44_Detalles> FG44_Detalles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG44_Participantes> FG44_Participantes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG45_Participantes> FG45_Participantes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Involucrado> Involucrado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Involucrados> Involucrados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<PersonaLaboratorio> PersonaLaboratorio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Representante> Representante { get; set; }
    }
}
