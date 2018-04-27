namespace SGC___Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Modelo : DbContext
    {
        public Modelo()
            : base("name=Modelo")
        {
        }

        public virtual DbSet<Actividades> Actividades { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<AreaLaboratorio> AreaLaboratorio { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ClienteRadiacion> ClienteRadiacion { get; set; }
        public virtual DbSet<Consanguiniedad> Consanguiniedad { get; set; }
        public virtual DbSet<DetalleFG13> DetalleFG13 { get; set; }
        public virtual DbSet<Equipo> Equipo { get; set; }
        public virtual DbSet<EquiposEntrega> EquiposEntrega { get; set; }
        public virtual DbSet<EstadoGestion> EstadoGestion { get; set; }
        public virtual DbSet<EstadoSolicitud> EstadoSolicitud { get; set; }
        public virtual DbSet<EvaluacionCertificados> EvaluacionCertificados { get; set; }
        public virtual DbSet<Evaluadores> Evaluadores { get; set; }
        public virtual DbSet<fabricanteEquipo> fabricanteEquipo { get; set; }
        public virtual DbSet<FG01_CCompromiso> FG01_CCompromiso { get; set; }
        public virtual DbSet<FG02_CConfidencialidad> FG02_CConfidencialidad { get; set; }
        public virtual DbSet<FG03_ConflictoInteres> FG03_ConflictoInteres { get; set; }
        public virtual DbSet<FG04_ConflictoInteres> FG04_ConflictoInteres { get; set; }
        public virtual DbSet<FG05_MatrizDeRiesgos> FG05_MatrizDeRiesgos { get; set; }
        public virtual DbSet<FG06_TratamientoRiesgos> FG06_TratamientoRiesgos { get; set; }
        public virtual DbSet<FG06Detalle> FG06Detalle { get; set; }
        public virtual DbSet<FG08_SolicitudCME> FG08_SolicitudCME { get; set; }
        public virtual DbSet<FG08Detalle> FG08Detalle { get; set; }
        public virtual DbSet<FG09_ControlCambios> FG09_ControlCambios { get; set; }
        public virtual DbSet<FG09HistoricoCambios> FG09HistoricoCambios { get; set; }
        public virtual DbSet<FG10_SolicitudDosExterna> FG10_SolicitudDosExterna { get; set; }
        public virtual DbSet<FG10Estados> FG10Estados { get; set; }
        public virtual DbSet<FG10Portadores> FG10Portadores { get; set; }
        public virtual DbSet<FG10Radiaciones> FG10Radiaciones { get; set; }
        public virtual DbSet<FG11_AcuerdoServicio> FG11_AcuerdoServicio { get; set; }
        public virtual DbSet<FG12_EntregaEquipos> FG12_EntregaEquipos { get; set; }
        public virtual DbSet<FG13_ProformaServicio> FG13_ProformaServicio { get; set; }
        public virtual DbSet<FG14_CalibracionDosimetrica> FG14_CalibracionDosimetrica { get; set; }
        public virtual DbSet<FG14Servicios> FG14Servicios { get; set; }
        public virtual DbSet<FG15_Especificaciones> FG15_Especificaciones { get; set; }
        public virtual DbSet<FG15ControlServicioCalidad> FG15ControlServicioCalidad { get; set; }
        public virtual DbSet<FG16_Contrato> FG16_Contrato { get; set; }
        public virtual DbSet<FG17_ContratoPorIncorporacion> FG17_ContratoPorIncorporacion { get; set; }
        public virtual DbSet<FG18_ListaProveedores> FG18_ListaProveedores { get; set; }
        public virtual DbSet<FG19_Detalle> FG19_Detalle { get; set; }
        public virtual DbSet<FG19_SeguimientoControl> FG19_SeguimientoControl { get; set; }
        public virtual DbSet<FG20_ReclamoProveedor> FG20_ReclamoProveedor { get; set; }
        public virtual DbSet<FG21_EvaluacionInicial> FG21_EvaluacionInicial { get; set; }
        public virtual DbSet<FG21_Evaluadores> FG21_Evaluadores { get; set; }
        public virtual DbSet<FG22_EvaluacionPeri> FG22_EvaluacionPeri { get; set; }
        public virtual DbSet<FG22_Evaluadores> FG22_Evaluadores { get; set; }
        public virtual DbSet<FG23_SatisfaccionCliente> FG23_SatisfaccionCliente { get; set; }
        public virtual DbSet<FG24_ControlQuejasApelaciones> FG24_ControlQuejasApelaciones { get; set; }
        public virtual DbSet<FG25_AtencionReclamos> FG25_AtencionReclamos { get; set; }
        public virtual DbSet<FG25_Detalle> FG25_Detalle { get; set; }
        public virtual DbSet<FG26_Acciones> FG26_Acciones { get; set; }
        public virtual DbSet<FG26_AtencionReclamos> FG26_AtencionReclamos { get; set; }
        public virtual DbSet<FG27_CategoriaHallazgo> FG27_CategoriaHallazgo { get; set; }
        public virtual DbSet<FG27_TiposImplementacion> FG27_TiposImplementacion { get; set; }
        public virtual DbSet<FG27_TrabajosNoConformes> FG27_TrabajosNoConformes { get; set; }
        public virtual DbSet<FG28_ImplementacionAcc> FG28_ImplementacionAcc { get; set; }
        public virtual DbSet<FG28_PlanAccion> FG28_PlanAccion { get; set; }
        public virtual DbSet<FG28_RevisionSeguimiento> FG28_RevisionSeguimiento { get; set; }
        public virtual DbSet<FG29_VerificacionControl> FG29_VerificacionControl { get; set; }
        public virtual DbSet<FG29TiposRegistro> FG29TiposRegistro { get; set; }
        public virtual DbSet<FG30_ProgramaAuditoria> FG30_ProgramaAuditoria { get; set; }
        public virtual DbSet<FG30CriteriosAuditoria> FG30CriteriosAuditoria { get; set; }
        public virtual DbSet<FG30DetalleAuditoria> FG30DetalleAuditoria { get; set; }
        public virtual DbSet<FG31_CalificacionAuditores> FG31_CalificacionAuditores { get; set; }
        public virtual DbSet<FG31_Criterio> FG31_Criterio { get; set; }
        public virtual DbSet<FG31_Evaluacion> FG31_Evaluacion { get; set; }
        public virtual DbSet<FG31_Requisitos> FG31_Requisitos { get; set; }
        public virtual DbSet<FG32_Lista> FG32_Lista { get; set; }
        public virtual DbSet<FG32_ListaVerificacion> FG32_ListaVerificacion { get; set; }
        public virtual DbSet<FG33_PlanAuditoriaInterna> FG33_PlanAuditoriaInterna { get; set; }
        public virtual DbSet<FG33Detalle> FG33Detalle { get; set; }
        public virtual DbSet<FG34_ReunionInicialAuditoriaInterna> FG34_ReunionInicialAuditoriaInterna { get; set; }
        public virtual DbSet<FG34Participantes> FG34Participantes { get; set; }
        public virtual DbSet<FG35_hallazgos> FG35_hallazgos { get; set; }
        public virtual DbSet<FG35_LevantamientoDeEvidencia> FG35_LevantamientoDeEvidencia { get; set; }
        public virtual DbSet<FG36_ReunionCierreAuditoriaInterna> FG36_ReunionCierreAuditoriaInterna { get; set; }
        public virtual DbSet<FG36Participantes> FG36Participantes { get; set; }
        public virtual DbSet<FG37_InformeAuditoriaInterna> FG37_InformeAuditoriaInterna { get; set; }
        public virtual DbSet<FG37Participantes> FG37Participantes { get; set; }
        public virtual DbSet<FG38_CumplimientoDeObjetivos> FG38_CumplimientoDeObjetivos { get; set; }
        public virtual DbSet<FG38_Detalle> FG38_Detalle { get; set; }
        public virtual DbSet<FG38_Involucrados> FG38_Involucrados { get; set; }
        public virtual DbSet<FG39_AccionesCorrectivasYPreventivas> FG39_AccionesCorrectivasYPreventivas { get; set; }
        public virtual DbSet<FG39_Detalle> FG39_Detalle { get; set; }
        public virtual DbSet<FG40_CambiosQuePuedanAfectarAllSGC> FG40_CambiosQuePuedanAfectarAllSGC { get; set; }
        public virtual DbSet<FG40_Detalle> FG40_Detalle { get; set; }
        public virtual DbSet<FG41_Detalle> FG41_Detalle { get; set; }
        public virtual DbSet<FG41_RecomendacionesDeMejora> FG41_RecomendacionesDeMejora { get; set; }
        public virtual DbSet<FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia> FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia { get; set; }
        public virtual DbSet<FG42_Estados> FG42_Estados { get; set; }
        public virtual DbSet<FG42Detalle> FG42Detalle { get; set; }
        public virtual DbSet<FG43_Detalle> FG43_Detalle { get; set; }
        public virtual DbSet<FG43_EstadoDeEnsayosYCalibracionesNoConformes> FG43_EstadoDeEnsayosYCalibracionesNoConformes { get; set; }
        public virtual DbSet<FG44_Detalles> FG44_Detalles { get; set; }
        public virtual DbSet<FG44_Participantes> FG44_Participantes { get; set; }
        public virtual DbSet<FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion> FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion { get; set; }
        public virtual DbSet<FG45_Participantes> FG45_Participantes { get; set; }
        public virtual DbSet<FG45_RevisionPorLaDireccion> FG45_RevisionPorLaDireccion { get; set; }
        public virtual DbSet<FormatoGestion> FormatoGestion { get; set; }
        public virtual DbSet<FormatoPlantilla> FormatoPlantilla { get; set; }
        public virtual DbSet<Gestion> Gestion { get; set; }
        public virtual DbSet<Involucrado> Involucrado { get; set; }
        public virtual DbSet<Involucrados> Involucrados { get; set; }
        public virtual DbSet<Laboratorio> Laboratorio { get; set; }
        public virtual DbSet<MarcaInstrumento> MarcaInstrumento { get; set; }
        public virtual DbSet<ModeloEquipo> ModeloEquipo { get; set; }
        public virtual DbSet<MotivacionInteres> MotivacionInteres { get; set; }
        public virtual DbSet<Opcion> Opcion { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<PersonaLaboratorio> PersonaLaboratorio { get; set; }
        public virtual DbSet<Pregunta> Pregunta { get; set; }
        public virtual DbSet<PrestacionServicio> PrestacionServicio { get; set; }
        public virtual DbSet<Proceso> Proceso { get; set; }
        public virtual DbSet<ProcesoGestion> ProcesoGestion { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<ProveedoresCalificados> ProveedoresCalificados { get; set; }
        public virtual DbSet<Puntualidad> Puntualidad { get; set; }
        public virtual DbSet<Representante> Representante { get; set; }
        public virtual DbSet<Riesgos> Riesgos { get; set; }
        public virtual DbSet<Satisfactorio> Satisfactorio { get; set; }
        public virtual DbSet<Seleccion> Seleccion { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<TipoCliente> TipoCliente { get; set; }
        public virtual DbSet<TipoEquipo> TipoEquipo { get; set; }
        public virtual DbSet<TipoRadiacion> TipoRadiacion { get; set; }
        public virtual DbSet<TiposConflicto> TiposConflicto { get; set; }
        public virtual DbSet<TipoServicio> TipoServicio { get; set; }
        public virtual DbSet<TipoSolicitud> TipoSolicitud { get; set; }
        public virtual DbSet<TipoVisita> TipoVisita { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>()
                .HasMany(e => e.FG41_Detalle)
                .WithRequired(e => e.Area)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cargo>()
                .HasMany(e => e.Persona)
                .WithRequired(e => e.Cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.FG14_CalibracionDosimetrica)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.FG15ControlServicioCalidad)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.FG16_Contrato)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.FG17_ContratoPorIncorporacion)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Servicio)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.ClienteRadiacion)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.FG10_SolicitudDosExterna)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.FG12_EntregaEquipos)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.FG13_ProformaServicio)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Equipo>()
                .HasMany(e => e.FG15_Especificaciones)
                .WithRequired(e => e.Equipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstadoSolicitud>()
                .HasMany(e => e.FG10Estados)
                .WithRequired(e => e.EstadoSolicitud)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fabricanteEquipo>()
                .HasMany(e => e.Equipo)
                .WithRequired(e => e.fabricanteEquipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG03_ConflictoInteres>()
                .HasMany(e => e.Actividades)
                .WithRequired(e => e.FG03_ConflictoInteres)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG06_TratamientoRiesgos>()
                .HasMany(e => e.FG06Detalle)
                .WithRequired(e => e.FG06_TratamientoRiesgos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG08_SolicitudCME>()
                .HasMany(e => e.FG08Detalle)
                .WithRequired(e => e.FG08_SolicitudCME)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG09_ControlCambios>()
                .HasMany(e => e.FG09HistoricoCambios)
                .WithRequired(e => e.FG09_ControlCambios)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG10_SolicitudDosExterna>()
                .HasMany(e => e.FG10Portadores)
                .WithRequired(e => e.FG10_SolicitudDosExterna)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG10_SolicitudDosExterna>()
                .HasMany(e => e.FG10Radiaciones)
                .WithRequired(e => e.FG10_SolicitudDosExterna)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG10_SolicitudDosExterna>()
                .HasMany(e => e.Representante)
                .WithRequired(e => e.FG10_SolicitudDosExterna)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG13_ProformaServicio>()
                .HasMany(e => e.DetalleFG13)
                .WithRequired(e => e.FG13_ProformaServicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG14_CalibracionDosimetrica>()
                .HasMany(e => e.FG14Servicios)
                .WithRequired(e => e.FG14_CalibracionDosimetrica)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG14Servicios>()
                .Property(e => e.precioUnitario)
                .HasPrecision(12, 2);

            modelBuilder.Entity<FG15ControlServicioCalidad>()
                .HasMany(e => e.FG15_Especificaciones)
                .WithRequired(e => e.FG15ControlServicioCalidad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG18_ListaProveedores>()
                .HasMany(e => e.ProveedoresCalificados)
                .WithRequired(e => e.FG18_ListaProveedores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG19_SeguimientoControl>()
                .HasMany(e => e.FG19_Detalle)
                .WithRequired(e => e.FG19_SeguimientoControl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG19_SeguimientoControl>()
                .HasMany(e => e.FG20_ReclamoProveedor)
                .WithRequired(e => e.FG19_SeguimientoControl)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG21_EvaluacionInicial>()
                .HasMany(e => e.FG21_Evaluadores)
                .WithRequired(e => e.FG21_EvaluacionInicial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG22_EvaluacionPeri>()
                .HasMany(e => e.FG22_Evaluadores)
                .WithRequired(e => e.FG22_EvaluacionPeri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG23_SatisfaccionCliente>()
                .HasMany(e => e.EvaluacionCertificados)
                .WithRequired(e => e.FG23_SatisfaccionCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG23_SatisfaccionCliente>()
                .HasMany(e => e.PrestacionServicio)
                .WithRequired(e => e.FG23_SatisfaccionCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG23_SatisfaccionCliente>()
                .HasMany(e => e.Puntualidad)
                .WithRequired(e => e.FG23_SatisfaccionCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG23_SatisfaccionCliente>()
                .HasMany(e => e.MotivacionInteres)
                .WithRequired(e => e.FG23_SatisfaccionCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG25_AtencionReclamos>()
                .HasMany(e => e.FG25_Detalle)
                .WithRequired(e => e.FG25_AtencionReclamos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG26_AtencionReclamos>()
                .HasMany(e => e.FG26_Acciones)
                .WithRequired(e => e.FG26_AtencionReclamos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG27_CategoriaHallazgo>()
                .HasMany(e => e.FG27_TrabajosNoConformes)
                .WithRequired(e => e.FG27_CategoriaHallazgo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG27_TiposImplementacion>()
                .HasMany(e => e.FG27_TrabajosNoConformes)
                .WithRequired(e => e.FG27_TiposImplementacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG28_ImplementacionAcc>()
                .HasMany(e => e.FG28_PlanAccion)
                .WithRequired(e => e.FG28_ImplementacionAcc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG29TiposRegistro>()
                .HasMany(e => e.FG29_VerificacionControl)
                .WithRequired(e => e.FG29TiposRegistro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG30_ProgramaAuditoria>()
                .HasMany(e => e.FG30DetalleAuditoria)
                .WithRequired(e => e.FG30_ProgramaAuditoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG30CriteriosAuditoria>()
                .HasMany(e => e.FG30DetalleAuditoria)
                .WithRequired(e => e.FG30CriteriosAuditoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG31_CalificacionAuditores>()
                .HasMany(e => e.FG31_Evaluacion)
                .WithRequired(e => e.FG31_CalificacionAuditores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG31_Criterio>()
                .HasMany(e => e.FG31_Evaluacion)
                .WithRequired(e => e.FG31_Criterio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG31_Requisitos>()
                .HasMany(e => e.FG31_Criterio)
                .WithRequired(e => e.FG31_Requisitos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG32_ListaVerificacion>()
                .HasMany(e => e.FG32_Lista)
                .WithRequired(e => e.FG32_ListaVerificacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG33_PlanAuditoriaInterna>()
                .HasMany(e => e.Evaluadores)
                .WithRequired(e => e.FG33_PlanAuditoriaInterna)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG33_PlanAuditoriaInterna>()
                .HasMany(e => e.FG33Detalle)
                .WithRequired(e => e.FG33_PlanAuditoriaInterna)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG34_ReunionInicialAuditoriaInterna>()
                .HasMany(e => e.FG34Participantes)
                .WithRequired(e => e.FG34_ReunionInicialAuditoriaInterna)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG35_LevantamientoDeEvidencia>()
                .HasMany(e => e.FG35_hallazgos)
                .WithRequired(e => e.FG35_LevantamientoDeEvidencia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG35_LevantamientoDeEvidencia>()
                .HasMany(e => e.Involucrados)
                .WithRequired(e => e.FG35_LevantamientoDeEvidencia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG36_ReunionCierreAuditoriaInterna>()
                .HasMany(e => e.FG36Participantes)
                .WithRequired(e => e.FG36_ReunionCierreAuditoriaInterna)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG37_InformeAuditoriaInterna>()
                .HasMany(e => e.FG37Participantes)
                .WithRequired(e => e.FG37_InformeAuditoriaInterna)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG38_CumplimientoDeObjetivos>()
                .HasMany(e => e.FG38_Detalle)
                .WithRequired(e => e.FG38_CumplimientoDeObjetivos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG38_CumplimientoDeObjetivos>()
                .HasMany(e => e.FG38_Involucrados)
                .WithRequired(e => e.FG38_CumplimientoDeObjetivos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG39_AccionesCorrectivasYPreventivas>()
                .HasMany(e => e.FG39_Detalle)
                .WithRequired(e => e.FG39_AccionesCorrectivasYPreventivas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG40_CambiosQuePuedanAfectarAllSGC>()
                .HasMany(e => e.FG40_Detalle)
                .WithRequired(e => e.FG40_CambiosQuePuedanAfectarAllSGC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia>()
                .HasMany(e => e.FG42Detalle)
                .WithRequired(e => e.FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG42_Estados>()
                .HasMany(e => e.FG42Detalle)
                .WithRequired(e => e.FG42_Estados)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG43_EstadoDeEnsayosYCalibracionesNoConformes>()
                .HasMany(e => e.FG43_Detalle)
                .WithRequired(e => e.FG43_EstadoDeEnsayosYCalibracionesNoConformes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion>()
                .HasMany(e => e.FG44_Detalles)
                .WithRequired(e => e.FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion>()
                .HasMany(e => e.FG44_Participantes)
                .WithRequired(e => e.FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FG45_RevisionPorLaDireccion>()
                .HasMany(e => e.FG45_Participantes)
                .WithRequired(e => e.FG45_RevisionPorLaDireccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FormatoGestion>()
                .HasMany(e => e.FormatoPlantilla)
                .WithRequired(e => e.FormatoGestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FormatoPlantilla>()
                .HasMany(e => e.FG08Detalle)
                .WithRequired(e => e.FormatoPlantilla)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FormatoPlantilla>()
                .HasMany(e => e.Gestion)
                .WithRequired(e => e.FormatoPlantilla)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG01_CCompromiso)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG03_ConflictoInteres)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG04_ConflictoInteres)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG06_TratamientoRiesgos)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG08_SolicitudCME)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG09_ControlCambios)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG10_SolicitudDosExterna)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG11_AcuerdoServicio)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG12_EntregaEquipos)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG13_ProformaServicio)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG14_CalibracionDosimetrica)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG15ControlServicioCalidad)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG16_Contrato)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG17_ContratoPorIncorporacion)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG18_ListaProveedores)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG19_SeguimientoControl)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG20_ReclamoProveedor)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG21_EvaluacionInicial)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG22_EvaluacionPeri)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG23_SatisfaccionCliente)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG24_ControlQuejasApelaciones)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG26_AtencionReclamos)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG27_TrabajosNoConformes)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG28_ImplementacionAcc)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG29_VerificacionControl)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG30_ProgramaAuditoria)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG31_CalificacionAuditores)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG32_ListaVerificacion)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG33_PlanAuditoriaInterna)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG34_ReunionInicialAuditoriaInterna)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG35_LevantamientoDeEvidencia)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG36_ReunionCierreAuditoriaInterna)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG37_InformeAuditoriaInterna)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG38_CumplimientoDeObjetivos)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG39_AccionesCorrectivasYPreventivas)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG40_CambiosQuePuedanAfectarAllSGC)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG41_RecomendacionesDeMejora)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG43_EstadoDeEnsayosYCalibracionesNoConformes)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gestion>()
                .HasMany(e => e.FG45_RevisionPorLaDireccion)
                .WithRequired(e => e.Gestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Laboratorio>()
                .HasMany(e => e.AreaLaboratorio)
                .WithRequired(e => e.Laboratorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Laboratorio>()
                .HasMany(e => e.FG27_TrabajosNoConformes)
                .WithRequired(e => e.Laboratorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Laboratorio>()
                .HasMany(e => e.FG28_ImplementacionAcc)
                .WithRequired(e => e.Laboratorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Laboratorio>()
                .HasMany(e => e.FG30DetalleAuditoria)
                .WithRequired(e => e.Laboratorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Laboratorio>()
                .HasMany(e => e.FG32_ListaVerificacion)
                .WithRequired(e => e.Laboratorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Laboratorio>()
                .HasMany(e => e.FG33Detalle)
                .WithRequired(e => e.Laboratorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Laboratorio>()
                .HasMany(e => e.PersonaLaboratorio)
                .WithRequired(e => e.Laboratorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarcaInstrumento>()
                .HasMany(e => e.Equipo)
                .WithRequired(e => e.MarcaInstrumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ModeloEquipo>()
                .HasMany(e => e.Equipo)
                .WithRequired(e => e.ModeloEquipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Opcion>()
                .HasMany(e => e.Seleccion)
                .WithRequired(e => e.Opcion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Evaluadores)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG01_CCompromiso)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG02_CConfidencialidad)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG08_SolicitudCME)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG21_Evaluadores)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG22_Evaluadores)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Persona_id_persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG25_Detalle)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG28_ImplementacionAcc)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG28_PlanAccion)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG28_RevisionSeguimiento)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.Persona_id_persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG30_ProgramaAuditoria)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG31_CalificacionAuditores)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG32_ListaVerificacion)
                .WithRequired(e => e.Persona)
                .HasForeignKey(e => e.id_persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG32_ListaVerificacion1)
                .WithRequired(e => e.Persona1)
                .HasForeignKey(e => e.Responsable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG34Participantes)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG36Participantes)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG37Participantes)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG38_Involucrados)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG39_AccionesCorrectivasYPreventivas)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG40_CambiosQuePuedanAfectarAllSGC)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG41_Detalle)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG41_RecomendacionesDeMejora)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG42Detalle)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG43_EstadoDeEnsayosYCalibracionesNoConformes)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG44_Detalles)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG44_Participantes)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.FG45_Participantes)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Involucrado)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Involucrados)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PersonaLaboratorio)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.Representante)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonaLaboratorio>()
                .HasMany(e => e.FG34_ReunionInicialAuditoriaInterna)
                .WithRequired(e => e.PersonaLaboratorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonaLaboratorio>()
                .HasMany(e => e.FG35_LevantamientoDeEvidencia)
                .WithRequired(e => e.PersonaLaboratorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pregunta>()
                .HasMany(e => e.Seleccion)
                .WithRequired(e => e.Pregunta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proceso>()
                .HasMany(e => e.Gestion)
                .WithRequired(e => e.Proceso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proceso>()
                .HasMany(e => e.Involucrado)
                .WithRequired(e => e.Proceso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProcesoGestion>()
                .HasMany(e => e.FormatoGestion)
                .WithRequired(e => e.ProcesoGestion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedores>()
                .HasMany(e => e.FG19_SeguimientoControl)
                .WithRequired(e => e.Proveedores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedores>()
                .HasMany(e => e.FG21_EvaluacionInicial)
                .WithRequired(e => e.Proveedores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedores>()
                .HasMany(e => e.FG22_EvaluacionPeri)
                .WithRequired(e => e.Proveedores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedores>()
                .HasMany(e => e.ProveedoresCalificados)
                .WithRequired(e => e.Proveedores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Riesgos>()
                .HasMany(e => e.FG05_MatrizDeRiesgos)
                .WithRequired(e => e.Riesgos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Satisfactorio>()
                .HasMany(e => e.EvaluacionCertificados)
                .WithRequired(e => e.Satisfactorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Satisfactorio>()
                .HasMany(e => e.PrestacionServicio)
                .WithRequired(e => e.Satisfactorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Satisfactorio>()
                .HasMany(e => e.Puntualidad)
                .WithRequired(e => e.Satisfactorio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seleccion>()
                .HasMany(e => e.EvaluacionCertificados)
                .WithRequired(e => e.Seleccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seleccion>()
                .HasMany(e => e.MotivacionInteres)
                .WithRequired(e => e.Seleccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seleccion>()
                .HasMany(e => e.PrestacionServicio)
                .WithRequired(e => e.Seleccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seleccion>()
                .HasMany(e => e.Puntualidad)
                .WithRequired(e => e.Seleccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoCliente>()
                .HasMany(e => e.Cliente)
                .WithRequired(e => e.TipoCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoEquipo>()
                .HasMany(e => e.Equipo)
                .WithRequired(e => e.TipoEquipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoRadiacion>()
                .HasMany(e => e.ClienteRadiacion)
                .WithRequired(e => e.TipoRadiacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoRadiacion>()
                .HasMany(e => e.FG10Radiaciones)
                .WithRequired(e => e.TipoRadiacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TiposConflicto>()
                .HasMany(e => e.FG04_ConflictoInteres)
                .WithRequired(e => e.TiposConflicto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoServicio>()
                .HasMany(e => e.FG13_ProformaServicio)
                .WithRequired(e => e.TipoServicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoSolicitud>()
                .HasMany(e => e.FG08Detalle)
                .WithRequired(e => e.TipoSolicitud)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoVisita>()
                .HasMany(e => e.FG02_CConfidencialidad)
                .WithRequired(e => e.TipoVisita)
                .WillCascadeOnDelete(false);
        }
    }
}
