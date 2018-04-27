namespace SGC___Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gestion")]
    public partial class Gestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gestion()
        {
            FG01_CCompromiso = new HashSet<FG01_CCompromiso>();
            FG02_CConfidencialidad = new HashSet<FG02_CConfidencialidad>();
            FG03_ConflictoInteres = new HashSet<FG03_ConflictoInteres>();
            FG04_ConflictoInteres = new HashSet<FG04_ConflictoInteres>();
            FG05_MatrizDeRiesgos = new HashSet<FG05_MatrizDeRiesgos>();
            FG06_TratamientoRiesgos = new HashSet<FG06_TratamientoRiesgos>();
            FG08_SolicitudCME = new HashSet<FG08_SolicitudCME>();
            FG09_ControlCambios = new HashSet<FG09_ControlCambios>();
            FG10_SolicitudDosExterna = new HashSet<FG10_SolicitudDosExterna>();
            FG11_AcuerdoServicio = new HashSet<FG11_AcuerdoServicio>();
            FG12_EntregaEquipos = new HashSet<FG12_EntregaEquipos>();
            FG13_ProformaServicio = new HashSet<FG13_ProformaServicio>();
            FG14_CalibracionDosimetrica = new HashSet<FG14_CalibracionDosimetrica>();
            FG15ControlServicioCalidad = new HashSet<FG15ControlServicioCalidad>();
            FG16_Contrato = new HashSet<FG16_Contrato>();
            FG17_ContratoPorIncorporacion = new HashSet<FG17_ContratoPorIncorporacion>();
            FG18_ListaProveedores = new HashSet<FG18_ListaProveedores>();
            FG19_SeguimientoControl = new HashSet<FG19_SeguimientoControl>();
            FG20_ReclamoProveedor = new HashSet<FG20_ReclamoProveedor>();
            FG21_EvaluacionInicial = new HashSet<FG21_EvaluacionInicial>();
            FG22_EvaluacionPeri = new HashSet<FG22_EvaluacionPeri>();
            FG23_SatisfaccionCliente = new HashSet<FG23_SatisfaccionCliente>();
            FG24_ControlQuejasApelaciones = new HashSet<FG24_ControlQuejasApelaciones>();
            FG26_AtencionReclamos = new HashSet<FG26_AtencionReclamos>();
            FG27_TrabajosNoConformes = new HashSet<FG27_TrabajosNoConformes>();
            FG28_ImplementacionAcc = new HashSet<FG28_ImplementacionAcc>();
            FG29_VerificacionControl = new HashSet<FG29_VerificacionControl>();
            FG30_ProgramaAuditoria = new HashSet<FG30_ProgramaAuditoria>();
            FG31_CalificacionAuditores = new HashSet<FG31_CalificacionAuditores>();
            FG32_ListaVerificacion = new HashSet<FG32_ListaVerificacion>();
            FG33_PlanAuditoriaInterna = new HashSet<FG33_PlanAuditoriaInterna>();
            FG34_ReunionInicialAuditoriaInterna = new HashSet<FG34_ReunionInicialAuditoriaInterna>();
            FG35_LevantamientoDeEvidencia = new HashSet<FG35_LevantamientoDeEvidencia>();
            FG36_ReunionCierreAuditoriaInterna = new HashSet<FG36_ReunionCierreAuditoriaInterna>();
            FG37_InformeAuditoriaInterna = new HashSet<FG37_InformeAuditoriaInterna>();
            FG38_CumplimientoDeObjetivos = new HashSet<FG38_CumplimientoDeObjetivos>();
            FG39_AccionesCorrectivasYPreventivas = new HashSet<FG39_AccionesCorrectivasYPreventivas>();
            FG40_CambiosQuePuedanAfectarAllSGC = new HashSet<FG40_CambiosQuePuedanAfectarAllSGC>();
            FG41_RecomendacionesDeMejora = new HashSet<FG41_RecomendacionesDeMejora>();
            FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia = new HashSet<FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia>();
            FG43_EstadoDeEnsayosYCalibracionesNoConformes = new HashSet<FG43_EstadoDeEnsayosYCalibracionesNoConformes>();
            FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion = new HashSet<FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion>();
            FG45_RevisionPorLaDireccion = new HashSet<FG45_RevisionPorLaDireccion>();
        }

        [Key]
        public int idGestion { get; set; }

        public int idProceso { get; set; }

        public int idFormato { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public bool anulada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG01_CCompromiso> FG01_CCompromiso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG02_CConfidencialidad> FG02_CConfidencialidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG03_ConflictoInteres> FG03_ConflictoInteres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG04_ConflictoInteres> FG04_ConflictoInteres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG05_MatrizDeRiesgos> FG05_MatrizDeRiesgos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG06_TratamientoRiesgos> FG06_TratamientoRiesgos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG08_SolicitudCME> FG08_SolicitudCME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG09_ControlCambios> FG09_ControlCambios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG10_SolicitudDosExterna> FG10_SolicitudDosExterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG11_AcuerdoServicio> FG11_AcuerdoServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG12_EntregaEquipos> FG12_EntregaEquipos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG13_ProformaServicio> FG13_ProformaServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG14_CalibracionDosimetrica> FG14_CalibracionDosimetrica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG15ControlServicioCalidad> FG15ControlServicioCalidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG16_Contrato> FG16_Contrato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG17_ContratoPorIncorporacion> FG17_ContratoPorIncorporacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG18_ListaProveedores> FG18_ListaProveedores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG19_SeguimientoControl> FG19_SeguimientoControl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG20_ReclamoProveedor> FG20_ReclamoProveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG21_EvaluacionInicial> FG21_EvaluacionInicial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG22_EvaluacionPeri> FG22_EvaluacionPeri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG23_SatisfaccionCliente> FG23_SatisfaccionCliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG24_ControlQuejasApelaciones> FG24_ControlQuejasApelaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG26_AtencionReclamos> FG26_AtencionReclamos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG27_TrabajosNoConformes> FG27_TrabajosNoConformes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG28_ImplementacionAcc> FG28_ImplementacionAcc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG29_VerificacionControl> FG29_VerificacionControl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG30_ProgramaAuditoria> FG30_ProgramaAuditoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG31_CalificacionAuditores> FG31_CalificacionAuditores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG32_ListaVerificacion> FG32_ListaVerificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG33_PlanAuditoriaInterna> FG33_PlanAuditoriaInterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG34_ReunionInicialAuditoriaInterna> FG34_ReunionInicialAuditoriaInterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG35_LevantamientoDeEvidencia> FG35_LevantamientoDeEvidencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG36_ReunionCierreAuditoriaInterna> FG36_ReunionCierreAuditoriaInterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG37_InformeAuditoriaInterna> FG37_InformeAuditoriaInterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG38_CumplimientoDeObjetivos> FG38_CumplimientoDeObjetivos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG39_AccionesCorrectivasYPreventivas> FG39_AccionesCorrectivasYPreventivas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG40_CambiosQuePuedanAfectarAllSGC> FG40_CambiosQuePuedanAfectarAllSGC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG41_RecomendacionesDeMejora> FG41_RecomendacionesDeMejora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia> FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG43_EstadoDeEnsayosYCalibracionesNoConformes> FG43_EstadoDeEnsayosYCalibracionesNoConformes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion> FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FG45_RevisionPorLaDireccion> FG45_RevisionPorLaDireccion { get; set; }

        public virtual FormatoPlantilla FormatoPlantilla { get; set; }

        public virtual Proceso Proceso { get; set; }
    }
}
