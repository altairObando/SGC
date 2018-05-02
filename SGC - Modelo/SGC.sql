/*
 * ER/Studio 8.0 SQL Code Generation
 * Company :      Konoha
 * Project :      Normalizado_08032018.DM1
 * Author :       Noel Obando
 *
 * Date Created : Wednesday, May 02, 2018 12:42:32
 * Target DBMS : Microsoft SQL Server 2008
 */

USE master
go
CREATE DATABASE SGC
go
USE SGC
go
/* 
 * TABLE: Actividades 
 */

CREATE TABLE Actividades(
    idActividad     int          IDENTITY(1,1),
    idFG03          int          NOT NULL,
    Actividad       nvarchar(150)    NOT NULL,
    Organizacion    nvarchar(150)    NOT NULL,
    Relacion        nvarchar(150)    NOT NULL,
    CONSTRAINT PK21_1 PRIMARY KEY NONCLUSTERED (idActividad)
)
go



IF OBJECT_ID('Actividades') IS NOT NULL
    PRINT '<<< CREATED TABLE Actividades >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Actividades >>>'
go

/* 
 * TABLE: Area 
 */

CREATE TABLE Area(
    idArea         int          IDENTITY(1,1),
    descripcion    nvarchar(100)    NOT NULL,
    CONSTRAINT PK149 PRIMARY KEY NONCLUSTERED (idArea)
)
go



IF OBJECT_ID('Area') IS NOT NULL
    PRINT '<<< CREATED TABLE Area >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Area >>>'
go

/* 
 * TABLE: AreaLaboratorio 
 */

CREATE TABLE AreaLaboratorio(
    idAreaLaboratorio    int         IDENTITY(1,1),
    idLaboratorio        int         NOT NULL,
    area                 nvarchar(50)    NOT NULL,
    activo               bit         NOT NULL,
    CONSTRAINT PK9 PRIMARY KEY NONCLUSTERED (idAreaLaboratorio)
)
go



IF OBJECT_ID('AreaLaboratorio') IS NOT NULL
    PRINT '<<< CREATED TABLE AreaLaboratorio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE AreaLaboratorio >>>'
go

/* 
 * TABLE: Cargo 
 */

CREATE TABLE Cargo(
    idCargo            int         IDENTITY(1,1),
    cargo              nvarchar(25)    NOT NULL,
    cargoDisponible    bit         NOT NULL,
    CONSTRAINT PK39 PRIMARY KEY NONCLUSTERED (idCargo)
)
go



IF OBJECT_ID('Cargo') IS NOT NULL
    PRINT '<<< CREATED TABLE Cargo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Cargo >>>'
go

/* 
 * TABLE: Cliente 
 */

CREATE TABLE Cliente(
    idCliente            int          IDENTITY(1,1),
    idTipoCliente        int          NOT NULL,
    nombreInstitucion    nvarchar(75)     NOT NULL,
    direccion            nvarchar(150)    NOT NULL,
    telefono             nvarchar(15)     NOT NULL,
    codigoMinsa          nvarchar(20)     NOT NULL,
    ciudad               nvarchar(100)    NOT NULL,
    ruc                  nvarchar(25)     NULL,
    CONSTRAINT PK10 PRIMARY KEY NONCLUSTERED (idCliente)
)
go



IF OBJECT_ID('Cliente') IS NOT NULL
    PRINT '<<< CREATED TABLE Cliente >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Cliente >>>'
go

/* 
 * TABLE: ClienteRadiacion 
 */

CREATE TABLE ClienteRadiacion(
    idClienteRadiacion    int    NOT NULL,
    idCliente             int    NOT NULL,
    idTipoRadiacion       int    NOT NULL,
    CONSTRAINT PK48 PRIMARY KEY NONCLUSTERED (idClienteRadiacion)
)
go



IF OBJECT_ID('ClienteRadiacion') IS NOT NULL
    PRINT '<<< CREATED TABLE ClienteRadiacion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE ClienteRadiacion >>>'
go

/* 
 * TABLE: Consanguiniedad 
 */

CREATE TABLE Consanguiniedad(
    idConsanguiniedad    int          IDENTITY(1,1),
    idFG03               int          NULL,
    nombre               nvarchar(100)    NULL,
    parentesco           nvarchar(100)    NOT NULL,
    CONSTRAINT PK22_2 PRIMARY KEY NONCLUSTERED (idConsanguiniedad)
)
go



IF OBJECT_ID('Consanguiniedad') IS NOT NULL
    PRINT '<<< CREATED TABLE Consanguiniedad >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Consanguiniedad >>>'
go

/* 
 * TABLE: DetalleFG13 
 */

CREATE TABLE DetalleFG13(
    idDetalle      nvarchar(10)    NOT NULL,
    idFG13         int         NOT NULL,
    cantidad       int         NOT NULL,
    costoUnidad    float       NOT NULL,
    CONSTRAINT PK51_1 PRIMARY KEY NONCLUSTERED (idDetalle)
)
go



IF OBJECT_ID('DetalleFG13') IS NOT NULL
    PRINT '<<< CREATED TABLE DetalleFG13 >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE DetalleFG13 >>>'
go

/* 
 * TABLE: Equipo 
 */

CREATE TABLE Equipo(
    idEquipo              int          IDENTITY(1,1),
    noSerie               nvarchar(30)     NOT NULL,
    idTipoEquipo          int          NOT NULL,
    idFabricanteEquipo    int          NOT NULL,
    idModeloEquipo        int          NOT NULL,
    idMarcaInstrumento    int          NOT NULL,
    especificaciones      nvarchar(500)    NULL,
    fechaFabricacion      date         NOT NULL,
    ubicacion             nvarchar(200)    NOT NULL,
    CONSTRAINT PK47 PRIMARY KEY NONCLUSTERED (idEquipo)
)
go



IF OBJECT_ID('Equipo') IS NOT NULL
    PRINT '<<< CREATED TABLE Equipo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Equipo >>>'
go

/* 
 * TABLE: EquiposEntrega 
 */

CREATE TABLE EquiposEntrega(
    idEquiposEntrega    int    IDENTITY(1,1),
    idFG12              int    NULL,
    idEquipo            int    NULL,
    CONSTRAINT PK61 PRIMARY KEY NONCLUSTERED (idEquiposEntrega)
)
go



IF OBJECT_ID('EquiposEntrega') IS NOT NULL
    PRINT '<<< CREATED TABLE EquiposEntrega >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE EquiposEntrega >>>'
go

/* 
 * TABLE: EstadoGestion 
 */

CREATE TABLE EstadoGestion(
    idEstadoGestion    int         IDENTITY(1,1),
    estado             nvarchar(50)    NOT NULL,
    disponible         bit         NOT NULL,
    CONSTRAINT PK160 PRIMARY KEY NONCLUSTERED (idEstadoGestion)
)
go



IF OBJECT_ID('EstadoGestion') IS NOT NULL
    PRINT '<<< CREATED TABLE EstadoGestion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE EstadoGestion >>>'
go

/* 
 * TABLE: EstadoSolicitud 
 */

CREATE TABLE EstadoSolicitud(
    idEstadoSolicitud    int         IDENTITY(1,1),
    estado               nvarchar(25)    NOT NULL,
    activo               bit         NOT NULL,
    CONSTRAINT PK50 PRIMARY KEY NONCLUSTERED (idEstadoSolicitud)
)
go



IF OBJECT_ID('EstadoSolicitud') IS NOT NULL
    PRINT '<<< CREATED TABLE EstadoSolicitud >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE EstadoSolicitud >>>'
go

/* 
 * TABLE: EvaluacionCertificados 
 */

CREATE TABLE EvaluacionCertificados(
    idEvaluacion     int    IDENTITY(1,1),
    idFG23           int    NOT NULL,
    idSeleccion      int    NOT NULL,
    idSatifaccion    int    NOT NULL,
    CONSTRAINT PK76 PRIMARY KEY NONCLUSTERED (idEvaluacion)
)
go



IF OBJECT_ID('EvaluacionCertificados') IS NOT NULL
    PRINT '<<< CREATED TABLE EvaluacionCertificados >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE EvaluacionCertificados >>>'
go

/* 
 * TABLE: Evaluadores 
 */

CREATE TABLE Evaluadores(
    idEvaluador            int    IDENTITY(1,1),
    idFG33PlanAuditoria    int    NOT NULL,
    id_persona             int    NOT NULL,
    CONSTRAINT PK125 PRIMARY KEY NONCLUSTERED (idEvaluador)
)
go



IF OBJECT_ID('Evaluadores') IS NOT NULL
    PRINT '<<< CREATED TABLE Evaluadores >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Evaluadores >>>'
go

/* 
 * TABLE: fabricanteEquipo 
 */

CREATE TABLE fabricanteEquipo(
    idFabricanteEquipo    int         IDENTITY(1,1),
    descripcion           nvarchar(10)    NULL,
    activo                bit         NOT NULL,
    CONSTRAINT PK45 PRIMARY KEY NONCLUSTERED (idFabricanteEquipo)
)
go



IF OBJECT_ID('fabricanteEquipo') IS NOT NULL
    PRINT '<<< CREATED TABLE fabricanteEquipo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE fabricanteEquipo >>>'
go

/* 
 * TABLE: FG01_CCompromiso 
 */

CREATE TABLE FG01_CCompromiso(
    idFG01        int    IDENTITY(1,1),
    idGestion     int    NOT NULL,
    id_persona    int    NOT NULL,
    CONSTRAINT PK23 PRIMARY KEY NONCLUSTERED (idFG01)
)
go



IF OBJECT_ID('FG01_CCompromiso') IS NOT NULL
    PRINT '<<< CREATED TABLE FG01_CCompromiso >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG01_CCompromiso >>>'
go

/* 
 * TABLE: FG02_CConfidencialidad 
 */

CREATE TABLE FG02_CConfidencialidad(
    id_FG02             int          IDENTITY(1,1),
    id_persona          int          NOT NULL,
    idGestion           int          NULL,
    idTipoVisita        int          NOT NULL,
    otros               bit          NULL,
    otrosDescripcion    nvarchar(150)    NULL,
    CONSTRAINT PK18_1 PRIMARY KEY NONCLUSTERED (id_FG02)
)
go



IF OBJECT_ID('FG02_CConfidencialidad') IS NOT NULL
    PRINT '<<< CREATED TABLE FG02_CConfidencialidad >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG02_CConfidencialidad >>>'
go

/* 
 * TABLE: FG03_ConflictoInteres 
 */

CREATE TABLE FG03_ConflictoInteres(
    idFG03       int    IDENTITY(1,1),
    idGestion    int    NOT NULL,
    CONSTRAINT PK22_1 PRIMARY KEY NONCLUSTERED (idFG03)
)
go



IF OBJECT_ID('FG03_ConflictoInteres') IS NOT NULL
    PRINT '<<< CREATED TABLE FG03_ConflictoInteres >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG03_ConflictoInteres >>>'
go

/* 
 * TABLE: FG04_ConflictoInteres 
 */

CREATE TABLE FG04_ConflictoInteres(
    idFG04             int          IDENTITY(1,1),
    idTipoConflicto    int          NOT NULL,
    idGestion          int          NOT NULL,
    identificacion     nvarchar(100)    NOT NULL,
    medidas            nvarchar(500)    NOT NULL,
    CONSTRAINT PK27 PRIMARY KEY NONCLUSTERED (idFG04)
)
go



IF OBJECT_ID('FG04_ConflictoInteres') IS NOT NULL
    PRINT '<<< CREATED TABLE FG04_ConflictoInteres >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG04_ConflictoInteres >>>'
go

/* 
 * TABLE: FG05_MatrizDeRiesgos 
 */

CREATE TABLE FG05_MatrizDeRiesgos(
    idFG05           int              IDENTITY(1,1),
    idGestion        int              NULL,
    idRiesgo         int              NOT NULL,
    analisisCausa    nvarchar(100)        NULL,
    efecto           nvarchar(100)        NULL,
    importancia      nvarchar(1000)    NULL,
    probalbilidad    nvarchar(1000)    NULL,
    impacto          nvarchar(1000)    NULL,
    nivel            nvarchar(100)        NULL,
    CONSTRAINT PK30 PRIMARY KEY NONCLUSTERED (idFG05)
)
go



IF OBJECT_ID('FG05_MatrizDeRiesgos') IS NOT NULL
    PRINT '<<< CREATED TABLE FG05_MatrizDeRiesgos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG05_MatrizDeRiesgos >>>'
go

/* 
 * TABLE: FG06_TratamientoRiesgos 
 */

CREATE TABLE FG06_TratamientoRiesgos(
    idFG06       int    IDENTITY(1,1),
    idGestion    int    NOT NULL,
    CONSTRAINT PK35 PRIMARY KEY NONCLUSTERED (idFG06)
)
go



IF OBJECT_ID('FG06_TratamientoRiesgos') IS NOT NULL
    PRINT '<<< CREATED TABLE FG06_TratamientoRiesgos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG06_TratamientoRiesgos >>>'
go

/* 
 * TABLE: FG06Detalle 
 */

CREATE TABLE FG06Detalle(
    idFG06Detalle       int          IDENTITY(1,1),
    idFG06              int          NOT NULL,
    controlGestion      nvarchar(100)    NOT NULL,
    controlOperativo    nvarchar(100)    NOT NULL,
    responsable         nvarchar(100)    NOT NULL,
    periocidicidad      nvarchar(100)    NOT NULL,
    indicador           nvarchar(100)    NOT NULL,
    riesgoInherente     nvarchar(100)    NOT NULL,
    CONSTRAINT PK32 PRIMARY KEY NONCLUSTERED (idFG06Detalle)
)
go



IF OBJECT_ID('FG06Detalle') IS NOT NULL
    PRINT '<<< CREATED TABLE FG06Detalle >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG06Detalle >>>'
go

/* 
 * TABLE: FG08_SolicitudCME 
 */

CREATE TABLE FG08_SolicitudCME(
    idFG08            int          NOT NULL,
    fechaSolicitud    date         NOT NULL,
    justificacion     nvarchar(250)    NOT NULL,
    idGestion         int          NOT NULL,
    id_persona        int          NOT NULL,
    CONSTRAINT PK33 PRIMARY KEY NONCLUSTERED (idFG08)
)
go



IF OBJECT_ID('FG08_SolicitudCME') IS NOT NULL
    PRINT '<<< CREATED TABLE FG08_SolicitudCME >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG08_SolicitudCME >>>'
go

/* 
 * TABLE: FG08Detalle 
 */

CREATE TABLE FG08Detalle(
    idFG08Detalle    int    NOT NULL,
    idFG08           int    NOT NULL,
    idFormato        int    NOT NULL,
    idTipo           int    NOT NULL,
    aprobado         bit    NOT NULL,
    CONSTRAINT PK36 PRIMARY KEY NONCLUSTERED (idFG08Detalle)
)
go



IF OBJECT_ID('FG08Detalle') IS NOT NULL
    PRINT '<<< CREATED TABLE FG08Detalle >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG08Detalle >>>'
go

/* 
 * TABLE: FG09_ControlCambios 
 */

CREATE TABLE FG09_ControlCambios(
    IdFG09       nvarchar(10)    NOT NULL,
    idGestion    int         NOT NULL,
    CONSTRAINT PK43 PRIMARY KEY NONCLUSTERED (IdFG09)
)
go



IF OBJECT_ID('FG09_ControlCambios') IS NOT NULL
    PRINT '<<< CREATED TABLE FG09_ControlCambios >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG09_ControlCambios >>>'
go

/* 
 * TABLE: FG09HistoricoCambios 
 */

CREATE TABLE FG09HistoricoCambios(
    idFG09Historico    int         IDENTITY(1,1),
    idFG08Detalle      int         NULL,
    idFormato          int         NULL,
    fechaCambio        date        NOT NULL,
    IdFG09             nvarchar(10)    NOT NULL,
    CONSTRAINT PK44 PRIMARY KEY NONCLUSTERED (idFG09Historico)
)
go



IF OBJECT_ID('FG09HistoricoCambios') IS NOT NULL
    PRINT '<<< CREATED TABLE FG09HistoricoCambios >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG09HistoricoCambios >>>'
go

/* 
 * TABLE: FG10_SolicitudDosExterna 
 */

CREATE TABLE FG10_SolicitudDosExterna(
    idFG10       int    IDENTITY(1,1),
    idGestion    int    NOT NULL,
    idCliente    int    NOT NULL,
    CONSTRAINT PK34 PRIMARY KEY NONCLUSTERED (idFG10)
)
go



IF OBJECT_ID('FG10_SolicitudDosExterna') IS NOT NULL
    PRINT '<<< CREATED TABLE FG10_SolicitudDosExterna >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG10_SolicitudDosExterna >>>'
go

/* 
 * TABLE: FG10Estados 
 */

CREATE TABLE FG10Estados(
    idFG10Estados        int    IDENTITY(1,1),
    idEstadoSolicitud    int    NOT NULL,
    idFG10               int    NULL,
    CONSTRAINT PK51 PRIMARY KEY NONCLUSTERED (idFG10Estados)
)
go



IF OBJECT_ID('FG10Estados') IS NOT NULL
    PRINT '<<< CREATED TABLE FG10Estados >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG10Estados >>>'
go

/* 
 * TABLE: FG10Portadores 
 */

CREATE TABLE FG10Portadores(
    idFG10Portador    int         IDENTITY(1,1),
    idFG10            int         NOT NULL,
    nombreCompleto    nvarchar(50)    NOT NULL,
    sexo              nvarchar(1)     NOT NULL,
    cedula            nvarchar(16)    NOT NULL,
    cargo             nvarchar(20)    NOT NULL,
    CONSTRAINT PK36_1 PRIMARY KEY NONCLUSTERED (idFG10Portador)
)
go



IF OBJECT_ID('FG10Portadores') IS NOT NULL
    PRINT '<<< CREATED TABLE FG10Portadores >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG10Portadores >>>'
go

/* 
 * TABLE: FG10Radiaciones 
 */

CREATE TABLE FG10Radiaciones(
    idFG10R            int    NOT NULL,
    idFG10             int    NOT NULL,
    idTipoRadiacion    int    NOT NULL,
    CONSTRAINT PK49 PRIMARY KEY NONCLUSTERED (idFG10R)
)
go



IF OBJECT_ID('FG10Radiaciones') IS NOT NULL
    PRINT '<<< CREATED TABLE FG10Radiaciones >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG10Radiaciones >>>'
go

/* 
 * TABLE: FG11_AcuerdoServicio 
 */

CREATE TABLE FG11_AcuerdoServicio(
    idFG11       int    IDENTITY(1,1),
    idGestion    int    NOT NULL,
    idFG10       int    NULL,
    CONSTRAINT PK53 PRIMARY KEY NONCLUSTERED (idFG11)
)
go



IF OBJECT_ID('FG11_AcuerdoServicio') IS NOT NULL
    PRINT '<<< CREATED TABLE FG11_AcuerdoServicio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG11_AcuerdoServicio >>>'
go

/* 
 * TABLE: FG12_EntregaEquipos 
 */

CREATE TABLE FG12_EntregaEquipos(
    idFG12            int         IDENTITY(1,1),
    idGestion         int         NOT NULL,
    idCliente         int         NOT NULL,
    fenvarcharecepcion    datetime    NOT NULL,
    cantidadGM        int         NOT NULL,
    cantidadCI        int         NOT NULL,
    CONSTRAINT PK43_1 PRIMARY KEY NONCLUSTERED (idFG12)
)
go



IF OBJECT_ID('FG12_EntregaEquipos') IS NOT NULL
    PRINT '<<< CREATED TABLE FG12_EntregaEquipos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG12_EntregaEquipos >>>'
go

/* 
 * TABLE: FG13_ProformaServicio 
 */

CREATE TABLE FG13_ProformaServicio(
    idFG13            int          IDENTITY(1,1),
    idGestion         int          NOT NULL,
    idCliente         int          NOT NULL,
    idTipoServicio    int          NOT NULL,
    observaciones     nvarchar(250)    NULL,
    CONSTRAINT PK50_1 PRIMARY KEY NONCLUSTERED (idFG13)
)
go



IF OBJECT_ID('FG13_ProformaServicio') IS NOT NULL
    PRINT '<<< CREATED TABLE FG13_ProformaServicio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG13_ProformaServicio >>>'
go

/* 
 * TABLE: FG14_CalibracionDosimetrica 
 */

CREATE TABLE FG14_CalibracionDosimetrica(
    idFG14               int     IDENTITY(1,1),
    idGestion            int     NOT NULL,
    idCliente            int     NOT NULL,
    fechaProgramacion    date    NOT NULL,
    formaPago            bit     NOT NULL,
    CONSTRAINT PK53_1 PRIMARY KEY NONCLUSTERED (idFG14)
)
go



IF OBJECT_ID('FG14_CalibracionDosimetrica') IS NOT NULL
    PRINT '<<< CREATED TABLE FG14_CalibracionDosimetrica >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG14_CalibracionDosimetrica >>>'
go

/* 
 * TABLE: FG14Servicios 
 */

CREATE TABLE FG14Servicios(
    idServicio        int               IDENTITY(1,1),
    idFG14            int               NOT NULL,
    item              int               NOT NULL,
    cantidad          int               NULL,
    precioUnitario    decimal(12, 2)    NOT NULL,
    CONSTRAINT PK54 PRIMARY KEY NONCLUSTERED (idServicio)
)
go



IF OBJECT_ID('FG14Servicios') IS NOT NULL
    PRINT '<<< CREATED TABLE FG14Servicios >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG14Servicios >>>'
go

/* 
 * TABLE: FG15_Especificaciones 
 */

CREATE TABLE FG15_Especificaciones(
    idFG15Espec       int      IDENTITY(1,1),
    idFG15            int      NOT NULL,
    idEquipo          int      NOT NULL,
    cantidad          int      NOT NULL,
    precioUnitario    float    NOT NULL,
    CONSTRAINT PK69 PRIMARY KEY NONCLUSTERED (idFG15Espec)
)
go



IF OBJECT_ID('FG15_Especificaciones') IS NOT NULL
    PRINT '<<< CREATED TABLE FG15_Especificaciones >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG15_Especificaciones >>>'
go

/* 
 * TABLE: FG15ControlServicioCalidad 
 */

CREATE TABLE FG15ControlServicioCalidad(
    idFG15         int          IDENTITY(1,1),
    idGestion      int          NOT NULL,
    idCliente      int          NOT NULL,
    formaPago      bit          NOT NULL,
    comentarios    nvarchar(100)    NOT NULL,
    CONSTRAINT PK68 PRIMARY KEY NONCLUSTERED (idFG15)
)
go



IF OBJECT_ID('FG15ControlServicioCalidad') IS NOT NULL
    PRINT '<<< CREATED TABLE FG15ControlServicioCalidad >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG15ControlServicioCalidad >>>'
go

/* 
 * TABLE: FG16_Contrato 
 */

CREATE TABLE FG16_Contrato(
    idFG16       int    IDENTITY(1,1),
    idCliente    int    NOT NULL,
    idGestion    int    NOT NULL,
    idFG15       int    NULL,
    CONSTRAINT PK70 PRIMARY KEY NONCLUSTERED (idFG16)
)
go



IF OBJECT_ID('FG16_Contrato') IS NOT NULL
    PRINT '<<< CREATED TABLE FG16_Contrato >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG16_Contrato >>>'
go

/* 
 * TABLE: FG17_ContratoPorIncorporacion 
 */

CREATE TABLE FG17_ContratoPorIncorporacion(
    idFG17       int    IDENTITY(1,1),
    idCliente    int    NOT NULL,
    idGestion    int    NOT NULL,
    CONSTRAINT PK71 PRIMARY KEY NONCLUSTERED (idFG17)
)
go



IF OBJECT_ID('FG17_ContratoPorIncorporacion') IS NOT NULL
    PRINT '<<< CREATED TABLE FG17_ContratoPorIncorporacion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG17_ContratoPorIncorporacion >>>'
go

/* 
 * TABLE: FG18_ListaProveedores 
 */

CREATE TABLE FG18_ListaProveedores(
    idFG18       int    IDENTITY(1,1),
    idGestion    int    NOT NULL,
    CONSTRAINT PK78 PRIMARY KEY NONCLUSTERED (idFG18)
)
go



IF OBJECT_ID('FG18_ListaProveedores') IS NOT NULL
    PRINT '<<< CREATED TABLE FG18_ListaProveedores >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG18_ListaProveedores >>>'
go

/* 
 * TABLE: FG19_Detalle 
 */

CREATE TABLE FG19_Detalle(
    idFG19Detalle       int         IDENTITY(1,1),
    idFG19              int         NOT NULL,
    prodServicio        nvarchar(25)    NOT NULL,
    especificaciones    nvarchar(25)    NOT NULL,
    cantidad            int         NOT NULL,
    observaciones       nvarchar(50)    NOT NULL,
    CONSTRAINT PK66 PRIMARY KEY NONCLUSTERED (idFG19Detalle)
)
go



IF OBJECT_ID('FG19_Detalle') IS NOT NULL
    PRINT '<<< CREATED TABLE FG19_Detalle >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG19_Detalle >>>'
go

/* 
 * TABLE: FG19_SeguimientoControl 
 */

CREATE TABLE FG19_SeguimientoControl(
    idFG19         int         IDENTITY(1,1),
    noFactura      nvarchar(25)    NOT NULL,
    idGestion      int         NOT NULL,
    idProveedor    int         NOT NULL,
    CONSTRAINT PK58 PRIMARY KEY NONCLUSTERED (idFG19)
)
go



IF OBJECT_ID('FG19_SeguimientoControl') IS NOT NULL
    PRINT '<<< CREATED TABLE FG19_SeguimientoControl >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG19_SeguimientoControl >>>'
go

/* 
 * TABLE: FG20_ReclamoProveedor 
 */

CREATE TABLE FG20_ReclamoProveedor(
    idFG20            int             IDENTITY(1,1),
    idGestion         int             NOT NULL,
    idFG19            int             NOT NULL,
    fenvarchareclamo      date            NOT NULL,
    detalleReclamo    nvarchar(300)    NOT NULL,
    observaciones     nvarchar(300)    NULL,
    tipo              int             NOT NULL,
    CONSTRAINT PK67 PRIMARY KEY NONCLUSTERED (idFG20)
)
go



IF OBJECT_ID('FG20_ReclamoProveedor') IS NOT NULL
    PRINT '<<< CREATED TABLE FG20_ReclamoProveedor >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG20_ReclamoProveedor >>>'
go

/* 
 * TABLE: FG21_EvaluacionInicial 
 */

CREATE TABLE FG21_EvaluacionInicial(
    idFG21         int      IDENTITY(1,1),
    idGestion      int      NOT NULL,
    idProveedor    int      NOT NULL,
    preg1          float    NOT NULL,
    preg2          float    NOT NULL,
    preg3          float    NOT NULL,
    preg4          float    NOT NULL,
    preg5          float    NOT NULL,
    CONSTRAINT PK68_1 PRIMARY KEY NONCLUSTERED (idFG21)
)
go



IF OBJECT_ID('FG21_EvaluacionInicial') IS NOT NULL
    PRINT '<<< CREATED TABLE FG21_EvaluacionInicial >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG21_EvaluacionInicial >>>'
go

/* 
 * TABLE: FG21_Evaluadores 
 */

CREATE TABLE FG21_Evaluadores(
    idFG21Ev      int    IDENTITY(1,1),
    idFG21        int    NOT NULL,
    id_persona    int    NOT NULL,
    CONSTRAINT PK86 PRIMARY KEY NONCLUSTERED (idFG21Ev)
)
go



IF OBJECT_ID('FG21_Evaluadores') IS NOT NULL
    PRINT '<<< CREATED TABLE FG21_Evaluadores >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG21_Evaluadores >>>'
go

/* 
 * TABLE: FG22_EvaluacionPeri 
 */

CREATE TABLE FG22_EvaluacionPeri(
    idFG22                   int    IDENTITY(1,1),
    idGestion                int    NOT NULL,
    idProveedor              int    NOT NULL,
    especificacionTecnica    int    NOT NULL,
    devolucionProducto       int    NOT NULL,
    reclamosEfectuados       int    NOT NULL,
    certificacion            int    NOT NULL,
    servicionCliente         int    NOT NULL,
    tiempoEntrega            int    NOT NULL,
    calificacionFinal        bit    NOT NULL,
    CONSTRAINT PK71_1 PRIMARY KEY NONCLUSTERED (idFG22)
)
go



IF OBJECT_ID('FG22_EvaluacionPeri') IS NOT NULL
    PRINT '<<< CREATED TABLE FG22_EvaluacionPeri >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG22_EvaluacionPeri >>>'
go

/* 
 * TABLE: FG22_Evaluadores 
 */

CREATE TABLE FG22_Evaluadores(
    idFG22Eval            int    IDENTITY(1,1),
    Persona_id_persona    int    NOT NULL,
    idFG22                int    NOT NULL,
    CONSTRAINT PK66_1 PRIMARY KEY NONCLUSTERED (idFG22Eval)
)
go



IF OBJECT_ID('FG22_Evaluadores') IS NOT NULL
    PRINT '<<< CREATED TABLE FG22_Evaluadores >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG22_Evaluadores >>>'
go

/* 
 * TABLE: FG23_SatisfaccionCliente 
 */

CREATE TABLE FG23_SatisfaccionCliente(
    idFG23       int          IDENTITY(1,1),
    idGestion    int          NOT NULL,
    opcional     nvarchar(300)    NULL,
    CONSTRAINT PK73 PRIMARY KEY NONCLUSTERED (idFG23)
)
go



IF OBJECT_ID('FG23_SatisfaccionCliente') IS NOT NULL
    PRINT '<<< CREATED TABLE FG23_SatisfaccionCliente >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG23_SatisfaccionCliente >>>'
go

/* 
 * TABLE: FG24_ControlQuejasApelaciones 
 */

CREATE TABLE FG24_ControlQuejasApelaciones(
    idFG24         int          IDENTITY(1,1),
    idGestion      int          NOT NULL,
    tipoQueja      bit          NOT NULL,
    fecha          date         NOT NULL,
    descripcion    nvarchar(250)    NOT NULL,
    causa          nvarchar(250)    NOT NULL,
    resolucion     nvarchar(250)    NOT NULL,
    nombre         nvarchar(50)     NOT NULL,
    tipoAccion     bit          NOT NULL,
    solucionado    bit          NOT NULL,
    cerrado        bit          NOT NULL,
    ultimaFecha    date         NOT NULL,
    CONSTRAINT PK78_1 PRIMARY KEY NONCLUSTERED (idFG24)
)
go



IF OBJECT_ID('FG24_ControlQuejasApelaciones') IS NOT NULL
    PRINT '<<< CREATED TABLE FG24_ControlQuejasApelaciones >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG24_ControlQuejasApelaciones >>>'
go

/* 
 * TABLE: FG25_AtencionReclamos 
 */

CREATE TABLE FG25_AtencionReclamos(
    idFG25            int          IDENTITY(1,1),
    fecha             date         NOT NULL,
    detalleReclamo    nvarchar(250)    NOT NULL,
    solucion          nvarchar(100)    NOT NULL,
    nombre            nvarchar(50)     NOT NULL,
    cerrado           bit          NOT NULL,
    fechaCierre       date         NOT NULL,
    CONSTRAINT PK79_1 PRIMARY KEY NONCLUSTERED (idFG25)
)
go



IF OBJECT_ID('FG25_AtencionReclamos') IS NOT NULL
    PRINT '<<< CREATED TABLE FG25_AtencionReclamos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG25_AtencionReclamos >>>'
go

/* 
 * TABLE: FG25_Detalle 
 */

CREATE TABLE FG25_Detalle(
    idFG25Detalle     int         IDENTITY(1,1),
    idFG25            int         NOT NULL,
    id_persona        int         NOT NULL,
    causas            nvarchar(50)    NOT NULL,
    acciones          nvarchar(50)    NOT NULL,
    fechaEjecucion    date        NOT NULL,
    CONSTRAINT PK80 PRIMARY KEY NONCLUSTERED (idFG25Detalle)
)
go



IF OBJECT_ID('FG25_Detalle') IS NOT NULL
    PRINT '<<< CREATED TABLE FG25_Detalle >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG25_Detalle >>>'
go

/* 
 * TABLE: FG26_Acciones 
 */

CREATE TABLE FG26_Acciones(
    idFG26Acciones        int          IDENTITY(1,1),
    idFG26                int          NOT NULL,
    descripcion           nvarchar(250)    NOT NULL,
    resultados            nvarchar(250)    NOT NULL,
    fecha                 date         NOT NULL,
    observaciones         nvarchar(250)    NULL,
    solucionadorNombre    nvarchar(50)     NOT NULL,
    solucionado           bit          NULL,
    fechaSolucion         date         NULL,
    CONSTRAINT PK85 PRIMARY KEY NONCLUSTERED (idFG26Acciones)
)
go



IF OBJECT_ID('FG26_Acciones') IS NOT NULL
    PRINT '<<< CREATED TABLE FG26_Acciones >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG26_Acciones >>>'
go

/* 
 * TABLE: FG26_AtencionReclamos 
 */

CREATE TABLE FG26_AtencionReclamos(
    idFG26             int          IDENTITY(1,1),
    idGestion          int          NOT NULL,
    fecha              date         NOT NULL,
    generadoPor        nvarchar(250)    NOT NULL,
    identificadoPor    nvarchar(250)    NOT NULL,
    docInvolucrado     nvarchar(50)     NOT NULL,
    descripcion        nvarchar(250)    NOT NULL,
    causa              nvarchar(250)    NOT NULL,
    efecto             nvarchar(250)    NOT NULL,
    recibidoPor        nvarchar(100)    NOT NULL,
    CONSTRAINT PK83 PRIMARY KEY NONCLUSTERED (idFG26)
)
go



IF OBJECT_ID('FG26_AtencionReclamos') IS NOT NULL
    PRINT '<<< CREATED TABLE FG26_AtencionReclamos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG26_AtencionReclamos >>>'
go

/* 
 * TABLE: FG27_CategoriaHallazgo 
 */

CREATE TABLE FG27_CategoriaHallazgo(
    idCategoria    int         IDENTITY(1,1),
    descripcion    nvarchar(60)    NOT NULL,
    activa         bit         NULL,
    CONSTRAINT PK87 PRIMARY KEY NONCLUSTERED (idCategoria)
)
go



IF OBJECT_ID('FG27_CategoriaHallazgo') IS NOT NULL
    PRINT '<<< CREATED TABLE FG27_CategoriaHallazgo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG27_CategoriaHallazgo >>>'
go

/* 
 * TABLE: FG27_TiposImplementacion 
 */

CREATE TABLE FG27_TiposImplementacion(
    idTipoImplementacion    int         IDENTITY(1,1),
    tipoImplementacion      nvarchar(50)    NOT NULL,
    activa                  bit         NULL,
    CONSTRAINT PK89 PRIMARY KEY NONCLUSTERED (idTipoImplementacion)
)
go



IF OBJECT_ID('FG27_TiposImplementacion') IS NOT NULL
    PRINT '<<< CREATED TABLE FG27_TiposImplementacion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG27_TiposImplementacion >>>'
go

/* 
 * TABLE: FG27_TrabajosNoConformes 
 */

CREATE TABLE FG27_TrabajosNoConformes(
    idFG27                  int         IDENTITY(1,1),
    idGestion               int         NOT NULL,
    idCategoria             int         NOT NULL,
    idTipoImplementacion    int         NOT NULL,
    idLaboratorio           int         NOT NULL,
    fechaApertura           date        NOT NULL,
    fechaCierre             date        NOT NULL,
    estado                  nvarchar(25)    NOT NULL,
    eficaciaAcciones        nvarchar(50)    NOT NULL,
    CONSTRAINT PK84 PRIMARY KEY NONCLUSTERED (idFG27)
)
go



IF OBJECT_ID('FG27_TrabajosNoConformes') IS NOT NULL
    PRINT '<<< CREATED TABLE FG27_TrabajosNoConformes >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG27_TrabajosNoConformes >>>'
go

/* 
 * TABLE: FG28_ImplementacionAcc 
 */

CREATE TABLE FG28_ImplementacionAcc(
    idFG28               int          IDENTITY(1,1),
    idGestion            int          NOT NULL,
    idLaboratorio        int          NOT NULL,
    id_persona           int          NOT NULL,
    fecha                date         NOT NULL,
    tipoAccion           int          NOT NULL,
    descripcion          nvarchar(250)    NOT NULL,
    analisis             nvarchar(500)    NOT NULL,
    accionesEfectivas    bit          NOT NULL,
    fechaCierre          date         NOT NULL,
    CONSTRAINT PK90 PRIMARY KEY NONCLUSTERED (idFG28)
)
go



IF OBJECT_ID('FG28_ImplementacionAcc') IS NOT NULL
    PRINT '<<< CREATED TABLE FG28_ImplementacionAcc >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG28_ImplementacionAcc >>>'
go

/* 
 * TABLE: FG28_PlanAccion 
 */

CREATE TABLE FG28_PlanAccion(
    idPlanAccion    int          IDENTITY(1,1),
    idFG28          int          NOT NULL,
    id_persona      int          NOT NULL,
    accion          nvarchar(100)    NOT NULL,
    fecha           date         NOT NULL,
    CONSTRAINT PK91 PRIMARY KEY NONCLUSTERED (idPlanAccion)
)
go



IF OBJECT_ID('FG28_PlanAccion') IS NOT NULL
    PRINT '<<< CREATED TABLE FG28_PlanAccion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG28_PlanAccion >>>'
go

/* 
 * TABLE: FG28_RevisionSeguimiento 
 */

CREATE TABLE FG28_RevisionSeguimiento(
    idRevision            int          IDENTITY(1,1),
    idFG28                int          NULL,
    Persona_id_persona    int          NOT NULL,
    resultados            nvarchar(200)    NOT NULL,
    fecha                 date         NOT NULL,
    CONSTRAINT PK92_1 PRIMARY KEY NONCLUSTERED (idRevision)
)
go



IF OBJECT_ID('FG28_RevisionSeguimiento') IS NOT NULL
    PRINT '<<< CREATED TABLE FG28_RevisionSeguimiento >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG28_RevisionSeguimiento >>>'
go

/* 
 * TABLE: FG29_VerificacionControl 
 */

CREATE TABLE FG29_VerificacionControl(
    idFG29              int          IDENTITY(1,1),
    idTipo              int          NOT NULL,
    fecha               date         NOT NULL,
    resultados          nvarchar(50)     NOT NULL,
    descripcion         nvarchar(100)    NOT NULL,
    accionCorrectora    nvarchar(100)    NOT NULL,
    idGestion           int          NOT NULL,
    CONSTRAINT PK94_1 PRIMARY KEY NONCLUSTERED (idFG29)
)
go



IF OBJECT_ID('FG29_VerificacionControl') IS NOT NULL
    PRINT '<<< CREATED TABLE FG29_VerificacionControl >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG29_VerificacionControl >>>'
go

/* 
 * TABLE: FG29TiposRegistro 
 */

CREATE TABLE FG29TiposRegistro(
    idTipo                int          IDENTITY(1,1),
    tipoRegistro          nvarchar(250)    NOT NULL,
    permanente            bit          NOT NULL,
    peridoNoPermanente    int          NOT NULL,
    CONSTRAINT PK95_1 PRIMARY KEY NONCLUSTERED (idTipo)
)
go



IF OBJECT_ID('FG29TiposRegistro') IS NOT NULL
    PRINT '<<< CREATED TABLE FG29TiposRegistro >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG29TiposRegistro >>>'
go

/* 
 * TABLE: FG30_ProgramaAuditoria 
 */

CREATE TABLE FG30_ProgramaAuditoria(
    idFG30          int          IDENTITY(1,1),
    idGestion       int          NOT NULL,
    id_persona      int          NOT NULL,
    objetivo        nvarchar(100)    NOT NULL,
    alcance         nvarchar(100)    NOT NULL,
    fecha_inicio    date         NOT NULL,
    CONSTRAINT PK97 PRIMARY KEY NONCLUSTERED (idFG30)
)
go



IF OBJECT_ID('FG30_ProgramaAuditoria') IS NOT NULL
    PRINT '<<< CREATED TABLE FG30_ProgramaAuditoria >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG30_ProgramaAuditoria >>>'
go

/* 
 * TABLE: FG30CriteriosAuditoria 
 */

CREATE TABLE FG30CriteriosAuditoria(
    idCriterio    int          IDENTITY(1,1),
    criterio      nvarchar(100)    NOT NULL,
    disponible    bit          NOT NULL,
    CONSTRAINT PK99 PRIMARY KEY NONCLUSTERED (idCriterio)
)
go



IF OBJECT_ID('FG30CriteriosAuditoria') IS NOT NULL
    PRINT '<<< CREATED TABLE FG30CriteriosAuditoria >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG30CriteriosAuditoria >>>'
go

/* 
 * TABLE: FG30DetalleAuditoria 
 */

CREATE TABLE FG30DetalleAuditoria(
    idDetalleAuditoria    int          IDENTITY(1,1),
    idFG30                int          NOT NULL,
    idLaboratorio         int          NOT NULL,
    idCriterio            int          NOT NULL,
    objeto                nvarchar(100)    NOT NULL,
    alcance               nvarchar(50)     NOT NULL,
    noEvaluaciones        int          NOT NULL,
    horasProgramadas      int          NOT NULL,
    ciclo                 nvarchar(50)     NOT NULL,
    fecha                 date         NOT NULL,
    CONSTRAINT PK98 PRIMARY KEY NONCLUSTERED (idDetalleAuditoria)
)
go



IF OBJECT_ID('FG30DetalleAuditoria') IS NOT NULL
    PRINT '<<< CREATED TABLE FG30DetalleAuditoria >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG30DetalleAuditoria >>>'
go

/* 
 * TABLE: FG31_CalificacionAuditores 
 */

CREATE TABLE FG31_CalificacionAuditores(
    idFG31        int    IDENTITY(1,1),
    idGestion     int    NOT NULL,
    id_persona    int    NOT NULL,
    CONSTRAINT PK100 PRIMARY KEY NONCLUSTERED (idFG31)
)
go



IF OBJECT_ID('FG31_CalificacionAuditores') IS NOT NULL
    PRINT '<<< CREATED TABLE FG31_CalificacionAuditores >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG31_CalificacionAuditores >>>'
go

/* 
 * TABLE: FG31_Criterio 
 */

CREATE TABLE FG31_Criterio(
    idCriterio         int          IDENTITY(1,1),
    idF31Requisitos    int          NOT NULL,
    criterio           nvarchar(100)    NOT NULL,
    disponible         bit          NOT NULL,
    CONSTRAINT PK119 PRIMARY KEY NONCLUSTERED (idCriterio)
)
go



IF OBJECT_ID('FG31_Criterio') IS NOT NULL
    PRINT '<<< CREATED TABLE FG31_Criterio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG31_Criterio >>>'
go

/* 
 * TABLE: FG31_Evaluacion 
 */

CREATE TABLE FG31_Evaluacion(
    idEvaluacion    int          IDENTITY(1,1),
    idFG31          int          NOT NULL,
    idCriterio      int          NOT NULL,
    ponderado       float        NOT NULL,
    puntaje         float        NOT NULL,
    observacion     nvarchar(100)    NOT NULL,
    CONSTRAINT PK120 PRIMARY KEY NONCLUSTERED (idEvaluacion)
)
go



IF OBJECT_ID('FG31_Evaluacion') IS NOT NULL
    PRINT '<<< CREATED TABLE FG31_Evaluacion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG31_Evaluacion >>>'
go

/* 
 * TABLE: FG31_Requisitos 
 */

CREATE TABLE FG31_Requisitos(
    idF31Requisitos    int         IDENTITY(1,1),
    tituloRequisito    nvarchar(50)    NOT NULL,
    ponderaje          float       NOT NULL,
    CONSTRAINT PK117 PRIMARY KEY NONCLUSTERED (idF31Requisitos)
)
go



IF OBJECT_ID('FG31_Requisitos') IS NOT NULL
    PRINT '<<< CREATED TABLE FG31_Requisitos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG31_Requisitos >>>'
go

/* 
 * TABLE: FG32_Lista 
 */

CREATE TABLE FG32_Lista(
    idFG32Lista      int          IDENTITY(1,1),
    idFG32           int          NOT NULL,
    cumple           bit          NOT NULL,
    observaciones    nvarchar(250)    NULL,
    CONSTRAINT PK103 PRIMARY KEY NONCLUSTERED (idFG32Lista)
)
go



IF OBJECT_ID('FG32_Lista') IS NOT NULL
    PRINT '<<< CREATED TABLE FG32_Lista >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG32_Lista >>>'
go

/* 
 * TABLE: FG32_ListaVerificacion 
 */

CREATE TABLE FG32_ListaVerificacion(
    idFG32           int    IDENTITY(1,1),
    idGestion        int    NOT NULL,
    id_persona       int    NOT NULL,
    Responsable      int    NOT NULL,
    idLaboratorio    int    NOT NULL,
    CONSTRAINT PK102 PRIMARY KEY NONCLUSTERED (idFG32)
)
go



IF OBJECT_ID('FG32_ListaVerificacion') IS NOT NULL
    PRINT '<<< CREATED TABLE FG32_ListaVerificacion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG32_ListaVerificacion >>>'
go

/* 
 * TABLE: FG33_PlanAuditoriaInterna 
 */

CREATE TABLE FG33_PlanAuditoriaInterna(
    idFG33PlanAuditoria    int          IDENTITY(1,1),
    idGestion              int          NOT NULL,
    objetivo               nvarchar(150)    NOT NULL,
    criterio               nvarchar(150)    NOT NULL,
    alcance                nvarchar(150)    NOT NULL,
    cliclo                 nvarchar(50)     NOT NULL,
    CONSTRAINT PK123 PRIMARY KEY NONCLUSTERED (idFG33PlanAuditoria)
)
go



IF OBJECT_ID('FG33_PlanAuditoriaInterna') IS NOT NULL
    PRINT '<<< CREATED TABLE FG33_PlanAuditoriaInterna >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG33_PlanAuditoriaInterna >>>'
go

/* 
 * TABLE: FG33Detalle 
 */

CREATE TABLE FG33Detalle(
    idFG33Detalle          int          IDENTITY(1,1),
    idFG33PlanAuditoria    int          NOT NULL,
    idLaboratorio          int          NOT NULL,
    actividades            nvarchar(100)    NOT NULL,
    dia                    date         NOT NULL,
    horas                  int          NOT NULL,
    codigoDoc              nvarchar(25)     NOT NULL,
    CONSTRAINT PK107 PRIMARY KEY NONCLUSTERED (idFG33Detalle)
)
go



IF OBJECT_ID('FG33Detalle') IS NOT NULL
    PRINT '<<< CREATED TABLE FG33Detalle >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG33Detalle >>>'
go

/* 
 * TABLE: FG34_ReunionInicialAuditoriaInterna 
 */

CREATE TABLE FG34_ReunionInicialAuditoriaInterna(
    idFG34                  int              IDENTITY(1,1),
    objetivos               nvarchar(1000)    NOT NULL,
    alcance                 nvarchar(100)     NOT NULL,
    acuerdos                nvarchar(1000)    NOT NULL,
    idPersonaLaboratorio    int              NOT NULL,
    idGestion               int              NOT NULL,
    CONSTRAINT PK129 PRIMARY KEY NONCLUSTERED (idFG34)
)
go



IF OBJECT_ID('FG34_ReunionInicialAuditoriaInterna') IS NOT NULL
    PRINT '<<< CREATED TABLE FG34_ReunionInicialAuditoriaInterna >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG34_ReunionInicialAuditoriaInterna >>>'
go

/* 
 * TABLE: FG34Participantes 
 */

CREATE TABLE FG34Participantes(
    idFG34Participante    int    IDENTITY(1,1),
    idFG34                int    NOT NULL,
    id_persona            int    NOT NULL,
    CONSTRAINT PK130 PRIMARY KEY NONCLUSTERED (idFG34Participante)
)
go



IF OBJECT_ID('FG34Participantes') IS NOT NULL
    PRINT '<<< CREATED TABLE FG34Participantes >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG34Participantes >>>'
go

/* 
 * TABLE: FG35_hallazgos 
 */

CREATE TABLE FG35_hallazgos(
    idHallazgo    int          IDENTITY(1,1),
    idFG35        int          NOT NULL,
    evidencia     nvarchar(150)    NOT NULL,
    hallazgos     nvarchar(250)    NOT NULL,
    criterio      nvarchar(250)    NOT NULL,
    CONSTRAINT PK111 PRIMARY KEY NONCLUSTERED (idHallazgo)
)
go



IF OBJECT_ID('FG35_hallazgos') IS NOT NULL
    PRINT '<<< CREATED TABLE FG35_hallazgos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG35_hallazgos >>>'
go

/* 
 * TABLE: FG35_LevantamientoDeEvidencia 
 */

CREATE TABLE FG35_LevantamientoDeEvidencia(
    idFG35                  int         IDENTITY(1,1),
    idGestion               int         NOT NULL,
    idPersonaLaboratorio    int         NOT NULL,
    fecha                   date        NOT NULL,
    hora                    datetime    NOT NULL,
    CONSTRAINT PK132 PRIMARY KEY NONCLUSTERED (idFG35)
)
go



IF OBJECT_ID('FG35_LevantamientoDeEvidencia') IS NOT NULL
    PRINT '<<< CREATED TABLE FG35_LevantamientoDeEvidencia >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG35_LevantamientoDeEvidencia >>>'
go

/* 
 * TABLE: FG36_ReunionCierreAuditoriaInterna 
 */

CREATE TABLE FG36_ReunionCierreAuditoriaInterna(
    id_fg36            int              IDENTITY(1,1),
    idGestion          int              NOT NULL,
    fecha              date             NOT NULL,
    exposicion         nvarchar(1500)    NOT NULL,
    presentacion       nvarchar(1500)    NOT NULL,
    concretar          nvarchar(500)        NOT NULL,
    otros              nvarchar(500)        NULL,
    conclusiones       nvarchar(10)      NOT NULL,
    horaTerminacion    datetime         NOT NULL,
    CONSTRAINT PK115 PRIMARY KEY NONCLUSTERED (id_fg36)
)
go



IF OBJECT_ID('FG36_ReunionCierreAuditoriaInterna') IS NOT NULL
    PRINT '<<< CREATED TABLE FG36_ReunionCierreAuditoriaInterna >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG36_ReunionCierreAuditoriaInterna >>>'
go

/* 
 * TABLE: FG36Participantes 
 */

CREATE TABLE FG36Participantes(
    idFG36Participantes    int    IDENTITY(1,1),
    id_fg36                int    NOT NULL,
    id_persona             int    NOT NULL,
    CONSTRAINT PK137 PRIMARY KEY NONCLUSTERED (idFG36Participantes)
)
go



IF OBJECT_ID('FG36Participantes') IS NOT NULL
    PRINT '<<< CREATED TABLE FG36Participantes >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG36Participantes >>>'
go

/* 
 * TABLE: FG37_InformeAuditoriaInterna 
 */

CREATE TABLE FG37_InformeAuditoriaInterna(
    idFG37                 int          IDENTITY(1,1),
    idGestion              int          NOT NULL,
    fecha                  date         NOT NULL,
    hora                   datetime     NOT NULL,
    alcance                nvarchar(250)    NOT NULL,
    objetivo               nvarchar(250)    NOT NULL,
    referenciaNormativa    nvarchar(250)    NOT NULL,
    observaciones          nvarchar(500)    NOT NULL,
    noConformidades        nvarchar(500)    NOT NULL,
    conclusiones           nvarchar(500)    NOT NULL,
    CONSTRAINT PK118 PRIMARY KEY NONCLUSTERED (idFG37)
)
go



IF OBJECT_ID('FG37_InformeAuditoriaInterna') IS NOT NULL
    PRINT '<<< CREATED TABLE FG37_InformeAuditoriaInterna >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG37_InformeAuditoriaInterna >>>'
go

/* 
 * TABLE: FG37Participantes 
 */

CREATE TABLE FG37Participantes(
    idFG37Participantes    int    IDENTITY(1,1),
    idFG37                 int    NOT NULL,
    id_persona             int    NOT NULL,
    CONSTRAINT PK139 PRIMARY KEY NONCLUSTERED (idFG37Participantes)
)
go



IF OBJECT_ID('FG37Participantes') IS NOT NULL
    PRINT '<<< CREATED TABLE FG37Participantes >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG37Participantes >>>'
go

/* 
 * TABLE: FG38_CumplimientoDeObjetivos 
 */

CREATE TABLE FG38_CumplimientoDeObjetivos(
    idFG38       int    IDENTITY(1,1),
    idGestion    int    NOT NULL,
    CONSTRAINT PK140 PRIMARY KEY NONCLUSTERED (idFG38)
)
go



IF OBJECT_ID('FG38_CumplimientoDeObjetivos') IS NOT NULL
    PRINT '<<< CREATED TABLE FG38_CumplimientoDeObjetivos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG38_CumplimientoDeObjetivos >>>'
go

/* 
 * TABLE: FG38_Detalle 
 */

CREATE TABLE FG38_Detalle(
    idFG38Detalle    int           IDENTITY(1,1),
    idFG38           int           NOT NULL,
    Objetivos        nvarchar(150)     NOT NULL,
    ValorActual      nvarchar(10)      NOT NULL,
    Metas            nvarchar(1000)    NOT NULL,
    observaciones    nvarchar(1000)    NOT NULL,
    CONSTRAINT PK141 PRIMARY KEY NONCLUSTERED (idFG38Detalle)
)
go



IF OBJECT_ID('FG38_Detalle') IS NOT NULL
    PRINT '<<< CREATED TABLE FG38_Detalle >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG38_Detalle >>>'
go

/* 
 * TABLE: FG38_Involucrados 
 */

CREATE TABLE FG38_Involucrados(
    idF38Involucrado    int    IDENTITY(1,1),
    idFG38              int    NOT NULL,
    id_persona          int    NOT NULL,
    CONSTRAINT PK144 PRIMARY KEY NONCLUSTERED (idF38Involucrado)
)
go



IF OBJECT_ID('FG38_Involucrados') IS NOT NULL
    PRINT '<<< CREATED TABLE FG38_Involucrados >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG38_Involucrados >>>'
go

/* 
 * TABLE: FG39_AccionesCorrectivasYPreventivas 
 */

CREATE TABLE FG39_AccionesCorrectivasYPreventivas(
    idFG39        int    IDENTITY(1,1),
    idGestion     int    NOT NULL,
    id_persona    int    NOT NULL,
    CONSTRAINT PK142 PRIMARY KEY NONCLUSTERED (idFG39)
)
go



IF OBJECT_ID('FG39_AccionesCorrectivasYPreventivas') IS NOT NULL
    PRINT '<<< CREATED TABLE FG39_AccionesCorrectivasYPreventivas >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG39_AccionesCorrectivasYPreventivas >>>'
go

/* 
 * TABLE: FG39_Detalle 
 */

CREATE TABLE FG39_Detalle(
    idFG39Detalle    int    IDENTITY(1,1),
    idFG39           int    NOT NULL,
    Defiidad         int    NOT NULL,
    enProceso        int    NOT NULL,
    cerradas         int    NOT NULL,
    CONSTRAINT PK143 PRIMARY KEY NONCLUSTERED (idFG39Detalle)
)
go



IF OBJECT_ID('FG39_Detalle') IS NOT NULL
    PRINT '<<< CREATED TABLE FG39_Detalle >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG39_Detalle >>>'
go

/* 
 * TABLE: FG40_CambiosQuePuedanAfectarAllSGC 
 */

CREATE TABLE FG40_CambiosQuePuedanAfectarAllSGC(
    idFG40        int    IDENTITY(1,1),
    idGestion     int    NOT NULL,
    id_persona    int    NOT NULL,
    CONSTRAINT PK142_1 PRIMARY KEY NONCLUSTERED (idFG40)
)
go



IF OBJECT_ID('FG40_CambiosQuePuedanAfectarAllSGC') IS NOT NULL
    PRINT '<<< CREATED TABLE FG40_CambiosQuePuedanAfectarAllSGC >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG40_CambiosQuePuedanAfectarAllSGC >>>'
go

/* 
 * TABLE: FG40_Detalle 
 */

CREATE TABLE FG40_Detalle(
    idFG40Detalle                   int           IDENTITY(1,1),
    idFG40                          int           NOT NULL,
    legislacion                     nvarchar(1000)    NOT NULL,
    cambionMetodologiaOServicios    nvarchar(1000)    NOT NULL,
    cambiosEstructuraUOtros         nvarchar(1000)    NOT NULL,
    noHay                           nvarchar(1000)    NOT NULL,
    CONSTRAINT PK146 PRIMARY KEY NONCLUSTERED (idFG40Detalle)
)
go



IF OBJECT_ID('FG40_Detalle') IS NOT NULL
    PRINT '<<< CREATED TABLE FG40_Detalle >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG40_Detalle >>>'
go

/* 
 * TABLE: FG41_Detalle 
 */

CREATE TABLE FG41_Detalle(
    idFG41Detalle         int              IDENTITY(1,1),
    idArea                int              NOT NULL,
    id_persona            int              NOT NULL,
    accionesPropuestas    nvarchar(1000)    NOT NULL,
    CONSTRAINT PK148 PRIMARY KEY NONCLUSTERED (idFG41Detalle)
)
go



IF OBJECT_ID('FG41_Detalle') IS NOT NULL
    PRINT '<<< CREATED TABLE FG41_Detalle >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG41_Detalle >>>'
go

/* 
 * TABLE: FG41_RecomendacionesDeMejora 
 */

CREATE TABLE FG41_RecomendacionesDeMejora(
    idFG41        int    IDENTITY(1,1),
    idGestion     int    NOT NULL,
    id_persona    int    NOT NULL,
    CONSTRAINT PK147 PRIMARY KEY NONCLUSTERED (idFG41)
)
go



IF OBJECT_ID('FG41_RecomendacionesDeMejora') IS NOT NULL
    PRINT '<<< CREATED TABLE FG41_RecomendacionesDeMejora >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG41_RecomendacionesDeMejora >>>'
go

/* 
 * TABLE: FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia 
 */

CREATE TABLE FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia(
    idFG42        int    IDENTITY(1,1),
    idGestion     int    NOT NULL,
    id_persona    int    NOT NULL,
    CONSTRAINT PK150 PRIMARY KEY NONCLUSTERED (idFG42)
)
go



IF OBJECT_ID('FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia') IS NOT NULL
    PRINT '<<< CREATED TABLE FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia >>>'
go

/* 
 * TABLE: FG42_Estados 
 */

CREATE TABLE FG42_Estados(
    idEstados      int          IDENTITY(1,1),
    Descripcion    nvarchar(100)    NOT NULL,
    CONSTRAINT PK152 PRIMARY KEY NONCLUSTERED (idEstados)
)
go



IF OBJECT_ID('FG42_Estados') IS NOT NULL
    PRINT '<<< CREATED TABLE FG42_Estados >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG42_Estados >>>'
go

/* 
 * TABLE: FG42Detalle 
 */

CREATE TABLE FG42Detalle(
    idFG42Detalle              int         IDENTITY(1,1),
    idFG42                     int         NOT NULL,
    idEstados                  int         NOT NULL,
    id_persona                 int         NOT NULL,
    compromisosEstablecidos    nvarchar(10)    NOT NULL,
    observaciones              nvarchar(10)    NOT NULL,
    CONSTRAINT PK151 PRIMARY KEY NONCLUSTERED (idFG42Detalle)
)
go



IF OBJECT_ID('FG42Detalle') IS NOT NULL
    PRINT '<<< CREATED TABLE FG42Detalle >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG42Detalle >>>'
go

/* 
 * TABLE: FG43_Detalle 
 */

CREATE TABLE FG43_Detalle(
    idFG43Detalle               int           IDENTITY(1,1),
    idFG43                      int           NOT NULL,
    noConformidadesDefinidas    int           NOT NULL,
    noConformidadesCerradas     int           NOT NULL,
    observaciones               nvarchar(1000)    NULL,
    CONSTRAINT PK154 PRIMARY KEY NONCLUSTERED (idFG43Detalle)
)
go



IF OBJECT_ID('FG43_Detalle') IS NOT NULL
    PRINT '<<< CREATED TABLE FG43_Detalle >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG43_Detalle >>>'
go

/* 
 * TABLE: FG43_EstadoDeEnsayosYCalibracionesNoConformes 
 */

CREATE TABLE FG43_EstadoDeEnsayosYCalibracionesNoConformes(
    idFG43        int    IDENTITY(1,1),
    id_persona    int    NOT NULL,
    idGestion     int    NOT NULL,
    CONSTRAINT PK153 PRIMARY KEY NONCLUSTERED (idFG43)
)
go



IF OBJECT_ID('FG43_EstadoDeEnsayosYCalibracionesNoConformes') IS NOT NULL
    PRINT '<<< CREATED TABLE FG43_EstadoDeEnsayosYCalibracionesNoConformes >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG43_EstadoDeEnsayosYCalibracionesNoConformes >>>'
go

/* 
 * TABLE: FG44_Detalles 
 */

CREATE TABLE FG44_Detalles(
    idFG44Detalles      int           IDENTITY(1,1),
    idFG44              int           NOT NULL,
    id_persona          int           NOT NULL,
    descripcion         nvarchar(1000)    NOT NULL,
    accionesdeMejora    nvarchar(1000)    NOT NULL,
    fechaInicio         date          NOT NULL,
    fechaFin            date          NOT NULL,
    recursos            nvarchar(1000)    NOT NULL,
    CONSTRAINT PK156 PRIMARY KEY NONCLUSTERED (idFG44Detalles)
)
go



IF OBJECT_ID('FG44_Detalles') IS NOT NULL
    PRINT '<<< CREATED TABLE FG44_Detalles >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG44_Detalles >>>'
go

/* 
 * TABLE: FG44_Participantes 
 */

CREATE TABLE FG44_Participantes(
    idFG44Participantes    int    IDENTITY(1,1),
    id_persona             int    NOT NULL,
    idFG44                 int    NOT NULL,
    CONSTRAINT PK157 PRIMARY KEY NONCLUSTERED (idFG44Participantes)
)
go



IF OBJECT_ID('FG44_Participantes') IS NOT NULL
    PRINT '<<< CREATED TABLE FG44_Participantes >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG44_Participantes >>>'
go

/* 
 * TABLE: FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion 
 */

CREATE TABLE FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion(
    idFG44       int    IDENTITY(1,1),
    idGestion    int    NOT NULL,
    CONSTRAINT PK155 PRIMARY KEY NONCLUSTERED (idFG44)
)
go



IF OBJECT_ID('FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion') IS NOT NULL
    PRINT '<<< CREATED TABLE FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion >>>'
go

/* 
 * TABLE: FG45_Participantes 
 */

CREATE TABLE FG45_Participantes(
    idFG45Participantes    int    IDENTITY(1,1),
    idFG45                 int    NOT NULL,
    id_persona             int    NOT NULL,
    CONSTRAINT PK158 PRIMARY KEY NONCLUSTERED (idFG45Participantes)
)
go



IF OBJECT_ID('FG45_Participantes') IS NOT NULL
    PRINT '<<< CREATED TABLE FG45_Participantes >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG45_Participantes >>>'
go

/* 
 * TABLE: FG45_RevisionPorLaDireccion 
 */

CREATE TABLE FG45_RevisionPorLaDireccion(
    idFG45       int    IDENTITY(1,1),
    idGestion    int    NOT NULL,
    CONSTRAINT PK159 PRIMARY KEY NONCLUSTERED (idFG45)
)
go



IF OBJECT_ID('FG45_RevisionPorLaDireccion') IS NOT NULL
    PRINT '<<< CREATED TABLE FG45_RevisionPorLaDireccion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FG45_RevisionPorLaDireccion >>>'
go

/* 
 * TABLE: FormatoGestion 
 */

CREATE TABLE FormatoGestion(
    idCodigoFG    int             IDENTITY(1,1),
    idProceso     int             NOT NULL,
    codigo        nvarchar(10)    NOT NULL,
    CONSTRAINT PK14 PRIMARY KEY NONCLUSTERED (idCodigoFG)
)
go



IF OBJECT_ID('FormatoGestion') IS NOT NULL
    PRINT '<<< CREATED TABLE FormatoGestion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FormatoGestion >>>'
go

/* 
 * TABLE: FormatoPlantilla 
 */

CREATE TABLE FormatoPlantilla(
    idFormato          int              IDENTITY(1,1),
    idCodigoFG         int              NOT NULL,
    titulo             nvarchar(150)    NOT NULL,
    cuerpoDocumento    nvarchar(max)    NOT NULL,
    fechaCreacion      datetime         NOT NULL,
    version            float            NOT NULL,
    obsoleto           bit              NOT NULL,
    solicitudCambio    bit              NOT NULL,
    activo             bit              NOT NULL,
    CONSTRAINT PK15 PRIMARY KEY NONCLUSTERED (idFormato)
)
go



IF OBJECT_ID('FormatoPlantilla') IS NOT NULL
    PRINT '<<< CREATED TABLE FormatoPlantilla >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE FormatoPlantilla >>>'
go

/* 
 * TABLE: Gestion 
 */

CREATE TABLE Gestion(
    idGestion    int     IDENTITY(1,1),
    idProceso    int     NOT NULL,
    idFormato    int     NOT NULL,
    fecha        date    NOT NULL,
    anulada      bit     NOT NULL,
    CONSTRAINT PK17 PRIMARY KEY NONCLUSTERED (idGestion)
)
go



IF OBJECT_ID('Gestion') IS NOT NULL
    PRINT '<<< CREATED TABLE Gestion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Gestion >>>'
go

/* 
 * TABLE: Involucrado 
 */

CREATE TABLE Involucrado(
    idPersonal    int    IDENTITY(1,1),
    id_persona    int    NOT NULL,
    idProceso     int    NOT NULL,
    CONSTRAINT PK18 PRIMARY KEY NONCLUSTERED (idPersonal)
)
go



IF OBJECT_ID('Involucrado') IS NOT NULL
    PRINT '<<< CREATED TABLE Involucrado >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Involucrado >>>'
go

/* 
 * TABLE: Involucrados 
 */

CREATE TABLE Involucrados(
    idInvolucrado    int    IDENTITY(1,1),
    idFG35           int    NOT NULL,
    id_persona       int    NOT NULL,
    CONSTRAINT PK134 PRIMARY KEY NONCLUSTERED (idInvolucrado)
)
go



IF OBJECT_ID('Involucrados') IS NOT NULL
    PRINT '<<< CREATED TABLE Involucrados >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Involucrados >>>'
go

/* 
 * TABLE: Laboratorio 
 */

CREATE TABLE Laboratorio(
    idLaboratorio    int         IDENTITY(1,1),
    nombreLab        nvarchar(25)    NOT NULL,
    activo           bit         NOT NULL,
    CONSTRAINT PK8 PRIMARY KEY NONCLUSTERED (idLaboratorio)
)
go



IF OBJECT_ID('Laboratorio') IS NOT NULL
    PRINT '<<< CREATED TABLE Laboratorio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Laboratorio >>>'
go

/* 
 * TABLE: MarcaInstrumento 
 */

CREATE TABLE MarcaInstrumento(
    idMarcaInstrumento    int         IDENTITY(1,1),
    marcaInstrumento      nvarchar(30)    NOT NULL,
    activo                bit         NOT NULL,
    CONSTRAINT PK56 PRIMARY KEY NONCLUSTERED (idMarcaInstrumento)
)
go



IF OBJECT_ID('MarcaInstrumento') IS NOT NULL
    PRINT '<<< CREATED TABLE MarcaInstrumento >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE MarcaInstrumento >>>'
go

/* 
 * TABLE: ModeloEquipo 
 */

CREATE TABLE ModeloEquipo(
    idModeloEquipo    int         IDENTITY(1,1),
    modeloEquipo      nvarchar(25)    NULL,
    acivo             bit         NOT NULL,
    CONSTRAINT PK46 PRIMARY KEY NONCLUSTERED (idModeloEquipo)
)
go



IF OBJECT_ID('ModeloEquipo') IS NOT NULL
    PRINT '<<< CREATED TABLE ModeloEquipo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE ModeloEquipo >>>'
go

/* 
 * TABLE: MotivacionInteres 
 */

CREATE TABLE MotivacionInteres(
    idMotivacion    int    IDENTITY(1,1),
    idFG23          int    NOT NULL,
    idSeleccion     int    NOT NULL,
    CONSTRAINT PK77 PRIMARY KEY NONCLUSTERED (idMotivacion)
)
go



IF OBJECT_ID('MotivacionInteres') IS NOT NULL
    PRINT '<<< CREATED TABLE MotivacionInteres >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE MotivacionInteres >>>'
go

/* 
 * TABLE: Opcion 
 */

CREATE TABLE Opcion(
    idOpcion      int         IDENTITY(1,1),
    opcion        nvarchar(10)    NOT NULL,
    disponible    bit         NOT NULL,
    CONSTRAINT PK94 PRIMARY KEY NONCLUSTERED (idOpcion)
)
go



IF OBJECT_ID('Opcion') IS NOT NULL
    PRINT '<<< CREATED TABLE Opcion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Opcion >>>'
go

/* 
 * TABLE: Persona 
 */

CREATE TABLE Persona(
    id_persona          int         IDENTITY(1,1),
    idCargo             int         NOT NULL,
    cedula              nvarchar(20)    NOT NULL,
    nombres             nvarchar(50)    NOT NULL,
    apellido_paterno    nvarchar(50)    NOT NULL,
    apellidoMaterno     nvarchar(50)    NULL,
    telefono            nvarchar(15)    NULL,
    activo              bit         NOT NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (id_persona)
)
go



IF OBJECT_ID('Persona') IS NOT NULL
    PRINT '<<< CREATED TABLE Persona >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Persona >>>'
go

/* 
 * TABLE: PersonaLaboratorio 
 */

CREATE TABLE PersonaLaboratorio(
    idPersonaLaboratorio    int    IDENTITY(1,1),
    idLaboratorio           int    NOT NULL,
    id_persona              int    NOT NULL,
    CONSTRAINT PK41 PRIMARY KEY NONCLUSTERED (idPersonaLaboratorio)
)
go



IF OBJECT_ID('PersonaLaboratorio') IS NOT NULL
    PRINT '<<< CREATED TABLE PersonaLaboratorio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE PersonaLaboratorio >>>'
go

/* 
 * TABLE: Pregunta 
 */

CREATE TABLE Pregunta(
    idPregunta     int         IDENTITY(1,1),
    descripcion    nvarchar(25)    NOT NULL,
    activa         bit         NOT NULL,
    CONSTRAINT PK92 PRIMARY KEY NONCLUSTERED (idPregunta)
)
go



IF OBJECT_ID('Pregunta') IS NOT NULL
    PRINT '<<< CREATED TABLE Pregunta >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Pregunta >>>'
go

/* 
 * TABLE: PrestacionServicio 
 */

CREATE TABLE PrestacionServicio(
    idPrestacion     int    NOT NULL,
    idFG23           int    NOT NULL,
    idSeleccion      int    NOT NULL,
    idSatifaccion    int    NOT NULL,
    CONSTRAINT PK74 PRIMARY KEY NONCLUSTERED (idPrestacion)
)
go



IF OBJECT_ID('PrestacionServicio') IS NOT NULL
    PRINT '<<< CREATED TABLE PrestacionServicio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE PrestacionServicio >>>'
go

/* 
 * TABLE: Proceso 
 */

CREATE TABLE Proceso(
    idProceso          int     IDENTITY(1,1),
    idEstadoGestion    int     NULL,
    idCliente          int     NULL,
    fechaInicio        date    NOT NULL,
    fechaFin           date    NULL,
    anulado            bit     NOT NULL,
    CONSTRAINT PK161 PRIMARY KEY NONCLUSTERED (idProceso)
)
go



IF OBJECT_ID('Proceso') IS NOT NULL
    PRINT '<<< CREATED TABLE Proceso >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Proceso >>>'
go

/* 
 * TABLE: ProcesoGestion 
 */

CREATE TABLE ProcesoGestion(
    idProceso        int          IDENTITY(1,1),
    codigoProceso    nvarchar(20)     NOT NULL,
    significado      nvarchar(150)    NOT NULL,
    CONSTRAINT PK13 PRIMARY KEY NONCLUSTERED (idProceso)
)
go



IF OBJECT_ID('ProcesoGestion') IS NOT NULL
    PRINT '<<< CREATED TABLE ProcesoGestion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE ProcesoGestion >>>'
go

/* 
 * TABLE: Proveedores 
 */

CREATE TABLE Proveedores(
    idProveedor            int          IDENTITY(1,1),
    productoServicio       nvarchar(100)    NOT NULL,
    direccion              nvarchar(100)    NOT NULL,
    telefono               nvarchar(20)     NOT NULL,
    nombreContacto         nvarchar(100)    NOT NULL,
    email                  nvarchar(150)    NOT NULL,
    fechaIngreso           date         NOT NULL,
    proveedorCalificado    bit          NOT NULL,
    activo                 bit          NOT NULL,
    CONSTRAINT PK60 PRIMARY KEY NONCLUSTERED (idProveedor)
)
go



IF OBJECT_ID('Proveedores') IS NOT NULL
    PRINT '<<< CREATED TABLE Proveedores >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Proveedores >>>'
go

/* 
 * TABLE: ProveedoresCalificados 
 */

CREATE TABLE ProveedoresCalificados(
    idProvCalf     int    IDENTITY(1,1),
    idFG18         int    NOT NULL,
    idProveedor    int    NOT NULL,
    CONSTRAINT PK79 PRIMARY KEY NONCLUSTERED (idProvCalf)
)
go



IF OBJECT_ID('ProveedoresCalificados') IS NOT NULL
    PRINT '<<< CREATED TABLE ProveedoresCalificados >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE ProveedoresCalificados >>>'
go

/* 
 * TABLE: Puntualidad 
 */

CREATE TABLE Puntualidad(
    idPuntualidad    int    IDENTITY(1,1),
    idFG23           int    NOT NULL,
    idSeleccion      int    NOT NULL,
    idSatifaccion    int    NOT NULL,
    CONSTRAINT PK75 PRIMARY KEY NONCLUSTERED (idPuntualidad)
)
go



IF OBJECT_ID('Puntualidad') IS NOT NULL
    PRINT '<<< CREATED TABLE Puntualidad >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Puntualidad >>>'
go

/* 
 * TABLE: Representante 
 */

CREATE TABLE Representante(
    idRepresentante    int    IDENTITY(1,1),
    id_persona         int    NOT NULL,
    idFG10             int    NOT NULL,
    CONSTRAINT PK52 PRIMARY KEY NONCLUSTERED (idRepresentante)
)
go



IF OBJECT_ID('Representante') IS NOT NULL
    PRINT '<<< CREATED TABLE Representante >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Representante >>>'
go

/* 
 * TABLE: Riesgos 
 */

CREATE TABLE Riesgos(
    idRiesgo       int          IDENTITY(1,1),
    codigo         nvarchar(25)     NOT NULL,
    descripcion    nvarchar(100)    NULL,
    CONSTRAINT PK29 PRIMARY KEY NONCLUSTERED (idRiesgo)
)
go



IF OBJECT_ID('Riesgos') IS NOT NULL
    PRINT '<<< CREATED TABLE Riesgos >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Riesgos >>>'
go

/* 
 * TABLE: Satisfactorio 
 */

CREATE TABLE Satisfactorio(
    idSatifaccion    int         IDENTITY(1,1),
    satisfecho       bit         NOT NULL,
    explicacion      nvarchar(10)    NULL,
    CONSTRAINT PK95 PRIMARY KEY NONCLUSTERED (idSatifaccion)
)
go



IF OBJECT_ID('Satisfactorio') IS NOT NULL
    PRINT '<<< CREATED TABLE Satisfactorio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Satisfactorio >>>'
go

/* 
 * TABLE: Seleccion 
 */

CREATE TABLE Seleccion(
    idSeleccion    int    IDENTITY(1,1),
    idPregunta     int    NOT NULL,
    idOpcion       int    NOT NULL,
    CONSTRAINT PK93 PRIMARY KEY NONCLUSTERED (idSeleccion)
)
go



IF OBJECT_ID('Seleccion') IS NOT NULL
    PRINT '<<< CREATED TABLE Seleccion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Seleccion >>>'
go

/* 
 * TABLE: TipoCliente 
 */

CREATE TABLE TipoCliente(
    idTipoCliente    int         IDENTITY(1,1),
    tipo_cliente     nvarchar(50)    NOT NULL,
    activo           bit         NOT NULL,
    CONSTRAINT PK11 PRIMARY KEY NONCLUSTERED (idTipoCliente)
)
go



IF OBJECT_ID('TipoCliente') IS NOT NULL
    PRINT '<<< CREATED TABLE TipoCliente >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE TipoCliente >>>'
go

/* 
 * TABLE: TipoEquipo 
 */

CREATE TABLE TipoEquipo(
    idTipoEquipo    int         IDENTITY(1,1),
    tipoEquipo      nvarchar(25)    NOT NULL,
    activo          bit         NOT NULL,
    CONSTRAINT PK44_1 PRIMARY KEY NONCLUSTERED (idTipoEquipo)
)
go



IF OBJECT_ID('TipoEquipo') IS NOT NULL
    PRINT '<<< CREATED TABLE TipoEquipo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE TipoEquipo >>>'
go

/* 
 * TABLE: TipoRadiacion 
 */

CREATE TABLE TipoRadiacion(
    idTipoRadiacion    int         IDENTITY(1,1),
    tipo               nvarchar(50)    NOT NULL,
    activo             bit         NOT NULL,
    CONSTRAINT PK16 PRIMARY KEY NONCLUSTERED (idTipoRadiacion)
)
go



IF OBJECT_ID('TipoRadiacion') IS NOT NULL
    PRINT '<<< CREATED TABLE TipoRadiacion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE TipoRadiacion >>>'
go

/* 
 * TABLE: TiposConflicto 
 */

CREATE TABLE TiposConflicto(
    idTipoConflicto    int          IDENTITY(1,1),
    descripcion        nvarchar(250)    NOT NULL,
    CONSTRAINT PK28 PRIMARY KEY NONCLUSTERED (idTipoConflicto)
)
go



IF OBJECT_ID('TiposConflicto') IS NOT NULL
    PRINT '<<< CREATED TABLE TiposConflicto >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE TiposConflicto >>>'
go

/* 
 * TABLE: TipoServicio 
 */

CREATE TABLE TipoServicio(
    idTipoServicio    int          IDENTITY(1,1),
    tipo_servicio     nvarchar(250)    NOT NULL,
    activo            bit          NOT NULL,
    CONSTRAINT PK52_1 PRIMARY KEY NONCLUSTERED (idTipoServicio)
)
go



IF OBJECT_ID('TipoServicio') IS NOT NULL
    PRINT '<<< CREATED TABLE TipoServicio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE TipoServicio >>>'
go

/* 
 * TABLE: TipoSolicitud 
 */

CREATE TABLE TipoSolicitud(
    idTipo         int          IDENTITY(1,1),
    descripcion    nvarchar(100)    NOT NULL,
    activo         bit          NOT NULL,
    CONSTRAINT PK37 PRIMARY KEY NONCLUSTERED (idTipo)
)
go



IF OBJECT_ID('TipoSolicitud') IS NOT NULL
    PRINT '<<< CREATED TABLE TipoSolicitud >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE TipoSolicitud >>>'
go

/* 
 * TABLE: TipoVisita 
 */

CREATE TABLE TipoVisita(
    idTipoVisita    int         IDENTITY(1,1),
    descripcion     nvarchar(25)    NOT NULL,
    activo          bit         NOT NULL,
    CONSTRAINT PK15_1 PRIMARY KEY NONCLUSTERED (idTipoVisita)
)
go



IF OBJECT_ID('TipoVisita') IS NOT NULL
    PRINT '<<< CREATED TABLE TipoVisita >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE TipoVisita >>>'
go

/* 
 * TABLE: Actividades 
 */

ALTER TABLE Actividades ADD CONSTRAINT RefFG03_ConflictoInteres34 
    FOREIGN KEY (idFG03)
    REFERENCES FG03_ConflictoInteres(idFG03)
go


/* 
 * TABLE: AreaLaboratorio 
 */

ALTER TABLE AreaLaboratorio ADD CONSTRAINT RefLaboratorio54 
    FOREIGN KEY (idLaboratorio)
    REFERENCES Laboratorio(idLaboratorio)
go


/* 
 * TABLE: Cliente 
 */

ALTER TABLE Cliente ADD CONSTRAINT RefTipoCliente70 
    FOREIGN KEY (idTipoCliente)
    REFERENCES TipoCliente(idTipoCliente)
go


/* 
 * TABLE: ClienteRadiacion 
 */

ALTER TABLE ClienteRadiacion ADD CONSTRAINT RefCliente71 
    FOREIGN KEY (idCliente)
    REFERENCES Cliente(idCliente)
go

ALTER TABLE ClienteRadiacion ADD CONSTRAINT RefTipoRadiacion176 
    FOREIGN KEY (idTipoRadiacion)
    REFERENCES TipoRadiacion(idTipoRadiacion)
go


/* 
 * TABLE: Consanguiniedad 
 */

ALTER TABLE Consanguiniedad ADD CONSTRAINT RefFG03_ConflictoInteres36 
    FOREIGN KEY (idFG03)
    REFERENCES FG03_ConflictoInteres(idFG03)
go


/* 
 * TABLE: DetalleFG13 
 */

ALTER TABLE DetalleFG13 ADD CONSTRAINT RefFG13_ProformaServicio93 
    FOREIGN KEY (idFG13)
    REFERENCES FG13_ProformaServicio(idFG13)
go


/* 
 * TABLE: Equipo 
 */

ALTER TABLE Equipo ADD CONSTRAINT RefMarcaInstrumento84 
    FOREIGN KEY (idMarcaInstrumento)
    REFERENCES MarcaInstrumento(idMarcaInstrumento)
go

ALTER TABLE Equipo ADD CONSTRAINT RefTipoEquipo85 
    FOREIGN KEY (idTipoEquipo)
    REFERENCES TipoEquipo(idTipoEquipo)
go

ALTER TABLE Equipo ADD CONSTRAINT ReffabricanteEquipo86 
    FOREIGN KEY (idFabricanteEquipo)
    REFERENCES fabricanteEquipo(idFabricanteEquipo)
go

ALTER TABLE Equipo ADD CONSTRAINT RefModeloEquipo87 
    FOREIGN KEY (idModeloEquipo)
    REFERENCES ModeloEquipo(idModeloEquipo)
go


/* 
 * TABLE: EquiposEntrega 
 */

ALTER TABLE EquiposEntrega ADD CONSTRAINT RefFG12_EntregaEquipos91 
    FOREIGN KEY (idFG12)
    REFERENCES FG12_EntregaEquipos(idFG12)
go

ALTER TABLE EquiposEntrega ADD CONSTRAINT RefEquipo92 
    FOREIGN KEY (idEquipo)
    REFERENCES Equipo(idEquipo)
go


/* 
 * TABLE: EvaluacionCertificados 
 */

ALTER TABLE EvaluacionCertificados ADD CONSTRAINT RefFG23_SatisfaccionCliente145 
    FOREIGN KEY (idFG23)
    REFERENCES FG23_SatisfaccionCliente(idFG23)
go

ALTER TABLE EvaluacionCertificados ADD CONSTRAINT RefSeleccion152 
    FOREIGN KEY (idSeleccion)
    REFERENCES Seleccion(idSeleccion)
go

ALTER TABLE EvaluacionCertificados ADD CONSTRAINT RefSatisfactorio157 
    FOREIGN KEY (idSatifaccion)
    REFERENCES Satisfactorio(idSatifaccion)
go


/* 
 * TABLE: Evaluadores 
 */

ALTER TABLE Evaluadores ADD CONSTRAINT RefFG33_PlanAuditoriaInterna206 
    FOREIGN KEY (idFG33PlanAuditoria)
    REFERENCES FG33_PlanAuditoriaInterna(idFG33PlanAuditoria)
go

ALTER TABLE Evaluadores ADD CONSTRAINT RefPersona207 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG01_CCompromiso 
 */

ALTER TABLE FG01_CCompromiso ADD CONSTRAINT RefGestion28 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG01_CCompromiso ADD CONSTRAINT RefPersona269 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG02_CConfidencialidad 
 */

ALTER TABLE FG02_CConfidencialidad ADD CONSTRAINT RefGestion30 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG02_CConfidencialidad ADD CONSTRAINT RefTipoVisita33 
    FOREIGN KEY (idTipoVisita)
    REFERENCES TipoVisita(idTipoVisita)
go

ALTER TABLE FG02_CConfidencialidad ADD CONSTRAINT RefPersona270 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG03_ConflictoInteres 
 */

ALTER TABLE FG03_ConflictoInteres ADD CONSTRAINT RefGestion35 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG04_ConflictoInteres 
 */

ALTER TABLE FG04_ConflictoInteres ADD CONSTRAINT RefTiposConflicto37 
    FOREIGN KEY (idTipoConflicto)
    REFERENCES TiposConflicto(idTipoConflicto)
go

ALTER TABLE FG04_ConflictoInteres ADD CONSTRAINT RefGestion38 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG05_MatrizDeRiesgos 
 */

ALTER TABLE FG05_MatrizDeRiesgos ADD CONSTRAINT RefRiesgos41 
    FOREIGN KEY (idRiesgo)
    REFERENCES Riesgos(idRiesgo)
go

ALTER TABLE FG05_MatrizDeRiesgos ADD CONSTRAINT RefGestion43 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG06_TratamientoRiesgos 
 */

ALTER TABLE FG06_TratamientoRiesgos ADD CONSTRAINT RefGestion46 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG06Detalle 
 */

ALTER TABLE FG06Detalle ADD CONSTRAINT RefFG06_TratamientoRiesgos45 
    FOREIGN KEY (idFG06)
    REFERENCES FG06_TratamientoRiesgos(idFG06)
go


/* 
 * TABLE: FG08_SolicitudCME 
 */

ALTER TABLE FG08_SolicitudCME ADD CONSTRAINT RefGestion178 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG08_SolicitudCME ADD CONSTRAINT RefPersona202 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG08Detalle 
 */

ALTER TABLE FG08Detalle ADD CONSTRAINT RefFG08_SolicitudCME47 
    FOREIGN KEY (idFG08)
    REFERENCES FG08_SolicitudCME(idFG08)
go

ALTER TABLE FG08Detalle ADD CONSTRAINT RefTipoSolicitud48 
    FOREIGN KEY (idTipo)
    REFERENCES TipoSolicitud(idTipo)
go

ALTER TABLE FG08Detalle ADD CONSTRAINT RefFormatoPlantilla60 
    FOREIGN KEY (idFormato)
    REFERENCES FormatoPlantilla(idFormato)
go


/* 
 * TABLE: FG09_ControlCambios 
 */

ALTER TABLE FG09_ControlCambios ADD CONSTRAINT RefGestion55 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG09HistoricoCambios 
 */

ALTER TABLE FG09HistoricoCambios ADD CONSTRAINT RefFG09_ControlCambios179 
    FOREIGN KEY (IdFG09)
    REFERENCES FG09_ControlCambios(IdFG09)
go

ALTER TABLE FG09HistoricoCambios ADD CONSTRAINT RefFG08Detalle56 
    FOREIGN KEY (idFG08Detalle)
    REFERENCES FG08Detalle(idFG08Detalle)
go

ALTER TABLE FG09HistoricoCambios ADD CONSTRAINT RefFormatoPlantilla57 
    FOREIGN KEY (idFormato)
    REFERENCES FormatoPlantilla(idFormato)
go


/* 
 * TABLE: FG10_SolicitudDosExterna 
 */

ALTER TABLE FG10_SolicitudDosExterna ADD CONSTRAINT RefGestion75 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG10_SolicitudDosExterna ADD CONSTRAINT RefCliente79 
    FOREIGN KEY (idCliente)
    REFERENCES Cliente(idCliente)
go


/* 
 * TABLE: FG10Estados 
 */

ALTER TABLE FG10Estados ADD CONSTRAINT RefEstadoSolicitud77 
    FOREIGN KEY (idEstadoSolicitud)
    REFERENCES EstadoSolicitud(idEstadoSolicitud)
go

ALTER TABLE FG10Estados ADD CONSTRAINT RefFG10_SolicitudDosExterna78 
    FOREIGN KEY (idFG10)
    REFERENCES FG10_SolicitudDosExterna(idFG10)
go


/* 
 * TABLE: FG10Portadores 
 */

ALTER TABLE FG10Portadores ADD CONSTRAINT RefFG10_SolicitudDosExterna63 
    FOREIGN KEY (idFG10)
    REFERENCES FG10_SolicitudDosExterna(idFG10)
go


/* 
 * TABLE: FG10Radiaciones 
 */

ALTER TABLE FG10Radiaciones ADD CONSTRAINT RefFG10_SolicitudDosExterna74 
    FOREIGN KEY (idFG10)
    REFERENCES FG10_SolicitudDosExterna(idFG10)
go

ALTER TABLE FG10Radiaciones ADD CONSTRAINT RefTipoRadiacion180 
    FOREIGN KEY (idTipoRadiacion)
    REFERENCES TipoRadiacion(idTipoRadiacion)
go


/* 
 * TABLE: FG11_AcuerdoServicio 
 */

ALTER TABLE FG11_AcuerdoServicio ADD CONSTRAINT RefGestion82 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG11_AcuerdoServicio ADD CONSTRAINT RefFG10_SolicitudDosExterna83 
    FOREIGN KEY (idFG10)
    REFERENCES FG10_SolicitudDosExterna(idFG10)
go


/* 
 * TABLE: FG12_EntregaEquipos 
 */

ALTER TABLE FG12_EntregaEquipos ADD CONSTRAINT RefCliente90 
    FOREIGN KEY (idCliente)
    REFERENCES Cliente(idCliente)
go

ALTER TABLE FG12_EntregaEquipos ADD CONSTRAINT RefGestion97 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG13_ProformaServicio 
 */

ALTER TABLE FG13_ProformaServicio ADD CONSTRAINT RefTipoServicio94 
    FOREIGN KEY (idTipoServicio)
    REFERENCES TipoServicio(idTipoServicio)
go

ALTER TABLE FG13_ProformaServicio ADD CONSTRAINT RefGestion95 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG13_ProformaServicio ADD CONSTRAINT RefCliente96 
    FOREIGN KEY (idCliente)
    REFERENCES Cliente(idCliente)
go


/* 
 * TABLE: FG14_CalibracionDosimetrica 
 */

ALTER TABLE FG14_CalibracionDosimetrica ADD CONSTRAINT RefGestion99 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG14_CalibracionDosimetrica ADD CONSTRAINT RefCliente100 
    FOREIGN KEY (idCliente)
    REFERENCES Cliente(idCliente)
go


/* 
 * TABLE: FG14Servicios 
 */

ALTER TABLE FG14Servicios ADD CONSTRAINT RefFG14_CalibracionDosimetrica98 
    FOREIGN KEY (idFG14)
    REFERENCES FG14_CalibracionDosimetrica(idFG14)
go


/* 
 * TABLE: FG15_Especificaciones 
 */

ALTER TABLE FG15_Especificaciones ADD CONSTRAINT RefEquipo105 
    FOREIGN KEY (idEquipo)
    REFERENCES Equipo(idEquipo)
go

ALTER TABLE FG15_Especificaciones ADD CONSTRAINT RefFG15ControlServicioCalidad106 
    FOREIGN KEY (idFG15)
    REFERENCES FG15ControlServicioCalidad(idFG15)
go


/* 
 * TABLE: FG15ControlServicioCalidad 
 */

ALTER TABLE FG15ControlServicioCalidad ADD CONSTRAINT RefGestion103 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG15ControlServicioCalidad ADD CONSTRAINT RefCliente104 
    FOREIGN KEY (idCliente)
    REFERENCES Cliente(idCliente)
go


/* 
 * TABLE: FG16_Contrato 
 */

ALTER TABLE FG16_Contrato ADD CONSTRAINT RefCliente107 
    FOREIGN KEY (idCliente)
    REFERENCES Cliente(idCliente)
go

ALTER TABLE FG16_Contrato ADD CONSTRAINT RefGestion108 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG16_Contrato ADD CONSTRAINT RefFG15ControlServicioCalidad109 
    FOREIGN KEY (idFG15)
    REFERENCES FG15ControlServicioCalidad(idFG15)
go


/* 
 * TABLE: FG17_ContratoPorIncorporacion 
 */

ALTER TABLE FG17_ContratoPorIncorporacion ADD CONSTRAINT RefCliente110 
    FOREIGN KEY (idCliente)
    REFERENCES Cliente(idCliente)
go

ALTER TABLE FG17_ContratoPorIncorporacion ADD CONSTRAINT RefGestion111 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG18_ListaProveedores 
 */

ALTER TABLE FG18_ListaProveedores ADD CONSTRAINT RefGestion116 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG19_Detalle 
 */

ALTER TABLE FG19_Detalle ADD CONSTRAINT RefFG19_SeguimientoControl122 
    FOREIGN KEY (idFG19)
    REFERENCES FG19_SeguimientoControl(idFG19)
go


/* 
 * TABLE: FG19_SeguimientoControl 
 */

ALTER TABLE FG19_SeguimientoControl ADD CONSTRAINT RefGestion123 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG19_SeguimientoControl ADD CONSTRAINT RefProveedores124 
    FOREIGN KEY (idProveedor)
    REFERENCES Proveedores(idProveedor)
go


/* 
 * TABLE: FG20_ReclamoProveedor 
 */

ALTER TABLE FG20_ReclamoProveedor ADD CONSTRAINT RefGestion125 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG20_ReclamoProveedor ADD CONSTRAINT RefFG19_SeguimientoControl127 
    FOREIGN KEY (idFG19)
    REFERENCES FG19_SeguimientoControl(idFG19)
go


/* 
 * TABLE: FG21_EvaluacionInicial 
 */

ALTER TABLE FG21_EvaluacionInicial ADD CONSTRAINT RefProveedores129 
    FOREIGN KEY (idProveedor)
    REFERENCES Proveedores(idProveedor)
go

ALTER TABLE FG21_EvaluacionInicial ADD CONSTRAINT RefGestion132 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG21_Evaluadores 
 */

ALTER TABLE FG21_Evaluadores ADD CONSTRAINT RefFG21_EvaluacionInicial135 
    FOREIGN KEY (idFG21)
    REFERENCES FG21_EvaluacionInicial(idFG21)
go

ALTER TABLE FG21_Evaluadores ADD CONSTRAINT RefPersona136 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG22_EvaluacionPeri 
 */

ALTER TABLE FG22_EvaluacionPeri ADD CONSTRAINT RefProveedores130 
    FOREIGN KEY (idProveedor)
    REFERENCES Proveedores(idProveedor)
go

ALTER TABLE FG22_EvaluacionPeri ADD CONSTRAINT RefGestion133 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG22_Evaluadores 
 */

ALTER TABLE FG22_Evaluadores ADD CONSTRAINT RefPersona131 
    FOREIGN KEY (Persona_id_persona)
    REFERENCES Persona(id_persona)
go

ALTER TABLE FG22_Evaluadores ADD CONSTRAINT RefFG22_EvaluacionPeri137 
    FOREIGN KEY (idFG22)
    REFERENCES FG22_EvaluacionPeri(idFG22)
go


/* 
 * TABLE: FG23_SatisfaccionCliente 
 */

ALTER TABLE FG23_SatisfaccionCliente ADD CONSTRAINT RefGestion142 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG24_ControlQuejasApelaciones 
 */

ALTER TABLE FG24_ControlQuejasApelaciones ADD CONSTRAINT RefGestion160 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG25_Detalle 
 */

ALTER TABLE FG25_Detalle ADD CONSTRAINT RefFG25_AtencionReclamos161 
    FOREIGN KEY (idFG25)
    REFERENCES FG25_AtencionReclamos(idFG25)
go

ALTER TABLE FG25_Detalle ADD CONSTRAINT RefPersona162 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG26_Acciones 
 */

ALTER TABLE FG26_Acciones ADD CONSTRAINT RefFG26_AtencionReclamos163 
    FOREIGN KEY (idFG26)
    REFERENCES FG26_AtencionReclamos(idFG26)
go


/* 
 * TABLE: FG26_AtencionReclamos 
 */

ALTER TABLE FG26_AtencionReclamos ADD CONSTRAINT RefGestion164 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG27_TrabajosNoConformes 
 */

ALTER TABLE FG27_TrabajosNoConformes ADD CONSTRAINT RefFG27_CategoriaHallazgo165 
    FOREIGN KEY (idCategoria)
    REFERENCES FG27_CategoriaHallazgo(idCategoria)
go

ALTER TABLE FG27_TrabajosNoConformes ADD CONSTRAINT RefFG27_TiposImplementacion166 
    FOREIGN KEY (idTipoImplementacion)
    REFERENCES FG27_TiposImplementacion(idTipoImplementacion)
go

ALTER TABLE FG27_TrabajosNoConformes ADD CONSTRAINT RefGestion167 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG27_TrabajosNoConformes ADD CONSTRAINT RefLaboratorio168 
    FOREIGN KEY (idLaboratorio)
    REFERENCES Laboratorio(idLaboratorio)
go


/* 
 * TABLE: FG28_ImplementacionAcc 
 */

ALTER TABLE FG28_ImplementacionAcc ADD CONSTRAINT RefGestion173 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG28_ImplementacionAcc ADD CONSTRAINT RefLaboratorio174 
    FOREIGN KEY (idLaboratorio)
    REFERENCES Laboratorio(idLaboratorio)
go

ALTER TABLE FG28_ImplementacionAcc ADD CONSTRAINT RefPersona175 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG28_PlanAccion 
 */

ALTER TABLE FG28_PlanAccion ADD CONSTRAINT RefFG28_ImplementacionAcc169 
    FOREIGN KEY (idFG28)
    REFERENCES FG28_ImplementacionAcc(idFG28)
go

ALTER TABLE FG28_PlanAccion ADD CONSTRAINT RefPersona171 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG28_RevisionSeguimiento 
 */

ALTER TABLE FG28_RevisionSeguimiento ADD CONSTRAINT RefFG28_ImplementacionAcc170 
    FOREIGN KEY (idFG28)
    REFERENCES FG28_ImplementacionAcc(idFG28)
go

ALTER TABLE FG28_RevisionSeguimiento ADD CONSTRAINT RefPersona172 
    FOREIGN KEY (Persona_id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG29_VerificacionControl 
 */

ALTER TABLE FG29_VerificacionControl ADD CONSTRAINT RefFG29TiposRegistro182 
    FOREIGN KEY (idTipo)
    REFERENCES FG29TiposRegistro(idTipo)
go

ALTER TABLE FG29_VerificacionControl ADD CONSTRAINT RefGestion183 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG30_ProgramaAuditoria 
 */

ALTER TABLE FG30_ProgramaAuditoria ADD CONSTRAINT RefPersona186 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go

ALTER TABLE FG30_ProgramaAuditoria ADD CONSTRAINT RefGestion187 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG30DetalleAuditoria 
 */

ALTER TABLE FG30DetalleAuditoria ADD CONSTRAINT RefFG30_ProgramaAuditoria185 
    FOREIGN KEY (idFG30)
    REFERENCES FG30_ProgramaAuditoria(idFG30)
go

ALTER TABLE FG30DetalleAuditoria ADD CONSTRAINT RefLaboratorio188 
    FOREIGN KEY (idLaboratorio)
    REFERENCES Laboratorio(idLaboratorio)
go

ALTER TABLE FG30DetalleAuditoria ADD CONSTRAINT RefFG30CriteriosAuditoria189 
    FOREIGN KEY (idCriterio)
    REFERENCES FG30CriteriosAuditoria(idCriterio)
go


/* 
 * TABLE: FG31_CalificacionAuditores 
 */

ALTER TABLE FG31_CalificacionAuditores ADD CONSTRAINT RefGestion191 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG31_CalificacionAuditores ADD CONSTRAINT RefPersona192 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG31_Criterio 
 */

ALTER TABLE FG31_Criterio ADD CONSTRAINT RefFG31_Requisitos193 
    FOREIGN KEY (idF31Requisitos)
    REFERENCES FG31_Requisitos(idF31Requisitos)
go


/* 
 * TABLE: FG31_Evaluacion 
 */

ALTER TABLE FG31_Evaluacion ADD CONSTRAINT RefFG31_CalificacionAuditores194 
    FOREIGN KEY (idFG31)
    REFERENCES FG31_CalificacionAuditores(idFG31)
go

ALTER TABLE FG31_Evaluacion ADD CONSTRAINT RefFG31_Criterio255 
    FOREIGN KEY (idCriterio)
    REFERENCES FG31_Criterio(idCriterio)
go


/* 
 * TABLE: FG32_Lista 
 */

ALTER TABLE FG32_Lista ADD CONSTRAINT RefFG32_ListaVerificacion201 
    FOREIGN KEY (idFG32)
    REFERENCES FG32_ListaVerificacion(idFG32)
go


/* 
 * TABLE: FG32_ListaVerificacion 
 */

ALTER TABLE FG32_ListaVerificacion ADD CONSTRAINT RefGestion197 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG32_ListaVerificacion ADD CONSTRAINT RefPersona198 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go

ALTER TABLE FG32_ListaVerificacion ADD CONSTRAINT RefPersona199 
    FOREIGN KEY (Responsable)
    REFERENCES Persona(id_persona)
go

ALTER TABLE FG32_ListaVerificacion ADD CONSTRAINT RefLaboratorio200 
    FOREIGN KEY (idLaboratorio)
    REFERENCES Laboratorio(idLaboratorio)
go


/* 
 * TABLE: FG33_PlanAuditoriaInterna 
 */

ALTER TABLE FG33_PlanAuditoriaInterna ADD CONSTRAINT RefGestion203 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG33Detalle 
 */

ALTER TABLE FG33Detalle ADD CONSTRAINT RefFG33_PlanAuditoriaInterna204 
    FOREIGN KEY (idFG33PlanAuditoria)
    REFERENCES FG33_PlanAuditoriaInterna(idFG33PlanAuditoria)
go

ALTER TABLE FG33Detalle ADD CONSTRAINT RefLaboratorio205 
    FOREIGN KEY (idLaboratorio)
    REFERENCES Laboratorio(idLaboratorio)
go


/* 
 * TABLE: FG34_ReunionInicialAuditoriaInterna 
 */

ALTER TABLE FG34_ReunionInicialAuditoriaInterna ADD CONSTRAINT RefPersonaLaboratorio208 
    FOREIGN KEY (idPersonaLaboratorio)
    REFERENCES PersonaLaboratorio(idPersonaLaboratorio)
go

ALTER TABLE FG34_ReunionInicialAuditoriaInterna ADD CONSTRAINT RefGestion211 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG34Participantes 
 */

ALTER TABLE FG34Participantes ADD CONSTRAINT RefFG34_ReunionInicialAuditoriaInterna209 
    FOREIGN KEY (idFG34)
    REFERENCES FG34_ReunionInicialAuditoriaInterna(idFG34)
go

ALTER TABLE FG34Participantes ADD CONSTRAINT RefPersona210 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG35_hallazgos 
 */

ALTER TABLE FG35_hallazgos ADD CONSTRAINT RefFG35_LevantamientoDeEvidencia215 
    FOREIGN KEY (idFG35)
    REFERENCES FG35_LevantamientoDeEvidencia(idFG35)
go


/* 
 * TABLE: FG35_LevantamientoDeEvidencia 
 */

ALTER TABLE FG35_LevantamientoDeEvidencia ADD CONSTRAINT RefGestion212 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG35_LevantamientoDeEvidencia ADD CONSTRAINT RefPersonaLaboratorio213 
    FOREIGN KEY (idPersonaLaboratorio)
    REFERENCES PersonaLaboratorio(idPersonaLaboratorio)
go


/* 
 * TABLE: FG36_ReunionCierreAuditoriaInterna 
 */

ALTER TABLE FG36_ReunionCierreAuditoriaInterna ADD CONSTRAINT RefGestion218 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG36Participantes 
 */

ALTER TABLE FG36Participantes ADD CONSTRAINT RefFG36_ReunionCierreAuditoriaInterna219 
    FOREIGN KEY (id_fg36)
    REFERENCES FG36_ReunionCierreAuditoriaInterna(id_fg36)
go

ALTER TABLE FG36Participantes ADD CONSTRAINT RefPersona220 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG37_InformeAuditoriaInterna 
 */

ALTER TABLE FG37_InformeAuditoriaInterna ADD CONSTRAINT RefGestion223 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG37Participantes 
 */

ALTER TABLE FG37Participantes ADD CONSTRAINT RefFG37_InformeAuditoriaInterna221 
    FOREIGN KEY (idFG37)
    REFERENCES FG37_InformeAuditoriaInterna(idFG37)
go

ALTER TABLE FG37Participantes ADD CONSTRAINT RefPersona222 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG38_CumplimientoDeObjetivos 
 */

ALTER TABLE FG38_CumplimientoDeObjetivos ADD CONSTRAINT RefGestion224 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG38_Detalle 
 */

ALTER TABLE FG38_Detalle ADD CONSTRAINT RefFG38_CumplimientoDeObjetivos225 
    FOREIGN KEY (idFG38)
    REFERENCES FG38_CumplimientoDeObjetivos(idFG38)
go


/* 
 * TABLE: FG38_Involucrados 
 */

ALTER TABLE FG38_Involucrados ADD CONSTRAINT RefFG38_CumplimientoDeObjetivos229 
    FOREIGN KEY (idFG38)
    REFERENCES FG38_CumplimientoDeObjetivos(idFG38)
go

ALTER TABLE FG38_Involucrados ADD CONSTRAINT RefPersona230 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG39_AccionesCorrectivasYPreventivas 
 */

ALTER TABLE FG39_AccionesCorrectivasYPreventivas ADD CONSTRAINT RefGestion226 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG39_AccionesCorrectivasYPreventivas ADD CONSTRAINT RefPersona228 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG39_Detalle 
 */

ALTER TABLE FG39_Detalle ADD CONSTRAINT RefFG39_AccionesCorrectivasYPreventivas227 
    FOREIGN KEY (idFG39)
    REFERENCES FG39_AccionesCorrectivasYPreventivas(idFG39)
go


/* 
 * TABLE: FG40_CambiosQuePuedanAfectarAllSGC 
 */

ALTER TABLE FG40_CambiosQuePuedanAfectarAllSGC ADD CONSTRAINT RefGestion232 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG40_CambiosQuePuedanAfectarAllSGC ADD CONSTRAINT RefPersona233 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG40_Detalle 
 */

ALTER TABLE FG40_Detalle ADD CONSTRAINT RefFG40_CambiosQuePuedanAfectarAllSGC231 
    FOREIGN KEY (idFG40)
    REFERENCES FG40_CambiosQuePuedanAfectarAllSGC(idFG40)
go


/* 
 * TABLE: FG41_Detalle 
 */

ALTER TABLE FG41_Detalle ADD CONSTRAINT RefArea234 
    FOREIGN KEY (idArea)
    REFERENCES Area(idArea)
go

ALTER TABLE FG41_Detalle ADD CONSTRAINT RefPersona235 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG41_RecomendacionesDeMejora 
 */

ALTER TABLE FG41_RecomendacionesDeMejora ADD CONSTRAINT RefGestion236 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG41_RecomendacionesDeMejora ADD CONSTRAINT RefPersona237 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia 
 */

ALTER TABLE FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia ADD CONSTRAINT RefGestion238 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go

ALTER TABLE FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia ADD CONSTRAINT RefPersona239 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG42Detalle 
 */

ALTER TABLE FG42Detalle ADD CONSTRAINT RefFG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia240 
    FOREIGN KEY (idFG42)
    REFERENCES FG42_AccionesDeSeguimientoDeLaRevisionPorLaDireccionPrevia(idFG42)
go

ALTER TABLE FG42Detalle ADD CONSTRAINT RefFG42_Estados241 
    FOREIGN KEY (idEstados)
    REFERENCES FG42_Estados(idEstados)
go

ALTER TABLE FG42Detalle ADD CONSTRAINT RefPersona242 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG43_Detalle 
 */

ALTER TABLE FG43_Detalle ADD CONSTRAINT RefFG43_EstadoDeEnsayosYCalibracionesNoConformes243 
    FOREIGN KEY (idFG43)
    REFERENCES FG43_EstadoDeEnsayosYCalibracionesNoConformes(idFG43)
go


/* 
 * TABLE: FG43_EstadoDeEnsayosYCalibracionesNoConformes 
 */

ALTER TABLE FG43_EstadoDeEnsayosYCalibracionesNoConformes ADD CONSTRAINT RefPersona244 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go

ALTER TABLE FG43_EstadoDeEnsayosYCalibracionesNoConformes ADD CONSTRAINT RefGestion245 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG44_Detalles 
 */

ALTER TABLE FG44_Detalles ADD CONSTRAINT RefFG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion249 
    FOREIGN KEY (idFG44)
    REFERENCES FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion(idFG44)
go

ALTER TABLE FG44_Detalles ADD CONSTRAINT RefPersona250 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG44_Participantes 
 */

ALTER TABLE FG44_Participantes ADD CONSTRAINT RefPersona246 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go

ALTER TABLE FG44_Participantes ADD CONSTRAINT RefFG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion247 
    FOREIGN KEY (idFG44)
    REFERENCES FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion(idFG44)
go


/* 
 * TABLE: FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion 
 */

ALTER TABLE FG44_PlanDeMejoraDerivadoDeLaRevisionPorLaDireccion ADD CONSTRAINT RefGestion248 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FG45_Participantes 
 */

ALTER TABLE FG45_Participantes ADD CONSTRAINT RefFG45_RevisionPorLaDireccion252 
    FOREIGN KEY (idFG45)
    REFERENCES FG45_RevisionPorLaDireccion(idFG45)
go

ALTER TABLE FG45_Participantes ADD CONSTRAINT RefPersona253 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: FG45_RevisionPorLaDireccion 
 */

ALTER TABLE FG45_RevisionPorLaDireccion ADD CONSTRAINT RefGestion251 
    FOREIGN KEY (idGestion)
    REFERENCES Gestion(idGestion)
go


/* 
 * TABLE: FormatoGestion 
 */

ALTER TABLE FormatoGestion ADD CONSTRAINT RefProcesoGestion257 
    FOREIGN KEY (idProceso)
    REFERENCES ProcesoGestion(idProceso)
go


/* 
 * TABLE: FormatoPlantilla 
 */

ALTER TABLE FormatoPlantilla ADD CONSTRAINT RefFormatoGestion259 
    FOREIGN KEY (idCodigoFG)
    REFERENCES FormatoGestion(idCodigoFG)
go


/* 
 * TABLE: Gestion 
 */

ALTER TABLE Gestion ADD CONSTRAINT RefFormatoPlantilla177 
    FOREIGN KEY (idFormato)
    REFERENCES FormatoPlantilla(idFormato)
go

ALTER TABLE Gestion ADD CONSTRAINT RefProceso263 
    FOREIGN KEY (idProceso)
    REFERENCES Proceso(idProceso)
go


/* 
 * TABLE: Involucrado 
 */

ALTER TABLE Involucrado ADD CONSTRAINT RefPersona20 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go

ALTER TABLE Involucrado ADD CONSTRAINT RefProceso267 
    FOREIGN KEY (idProceso)
    REFERENCES Proceso(idProceso)
go


/* 
 * TABLE: Involucrados 
 */

ALTER TABLE Involucrados ADD CONSTRAINT RefFG35_LevantamientoDeEvidencia216 
    FOREIGN KEY (idFG35)
    REFERENCES FG35_LevantamientoDeEvidencia(idFG35)
go

ALTER TABLE Involucrados ADD CONSTRAINT RefPersona217 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: MotivacionInteres 
 */

ALTER TABLE MotivacionInteres ADD CONSTRAINT RefFG23_SatisfaccionCliente146 
    FOREIGN KEY (idFG23)
    REFERENCES FG23_SatisfaccionCliente(idFG23)
go

ALTER TABLE MotivacionInteres ADD CONSTRAINT RefSeleccion153 
    FOREIGN KEY (idSeleccion)
    REFERENCES Seleccion(idSeleccion)
go


/* 
 * TABLE: Persona 
 */

ALTER TABLE Persona ADD CONSTRAINT RefCargo271 
    FOREIGN KEY (idCargo)
    REFERENCES Cargo(idCargo)
go


/* 
 * TABLE: PersonaLaboratorio 
 */

ALTER TABLE PersonaLaboratorio ADD CONSTRAINT RefLaboratorio53 
    FOREIGN KEY (idLaboratorio)
    REFERENCES Laboratorio(idLaboratorio)
go

ALTER TABLE PersonaLaboratorio ADD CONSTRAINT RefPersona65 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go


/* 
 * TABLE: PrestacionServicio 
 */

ALTER TABLE PrestacionServicio ADD CONSTRAINT RefFG23_SatisfaccionCliente143 
    FOREIGN KEY (idFG23)
    REFERENCES FG23_SatisfaccionCliente(idFG23)
go

ALTER TABLE PrestacionServicio ADD CONSTRAINT RefSeleccion150 
    FOREIGN KEY (idSeleccion)
    REFERENCES Seleccion(idSeleccion)
go

ALTER TABLE PrestacionServicio ADD CONSTRAINT RefSatisfactorio155 
    FOREIGN KEY (idSatifaccion)
    REFERENCES Satisfactorio(idSatifaccion)
go


/* 
 * TABLE: Proceso 
 */

ALTER TABLE Proceso ADD CONSTRAINT RefEstadoGestion268 
    FOREIGN KEY (idEstadoGestion)
    REFERENCES EstadoGestion(idEstadoGestion)
go

ALTER TABLE Proceso ADD CONSTRAINT RefCliente272 
    FOREIGN KEY (idCliente)
    REFERENCES Cliente(idCliente)
go


/* 
 * TABLE: ProveedoresCalificados 
 */

ALTER TABLE ProveedoresCalificados ADD CONSTRAINT RefProveedores119 
    FOREIGN KEY (idProveedor)
    REFERENCES Proveedores(idProveedor)
go

ALTER TABLE ProveedoresCalificados ADD CONSTRAINT RefFG18_ListaProveedores121 
    FOREIGN KEY (idFG18)
    REFERENCES FG18_ListaProveedores(idFG18)
go


/* 
 * TABLE: Puntualidad 
 */

ALTER TABLE Puntualidad ADD CONSTRAINT RefFG23_SatisfaccionCliente144 
    FOREIGN KEY (idFG23)
    REFERENCES FG23_SatisfaccionCliente(idFG23)
go

ALTER TABLE Puntualidad ADD CONSTRAINT RefSeleccion151 
    FOREIGN KEY (idSeleccion)
    REFERENCES Seleccion(idSeleccion)
go

ALTER TABLE Puntualidad ADD CONSTRAINT RefSatisfactorio156 
    FOREIGN KEY (idSatifaccion)
    REFERENCES Satisfactorio(idSatifaccion)
go


/* 
 * TABLE: Representante 
 */

ALTER TABLE Representante ADD CONSTRAINT RefPersona80 
    FOREIGN KEY (id_persona)
    REFERENCES Persona(id_persona)
go

ALTER TABLE Representante ADD CONSTRAINT RefFG10_SolicitudDosExterna81 
    FOREIGN KEY (idFG10)
    REFERENCES FG10_SolicitudDosExterna(idFG10)
go


/* 
 * TABLE: Seleccion 
 */

ALTER TABLE Seleccion ADD CONSTRAINT RefPregunta147 
    FOREIGN KEY (idPregunta)
    REFERENCES Pregunta(idPregunta)
go

ALTER TABLE Seleccion ADD CONSTRAINT RefOpcion148 
    FOREIGN KEY (idOpcion)
    REFERENCES Opcion(idOpcion)
go


