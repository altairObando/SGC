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
            FG01_CCompromiso = new List<FG01_CCompromiso>();
            FG02_CConfidencialidad = new List<FG02_CConfidencialidad>();
            FG03_ConflictoInteres = new List<FG03_ConflictoInteres>();
            FG04_ConflictoInteres = new List<FG04_ConflictoInteres>();
            FG05_MatrizDeRiesgos = new List<FG05_MatrizDeRiesgos>();
            FG06_TratamientoRiesgos = new List<FG06_TratamientoRiesgos>();
            FG08_SolicitudCME = new List<FG08_SolicitudCME>();
            FG09_ControlCambios = new List<FG09_ControlCambios>();
            FG10_SolicitudDosExterna = new List<FG10_SolicitudDosExterna>();
            FG11_AcuerdoServicio = new List<FG11_AcuerdoServicio>();
            FG12_EntregaEquipos = new List<FG12_EntregaEquipos>();
            FG13_ProformaServicio = new List<FG13_ProformaServicio>();
            FG14_CalibracionDosimetrica = new List<FG14_CalibracionDosimetrica>();
            FG15ControlServicioCalidad = new List<FG15ControlServicioCalidad>();
            FG16_Contrato = new List<FG16_Contrato>();
            FG17_ContratoPorIncorporacion = new List<FG17_ContratoPorIncorporacion>();
            FG18_ListaProveedores = new List<FG18_ListaProveedores>();
            FG19_SeguimientoControl = new List<FG19_SeguimientoControl>();
            FG20_ReclamoProveedor = new List<FG20_ReclamoProveedor>();
            FG21_EvaluacionInicial = new List<FG21_EvaluacionInicial>();
            FG22_EvaluacionPeri = new List<FG22_EvaluacionPeri>();
            FG23_SatisfaccionCliente = new List<FG23_SatisfaccionCliente>();
            FG24_ControlQuejasApelaciones = new List<FG24_ControlQuejasApelaciones>();
            FG26_AtencionReclamos = new List<FG26_AtencionReclamos>();
            FG27_TrabajosNoConformes = new List<FG27_TrabajosNoConformes>();
            FG28_ImplementacionAcc = new List<FG28_ImplementacionAcc>();
            FG29_VerificacionControl = new List<FG29_VerificacionControl>();
            FG30_ProgramaAuditoria = new List<FG30_ProgramaAuditoria>();
            FG31_CalificacionAuditores = new List<FG31_CalificacionAuditores>();
            FG32_ListaVerificacion = new List<FG32_ListaVerificacion>();
            FG33_PlanAuditoriaInterna = new List<FG33_PlanAuditoriaInterna>();
            FG34_ReunionInicialAuditoriaInterna = new List<FG34_ReunionInicialAuditoriaInterna>();
            FG35_LevantamientoDeEvidencia = new List<FG35_LevantamientoDeEvidencia>();
            FG36_ReunionCierreAuditoriaInterna = new List<FG36_ReunionCierreAuditoriaInterna>();
            FG37_InformeAuditoriaInterna = new List<FG37_InformeAuditoriaInterna>();
            FG38_CumplimientoDeObjetivos = new List<FG38_CumplimientoDeObjetivos>();
            FG39_AccionesCorrectivasYPreventivas = new List<FG39_AccionesCorrectivasYPreventivas>();
            FG40_CambiosQuePuedanAfectarAllSGC = new List<FG40_CambiosQuePuedanAfectarAllSGC>();
            FG41_RecomendacionesDeMejora = new List<FG41_RecomendacionesDeMejora>();
            FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia = new List<FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia>();
            FG43_EstadoDeEnsayosYCalibracionesNoConformes = new List<FG43_EstadoDeEnsayosYCalibracionesNoConformes>();
            FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion = new List<FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion>();
            FG45_RevisionPorLaDireccion = new List<FG45_RevisionPorLaDireccion>();
        }

        [Key]
        public int idGestion { get; set; }

        public int idProceso { get; set; }

        public int idFormato { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public bool anulada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG01_CCompromiso> FG01_CCompromiso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG02_CConfidencialidad> FG02_CConfidencialidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG03_ConflictoInteres> FG03_ConflictoInteres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG04_ConflictoInteres> FG04_ConflictoInteres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG05_MatrizDeRiesgos> FG05_MatrizDeRiesgos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG06_TratamientoRiesgos> FG06_TratamientoRiesgos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG08_SolicitudCME> FG08_SolicitudCME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG09_ControlCambios> FG09_ControlCambios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG10_SolicitudDosExterna> FG10_SolicitudDosExterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG11_AcuerdoServicio> FG11_AcuerdoServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG12_EntregaEquipos> FG12_EntregaEquipos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG13_ProformaServicio> FG13_ProformaServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG14_CalibracionDosimetrica> FG14_CalibracionDosimetrica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG15ControlServicioCalidad> FG15ControlServicioCalidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG16_Contrato> FG16_Contrato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG17_ContratoPorIncorporacion> FG17_ContratoPorIncorporacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG18_ListaProveedores> FG18_ListaProveedores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG19_SeguimientoControl> FG19_SeguimientoControl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG20_ReclamoProveedor> FG20_ReclamoProveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG21_EvaluacionInicial> FG21_EvaluacionInicial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG22_EvaluacionPeri> FG22_EvaluacionPeri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG23_SatisfaccionCliente> FG23_SatisfaccionCliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG24_ControlQuejasApelaciones> FG24_ControlQuejasApelaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG26_AtencionReclamos> FG26_AtencionReclamos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG27_TrabajosNoConformes> FG27_TrabajosNoConformes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG28_ImplementacionAcc> FG28_ImplementacionAcc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG29_VerificacionControl> FG29_VerificacionControl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG30_ProgramaAuditoria> FG30_ProgramaAuditoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG31_CalificacionAuditores> FG31_CalificacionAuditores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG32_ListaVerificacion> FG32_ListaVerificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG33_PlanAuditoriaInterna> FG33_PlanAuditoriaInterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG34_ReunionInicialAuditoriaInterna> FG34_ReunionInicialAuditoriaInterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG35_LevantamientoDeEvidencia> FG35_LevantamientoDeEvidencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG36_ReunionCierreAuditoriaInterna> FG36_ReunionCierreAuditoriaInterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG37_InformeAuditoriaInterna> FG37_InformeAuditoriaInterna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG38_CumplimientoDeObjetivos> FG38_CumplimientoDeObjetivos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG39_AccionesCorrectivasYPreventivas> FG39_AccionesCorrectivasYPreventivas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG40_CambiosQuePuedanAfectarAllSGC> FG40_CambiosQuePuedanAfectarAllSGC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG41_RecomendacionesDeMejora> FG41_RecomendacionesDeMejora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia> FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG43_EstadoDeEnsayosYCalibracionesNoConformes> FG43_EstadoDeEnsayosYCalibracionesNoConformes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion> FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FG45_RevisionPorLaDireccion> FG45_RevisionPorLaDireccion { get; set; }

        public virtual FormatoPlantilla FormatoPlantilla { get; set; }

        public virtual Proceso Proceso { get; set; }
    }
}
