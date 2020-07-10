USE [grubal]
GO
/****** Object:  StoredProcedure [DOCUMENTO].[crud_LISTA_DE_MATERIALESSelect]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DOCUMENTO].[crud_LISTA_DE_MATERIALESSelect]
		@proyecto [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_documento, fecha_pedida, fecha_aprobada, ep.primer_nom + ' ' + ep.primer_ape AS pedidoPor,
		ea.primer_nom + ' ' + ea.primer_ape AS aprobadoPor, ei.primer_nom + ' ' + ei.primer_ape AS ingresadoPor, aprobado
	FROM DOCUMENTO.LISTA_DE_MATERIALES
	INNER JOIN PERSONA.EMPLEADO ea ON DOCUMENTO.LISTA_DE_MATERIALES.aprobado_por = ea.id_persona
	INNER JOIN PERSONA.EMPLEADO ep ON DOCUMENTO.LISTA_DE_MATERIALES.pedido_por = ep.id_persona
	INNER JOIN PERSONA.EMPLEADO ei ON DOCUMENTO.LISTA_DE_MATERIALES.ingresado_por = ei.id_persona
	WHERE (proyecto = @proyecto)

	COMMIT
GO
/****** Object:  StoredProcedure [DOCUMENTO].[ListarEntregaFinalFull]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DOCUMENTO].[ListarEntregaFinalFull]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_documento, p.id_proyecto, p.nom_proyecto, id_encargado, e.primer_nom + ' ' + e.primer_ape AS Encargado, 
			path_scan_reporte, fecha
	FROM DOCUMENTO.ENTREGA_FINAL
	INNER JOIN PROYECTO.PROYECTO p ON DOCUMENTO.ENTREGA_FINAL.id_proyecto = p.id_proyecto
	INNER JOIN PERSONA.EMPLEADO e ON DOCUMENTO.ENTREGA_FINAL.id_encargado = e.id_persona
	COMMIT
GO
/****** Object:  StoredProcedure [DOCUMENTO].[ListarEntregasFinalesPorFecha]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DOCUMENTO].[ListarEntregasFinalesPorFecha]
	@fecha_inicio date,
	@fecha_fin date
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_documento, p.nom_proyecto, e.primer_nom + ' ' + e.primer_ape AS encargado, path_scan_reporte, fecha
	FROM DOCUMENTO.ENTREGA_FINAL
	INNER JOIN PERSONA.EMPLEADO e ON DOCUMENTO.ENTREGA_FINAL.id_encargado = e.id_persona
	INNER JOIN PROYECTO.PROYECTO p ON DOCUMENTO.ENTREGA_FINAL.id_proyecto = p.id_proyecto
	WHERE (fecha between @fecha_inicio and @fecha_fin)
	ORDER BY DOCUMENTO.ENTREGA_FINAL.fecha desc

	COMMIT
GO
/****** Object:  StoredProcedure [DOCUMENTO].[ListarMaterialesPorProyecto]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DOCUMENTO].[ListarMaterialesPorProyecto]
		@proyecto [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_documento, fecha_pedida, fecha_aprobada, ep.primer_nom + ' ' + ep.primer_ape AS pedidoPor,
		ea.primer_nom + ' ' + ea.primer_ape AS aprobadoPor, ei.primer_nom + ' ' + ei.primer_ape AS ingresadoPor, aprobado
	FROM DOCUMENTO.LISTA_DE_MATERIALES
	INNER JOIN PERSONA.EMPLEADO ea ON DOCUMENTO.LISTA_DE_MATERIALES.aprobado_por = ea.id_persona
	INNER JOIN PERSONA.EMPLEADO ep ON DOCUMENTO.LISTA_DE_MATERIALES.pedido_por = ep.id_persona
	INNER JOIN PERSONA.EMPLEADO ei ON DOCUMENTO.LISTA_DE_MATERIALES.ingresado_por = ei.id_persona
	WHERE (proyecto = @proyecto)

	COMMIT
GO
/****** Object:  StoredProcedure [DOCUMENTO].[ListarPlanosFull]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DOCUMENTO].[ListarPlanosFull]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_documento, p.id_proyecto, p.nom_proyecto revision, pt.nom_tipo_plano, dibujado_por,
			revisado_por, nom_plano, fecha_creacion, fecha_revision, fecha_envio, path_plano
	FROM DOCUMENTO.PLANO
	INNER JOIN PERSONA.EMPLEADO e ON DOCUMENTO.PLANO.dibujado_por = e.id_persona
	INNER JOIN DOCUMENTO.PLANO_TIPO pt ON DOCUMENTO.PLANO.tipo_plano = pt.id_tipo_plano
	INNER JOIN PROYECTO.PROYECTO p ON DOCUMENTO.PLANO.id_proyecto = p.id_proyecto

	COMMIT
GO
/****** Object:  StoredProcedure [DOCUMENTO].[ListarPlanosPorProyecto]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DOCUMENTO].[ListarPlanosPorProyecto]
	@id_proyecto [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_documento, p.id_proyecto, p.nom_proyecto revision, pt.nom_tipo_plano, dibujado_por,
			revisado_por, nom_plano, fecha_creacion, fecha_revision, fecha_envio, path_plano
	FROM DOCUMENTO.PLANO dp
	INNER JOIN PERSONA.EMPLEADO e ON dp.dibujado_por = e.id_persona
	INNER JOIN DOCUMENTO.PLANO_TIPO pt ON dp.tipo_plano = pt.id_tipo_plano
	INNER JOIN PROYECTO.PROYECTO p ON dp.id_proyecto = p.id_proyecto
	WHERE (dp.id_proyecto = @id_proyecto)

	COMMIT
GO
/****** Object:  StoredProcedure [DOCUMENTO].[ListarPlanosPorProyectoTipo]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DOCUMENTO].[ListarPlanosPorProyectoTipo]
		@id_proyecto [int],
		@id_tipo [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_documento, revision, pt.nom_tipo_plano, ed.primer_nom + ' ' + ed.primer_ape AS dibujadoPor, 
		er.primer_nom + ' ' + er.primer_ape AS revisadoPor, nom_plano, fecha_creacion, fecha_revision, fecha_envio, path_plano
	FROM DOCUMENTO.PLANO p
	INNER JOIN PERSONA.EMPLEADO ed ON p.dibujado_por = ed.id_persona
	INNER JOIN PERSONA.EMPLEADO er ON p.revisado_por = er.id_persona
	INNER JOIN DOCUMENTO.PLANO_TIPO pt ON p.tipo_plano = pt.id_tipo_plano
	INNER JOIN PROYECTO.PROYECTO p2 ON p.id_proyecto = p2.id_proyecto
	WHERE (p.id_proyecto = @id_proyecto AND p.tipo_plano = @id_tipo)

	COMMIT
GO
/****** Object:  StoredProcedure [DOCUMENTO].[ListarReporteSupervisionFull]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DOCUMENTO].[ListarReporteSupervisionFull]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_documento, p.id_proyecto, p.nom_proyecto, id_supervisor, e.primer_nom + ' ' + e.primer_ape AS Supervisor, 
		fecha_reporte, detalles_reporte, path_scan_reporte
	FROM DOCUMENTO.REPORTE_SUPERVISION
	INNER JOIN PROYECTO.PROYECTO p ON DOCUMENTO.REPORTE_SUPERVISION.id_proyecto = p.id_proyecto
	INNER JOIN PERSONA.EMPLEADO e ON DOCUMENTO.REPORTE_SUPERVISION.id_supervisor = e.id_persona
	
	COMMIT
GO
/****** Object:  StoredProcedure [DOCUMENTO].[ListarReporteSupervisionPorProyectoEmpleado]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DOCUMENTO].[ListarReporteSupervisionPorProyectoEmpleado]
		@id_proyecto [int],
		@id_supervisor [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT rs.id_documento, p.nom_proyecto, e.primer_nom + ' ' + e.primer_ape AS supervisor, fecha_reporte, detalles_reporte, path_scan_reporte
	FROM DOCUMENTO.REPORTE_SUPERVISION rs
	INNER JOIN PERSONA.EMPLEADO e ON rs.id_supervisor = e.id_persona
	INNER JOIN PROYECTO.PROYECTO p ON rs.id_proyecto = p.id_proyecto
	WHERE (rs.id_proyecto = @id_proyecto AND @id_supervisor = id_supervisor)

	COMMIT
GO
/****** Object:  StoredProcedure [DOCUMENTO].[ListarReporteTecnicoFull]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DOCUMENTO].[ListarReporteTecnicoFull]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_documento, p.nom_proyecto, e.primer_nom + ' ' + e.primer_ape AS Tecnico, fecha_reporte, detalles_reporte, path_scan_reporte
	FROM DOCUMENTO.REPORTE_TECNICO
	INNER JOIN PROYECTO.PROYECTO p ON DOCUMENTO.REPORTE_TECNICO.id_proyecto = p.id_proyecto
	INNER JOIN PERSONA.EMPLEADO e ON DOCUMENTO.REPORTE_TECNICO.id_tecnico = e.id_persona

	COMMIT
GO
/****** Object:  StoredProcedure [DOCUMENTO].[ListarReporteTecnicoPorProyectoEmpleado]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DOCUMENTO].[ListarReporteTecnicoPorProyectoEmpleado]
		@id_proyecto [int],
		@id_tecnico [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_documento, p.nom_proyecto, e.primer_nom + ' ' + e.primer_ape AS tecnico, fecha_reporte, detalles_reporte, path_scan_reporte
	FROM DOCUMENTO.REPORTE_TECNICO rt
	INNER JOIN PERSONA.EMPLEADO e ON rt.id_tecnico = e.id_persona
	INNER JOIN PROYECTO.PROYECTO p ON rt.id_proyecto = p.id_proyecto
	WHERE (rt.id_proyecto = @id_proyecto AND @id_tecnico = id_tecnico)

	COMMIT
GO
/****** Object:  StoredProcedure [DOCUMENTO].[ListarTiposPlano]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [DOCUMENTO].[ListarTiposPlano]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_tipo_plano, nom_tipo_plano
	FROM DOCUMENTO.PLANO_TIPO
	
	COMMIT
GO
/****** Object:  StoredProcedure [DOCUMENTO].[NewDocument]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procecdure para insertar un nuevo ID de documento -------------------------
CREATE PROCEDURE [DOCUMENTO].[NewDocument]
(
  @NewId int out
)
AS 
BEGIN 
  INSERT INTO DOCUMENTO.ID_DOCUMENTO (uid)
    SELECT NEWID();
  SET @NewId = SCOPE_IDENTITY()
  RETURN @NewId;
END
GO
/****** Object:  StoredProcedure [DOCUMENTO].[NuevoPlano]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--- Insertar cliente nuevo
CREATE PROCEDURE [DOCUMENTO].[NuevoPlano]
(
	@id_proyecto int,
	@revision nchar(3),
	@tipo_plano int,
	@dibujado_por int,
	@revisado_por int,
	@nom_plano nvarchar(150),
	@fecha_creacaion datetime,
	@fecha_revision datetime,
	@fecha_envio datetime,
	@path_plano varchar(256)
)
AS
	DECLARE @nid int
IF 
	(@id_proyecto IS NULL)	OR 
	(@revision IS NULL)		OR
	(@tipo_plano IS NULL)	OR
	(@dibujado_por IS NULL)	OR
	(@revisado_por IS NULL)	OR
	(@nom_plano IS NULL)	OR
	(@fecha_creacaion IS NULL)	OR
	(@fecha_revision IS NULL)	OR
	(@fecha_envio IS NULL)	OR
	(@path_plano IS NULL)
	BEGIN
		PRINT 'Ha ingresado un parametro invalido'
		RETURN -1
END
IF NOT EXISTS
	(SELECT id_proyecto FROM PROYECTO.PROYECTO
								WHERE id_proyecto = @id_proyecto)
	BEGIN
		PRINT 'El proyecto no existe'
		RETURN -2
END

IF NOT EXISTS
	(SELECT id_tipo_plano FROM DOCUMENTO.PLANO_TIPO
								WHERE id_tipo_plano = @tipo_plano)
	BEGIN
		PRINT 'El proyecto no existe'
		RETURN -3
END

BEGIN TRAN
EXEC @nid = DOCUMENTO.NewDocument @nid
	INSERT INTO DOCUMENTO.PLANO (id_documento,id_proyecto,revision,tipo_plano,dibujado_por,revisado_por,nom_plano,fecha_creacion,fecha_revision,fecha_envio,path_plano)
						VALUES (@nid,@id_proyecto,@revision,@tipo_plano,@dibujado_por,@revisado_por,@nom_plano,@fecha_creacaion,@fecha_revision,@fecha_envio,@path_plano)
	IF @@ERROR <> 0
		BEGIN
			PRINT 'Ocurrio un error en la transaccion, vuelve a intentar'
			ROLLBACK TRAN
			RETURN -100
		END
	COMMIT TRAN
	RETURN 0 
GO
/****** Object:  StoredProcedure [MARKETING].[FichaMarketingActualizar]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [MARKETING].[FichaMarketingActualizar]
	(
		@id_ficha_marketing [int],
		@id_persona_fuente [int],
		@forma_contacto_inical [smallint],
		@primer_interes [smallint],
		@fecha_primer_contacto [datetime],
		@fecha_ultimo_contacto [datetime]
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		UPDATE MARKETING.FICHA_MARKETING
		SET  id_persona_fuente = @id_persona_fuente, forma_contacto_inical = @forma_contacto_inical, primer_interes = @primer_interes, fecha_primer_contacto = @fecha_primer_contacto, fecha_ultimo_contacto = @fecha_ultimo_contacto
		WHERE (id_ficha_marketing = @id_ficha_marketing OR @id_ficha_marketing IS NULL)
	COMMIT
GO
/****** Object:  StoredProcedure [MARKETING].[FichaMarketingDelete]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [MARKETING].[FichaMarketingDelete]
		@id_ficha_marketing [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		DELETE FROM MARKETING.FICHA_MARKETING
		WHERE (id_ficha_marketing = @id_ficha_marketing OR @id_ficha_marketing IS NULL)
	COMMIT
GO
/****** Object:  StoredProcedure [MARKETING].[FichaMarketingEliminar]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [MARKETING].[FichaMarketingEliminar]
		@id_ficha_marketing [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		DELETE FROM MARKETING.FICHA_MARKETING
		WHERE (id_ficha_marketing = @id_ficha_marketing OR @id_ficha_marketing IS NULL)
	COMMIT
GO
/****** Object:  StoredProcedure [MARKETING].[FichaMarketingNew]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [MARKETING].[FichaMarketingNew]
	(
		@id_ficha_marketing [int],
		@id_persona_fuente [int],
		@forma_contacto_inical [smallint],
		@primer_interes [smallint],
		@fecha_primer_contacto [datetime],
		@fecha_ultimo_contacto [datetime]
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
	SET IDENTITY_INSERT MARKETING.FICHA_MARKETING ON

	INSERT INTO MARKETING.FICHA_MARKETING
	(
		id_ficha_marketing, id_persona_fuente, forma_contacto_inical, primer_interes, fecha_primer_contacto, fecha_ultimo_contacto
	)
	VALUES
	(
		@id_ficha_marketing,
		@id_persona_fuente,
		@forma_contacto_inical,
		@primer_interes,
		@fecha_primer_contacto,
		@fecha_ultimo_contacto

	)
	SET IDENTITY_INSERT MARKETING.FICHA_MARKETING OFF

	COMMIT
GO
/****** Object:  StoredProcedure [MARKETING].[ListarContactoInicial]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [MARKETING].[ListarContactoInicial]
		
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_contacto, nom_forma_contacto
	FROM MARKETING.CONTACTO_INICIAL


	COMMIT
GO
/****** Object:  StoredProcedure [MARKETING].[ListarFichaMarketingPorId]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [MARKETING].[ListarFichaMarketingPorId]
		@id_ficha_marketing [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_ficha_marketing, id_persona_fuente, forma_contacto_inical, primer_interes, fecha_primer_contacto, fecha_ultimo_contacto
	FROM MARKETING.FICHA_MARKETING
	WHERE (id_ficha_marketing = @id_ficha_marketing OR @id_ficha_marketing IS NULL)

	COMMIT
GO
/****** Object:  StoredProcedure [MARKETING].[ListarPrimerInteres]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [MARKETING].[ListarPrimerInteres]
		
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_interes, desc_primer_interes
	FROM MARKETING.PRIMER_INTERES


	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ClienteNew]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ClienteNew]
	(
		@id_persona [int],
		@marketing [int],
		@nom_cliente [varchar](200),
		@doc_oficial [varchar](16)
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	INSERT INTO PERSONA.CLIENTE
	(
		id_persona, marketing, nom_cliente, doc_oficial
	)
	VALUES
	(
		@id_persona,
		@marketing,
		@nom_cliente,
		@doc_oficial

	)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[CredentialNew]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[CredentialNew]
	(
		@usuario [varchar](16),
		@password [char](64),
		@salt [varchar](128),
		@active [bit],
		@empleado [int]
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	INSERT INTO PERSONA.CREDENTIAL
	(
		usuario, [password], salt, active, empleado
	)
	VALUES
	(
		@usuario,
		@password,
		@salt,
		@active,
		@empleado

	)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[CredentialSelect]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[CredentialSelect]
		@usuario varchar(16)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_usuario, usuario, [password], salt, active, empleado
	FROM PERSONA.[CREDENTIAL]
	WHERE (usuario = @usuario)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[CredentialUpdate]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [PERSONA].[CredentialUpdate]
	(
		@id_usuario [int],
		@usuario [varchar](16),
		@password [char](64),
		@salt [varchar](128),
		@active [bit],
		@empleado [int]
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		UPDATE PERSONA.[CREDENTIAL]
		SET  usuario = @usuario, [password] = @password, salt = @salt, active = @active, empleado = @empleado
		WHERE (id_usuario = @id_usuario)
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[DireccionNew]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[DireccionNew]
	(
		@tipo_direccion [tinyint],
		@id_persona [int],
		@dir_pais [tinyint],
		@dir_provincia [int],
		@dir_ciudad [int],
		@dir_distrito [int],
		@dir_linea_1 [nvarchar](100),
		@dir_linea_2 [nvarchar](100),
		@dir_codigo_postal [varchar](10)
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	INSERT INTO PERSONA.DIRECCION
	(
		tipo_direccion, id_persona, dir_pais, dir_provincia, dir_ciudad, dir_distrito, dir_linea_1, dir_linea_2, dir_codigo_postal
	)
	VALUES
	(
		@tipo_direccion,
		@id_persona,
		@dir_pais,
		@dir_provincia,
		@dir_ciudad,
		@dir_distrito,
		@dir_linea_1,
		@dir_linea_2,
		@dir_codigo_postal

	)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[EliminarCliente]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[EliminarCliente]
		@id_persona [int],
		@id_ficha_marketing [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
	

		DELETE FROM PERSONA.CLIENTE
		WHERE (id_persona = @id_persona OR @id_persona IS NULL)

		EXEC MARKETING.FichaMarketingDelete @id_ficha_marketing
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[EliminarCredencial]    Script Date: 7/8/2020 8:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[EliminarCredencial]
		@usuario [nvarchar](16)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		DELETE FROM PERSONA.CREDENTIAL
		WHERE (usuario = @usuario )
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[EliminarDireccion]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[EliminarDireccion]
		@id_direccion [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		DELETE FROM PERSONA.DIRECCION
		WHERE (id_direccion = @id_direccion)
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[EliminarEmail]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[EliminarEmail]
		@id_email [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		DELETE FROM PERSONA.EMAIL
		WHERE (id_email = @id_email)
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[EliminarEmpleado]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[EliminarEmpleado]
		@id_persona [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		DELETE FROM PERSONA.EMPLEADO
		WHERE (id_persona = @id_persona OR @id_persona IS NULL)
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[EliminarPersonaDeInteres]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[EliminarPersonaDeInteres]
		@id_persona [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		DELETE FROM PERSONA.PERSONA_DE_INTERES
		WHERE (id_persona = @id_persona OR @id_persona IS NULL)
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[EliminarTelefono]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[EliminarTelefono]
		@id_telefono [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		DELETE FROM PERSONA.TELEFONO
		WHERE (id_telefono = @id_telefono)
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[EmailNew]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[EmailNew]
	(
		@tipo_email [tinyint],
		@id_persona [int],
		@direccion_email [varchar](320)
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	INSERT INTO PERSONA.EMAIL
	(
		tipo_email, id_persona, direccion_email
	)
	VALUES
	(
		@tipo_email,
		@id_persona,
		@direccion_email
	)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[EmpleadoSelectEstado]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[EmpleadoSelectEstado]
		@id_persona [int],
		@estado [bit] output
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SET @estado =(
	SELECT  estado
	FROM PERSONA.EMPLEADO
	WHERE (id_persona = @id_persona)
	)
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[LestarTelefonosFull]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[LestarTelefonosFull]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

			SELECT idp.id_persona AS ID, pdi.nom_persona AS NOMBRE INTO #PERSONAS
			FROM PERSONA.PERSONA_DE_INTERES pdi
			INNER JOIN PERSONA.ID_PERSONA idp ON pdi.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID,c.nom_cliente AS NOMBRE
			FROM PERSONA.CLIENTE c
			INNER JOIN PERSONA.ID_PERSONA idp ON c.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID, e.primer_nom + ' ' + e.primer_ape + ' ' + e.segundo_ape AS NOMBRE
			FROM PERSONA.EMPLEADO e
			INNER JOIN PERSONA.ID_PERSONA idp ON e.id_persona = idp.id_persona

	SELECT id_telefono as Id, id_persona as [Id Persona], per.Nombre as [Nombre], 
				codigo_pais as [Codigo Pais], campo_1 as [C1], campo_2 as [C2], campo_3 as [C3], ext as [EXT]
	FROM PERSONA.TELEFONO t
	inner join PERSONA.TELEFONOS_TIPOS tt ON t.tipo_telefono = tt.tipo_telefono
	RIGHT JOIN #Personas per ON t.id_persona = per.ID
		WHERE t.id_telefono IS NOT NULL 
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[LestarTelefonosFullPorId]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[LestarTelefonosFullPorId]
		@id_persona [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

			SELECT idp.id_persona AS ID, pdi.nom_persona AS NOMBRE INTO #PERSONAS
			FROM PERSONA.PERSONA_DE_INTERES pdi
			INNER JOIN PERSONA.ID_PERSONA idp ON pdi.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID,c.nom_cliente AS NOMBRE
			FROM PERSONA.CLIENTE c
			INNER JOIN PERSONA.ID_PERSONA idp ON c.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID, e.primer_nom + ' ' + e.primer_ape + ' ' + e.segundo_ape AS NOMBRE
			FROM PERSONA.EMPLEADO e
			INNER JOIN PERSONA.ID_PERSONA idp ON e.id_persona = idp.id_persona

	SELECT id_telefono as Id, id_persona as [Id Persona], per.Nombre as [Nombre], 
				codigo_pais as [Codigo Pais], campo_1 as [C1], campo_2 as [C2], campo_3 as [C3], ext as [EXT]
	FROM PERSONA.TELEFONO t
	inner join PERSONA.TELEFONOS_TIPOS tt ON t.tipo_telefono = tt.tipo_telefono
	RIGHT JOIN #Personas per ON t.id_persona = per.ID
		WHERE t.id_telefono IS NOT NULL 
		AND @id_persona = t.id_persona

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarCiudades]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarCiudades]
AS
	SET NOCOUNT ON

	SELECT id_ciudad, id_region, nom_ciudad
	FROM PERSONA.DIRECCION_CIUDAD

GO
/****** Object:  StoredProcedure [PERSONA].[ListarCiudadesPorIdRegion]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarCiudadesPorIdRegion]
		@id_region [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_ciudad, id_region, nom_ciudad
	FROM PERSONA.DIRECCION_CIUDAD
	WHERE (id_region = @id_region)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarClientes]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarClientes]
		
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_persona, marketing, nom_cliente, doc_oficial
	FROM PERSONA.CLIENTE

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarClientesFull]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarClientesFull]
	
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_persona AS [ID Persona], nom_cliente AS [Nombre Cliente],marketing AS [ID Ficha Marketing] ,  doc_oficial AS [Documento]
	FROM PERSONA.CLIENTE

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarClientesPorId]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarClientesPorId]
		@id_persona [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_persona, marketing, nom_cliente, doc_oficial
	FROM PERSONA.CLIENTE
	WHERE (id_persona = @id_persona OR @id_persona IS NULL)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarCredenciales]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarCredenciales]
		
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_usuario AS [Id Usuario], usuario AS [Usuario],  e.primer_nom + ' ' + e.primer_ape as [Empleado], active AS [Activo]
	FROM PERSONA.CREDENTIAL
	INNER JOIN persona.EMPLEADO e ON PERSONA.CREDENTIAL.empleado = e.id_persona

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarDireccionesFull]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarDireccionesFull]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

		SELECT idp.id_persona AS ID, pdi.nom_persona AS NOMBRE INTO #PERSONAS
			FROM PERSONA.PERSONA_DE_INTERES pdi
			INNER JOIN PERSONA.ID_PERSONA idp ON pdi.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID,c.nom_cliente AS NOMBRE
			FROM PERSONA.CLIENTE c
			INNER JOIN PERSONA.ID_PERSONA idp ON c.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID, e.primer_nom + ' ' + e.primer_ape + ' ' + e.segundo_ape AS NOMBRE
			FROM PERSONA.EMPLEADO e
			INNER JOIN PERSONA.ID_PERSONA idp ON e.id_persona = idp.id_persona


	SELECT id_direccion AS Id, idp.id_persona AS [Id Persona], per.NOMBRE AS Nombre ,dt.nombre_direccion AS Tipo,  dp.nom_pais AS PAIS, dr.nom_region AS Region,
			dc.nom_ciudad AS Ciudad, dd.nom_distrito AS Distrito, dir_linea_1 AS [Linea 1], dir_linea_2 AS [Linea 2], dir_codigo_postal AS [Codigo Postal]
		FROM PERSONA.DIRECCION d
		INNER JOIN PERSONA.DIRECCION_CIUDAD dc ON d.dir_ciudad = dc.id_ciudad
		INNER JOIN PERSONA.DIRECCION_REGION dr ON dc.id_region = dr.id_region
		INNER JOIN persona.DIRECCION_DISTRITO dd ON d.dir_distrito = dd.id_distrito
		INNER JOIN persona.DIRECCION_PAIS dp ON d.dir_pais = dp.id_pais
		INNER JOIN persona.DIRECCION_TIPOS dt ON d.tipo_direccion = dt.tipo_direccion
		LEFT JOIN persona.ID_PERSONA idp ON d.id_persona = idp.id_persona
		RIGHT JOIN #Personas per ON idp.id_persona = per.ID
		WHERE d.id_direccion IS NOT NULL 

		If(OBJECT_ID('#PERSONAS') Is Not Null)
			Begin
				Drop Table #PERSONAS
			End
	COMMIT

GO
/****** Object:  StoredProcedure [PERSONA].[ListarDireccionesFullPorId]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarDireccionesFullPorId]
	@id_persona [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

		SELECT idp.id_persona AS ID, pdi.nom_persona AS NOMBRE INTO #PERSONAS
			FROM PERSONA.PERSONA_DE_INTERES pdi
			INNER JOIN PERSONA.ID_PERSONA idp ON pdi.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID,c.nom_cliente AS NOMBRE
			FROM PERSONA.CLIENTE c
			INNER JOIN PERSONA.ID_PERSONA idp ON c.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID, e.primer_nom + ' ' + e.primer_ape + ' ' + e.segundo_ape AS NOMBRE
			FROM PERSONA.EMPLEADO e
			INNER JOIN PERSONA.ID_PERSONA idp ON e.id_persona = idp.id_persona


	SELECT id_direccion AS Id, idp.id_persona AS [Id Persona], per.NOMBRE AS Nombre ,dt.nombre_direccion AS Tipo,  dp.nom_pais AS PAIS, dr.nom_region AS Region,
			dc.nom_ciudad AS Ciudad, dd.nom_distrito AS Distrito, dir_linea_1 AS [Linea 1], dir_linea_2 AS [Linea 2], dir_codigo_postal AS [Codigo Postal]
		FROM PERSONA.DIRECCION d
		INNER JOIN PERSONA.DIRECCION_CIUDAD dc ON d.dir_ciudad = dc.id_ciudad
		INNER JOIN PERSONA.DIRECCION_REGION dr ON dc.id_region = dr.id_region
		INNER JOIN persona.DIRECCION_DISTRITO dd ON d.dir_distrito = dd.id_distrito
		INNER JOIN persona.DIRECCION_PAIS dp ON d.dir_pais = dp.id_pais
		INNER JOIN persona.DIRECCION_TIPOS dt ON d.tipo_direccion = dt.tipo_direccion
		LEFT JOIN persona.ID_PERSONA idp ON d.id_persona = idp.id_persona
		RIGHT JOIN #Personas per ON idp.id_persona = per.ID
		WHERE d.id_direccion IS NOT NULL 
		AND @id_persona = idp.id_persona

		If(OBJECT_ID('#PERSONAS') Is Not Null)
			Begin
				Drop Table #PERSONAS
			End
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarDireccionesTipos]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarDireccionesTipos]
	
AS
	SET NOCOUNT ON


	SELECT tipo_direccion, nombre_direccion
	FROM PERSONA.DIRECCION_TIPOS

GO
/****** Object:  StoredProcedure [PERSONA].[ListarDistritoPorIdPorCiudad]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarDistritoPorIdPorCiudad]
		@id_ciudad [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_distrito, id_ciudad, nom_distrito
	FROM PERSONA.DIRECCION_DISTRITO
	WHERE (id_ciudad = @id_ciudad)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarDistritos]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarDistritos]

AS
	SET NOCOUNT ON


	SELECT id_distrito, id_ciudad, nom_distrito
	FROM PERSONA.DIRECCION_DISTRITO

GO
/****** Object:  StoredProcedure [PERSONA].[ListarEmailsFull]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarEmailsFull]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

			SELECT idp.id_persona AS ID, pdi.nom_persona AS NOMBRE INTO #PERSONAS
			FROM PERSONA.PERSONA_DE_INTERES pdi
			INNER JOIN PERSONA.ID_PERSONA idp ON pdi.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID,c.nom_cliente AS NOMBRE
			FROM PERSONA.CLIENTE c
			INNER JOIN PERSONA.ID_PERSONA idp ON c.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID, e.primer_nom + ' ' + e.primer_ape + ' ' + e.segundo_ape AS NOMBRE
			FROM PERSONA.EMPLEADO e
			INNER JOIN PERSONA.ID_PERSONA idp ON e.id_persona = idp.id_persona

	SELECT e.id_email AS Id, id_persona as [Id Persona], et.nombre_email AS Tipo, per.NOMBRE as Nombre,  direccion_email as Email
	FROM PERSONA.EMAIL e
	INNER JOIN PERSONA.EMAIL_TIPOS et ON e.tipo_email = et.tipo_email
	RIGHT JOIN #Personas per ON e.id_persona = per.ID
	WHERE e.id_email IS NOT NULL 

			If(OBJECT_ID('#PERSONAS') Is Not Null)
			Begin
				Drop Table #PERSONAS
			End

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarEmailsFullPorId]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarEmailsFullPorId]
	@id_persona [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

			SELECT idp.id_persona AS ID, pdi.nom_persona AS NOMBRE INTO #PERSONAS
			FROM PERSONA.PERSONA_DE_INTERES pdi
			INNER JOIN PERSONA.ID_PERSONA idp ON pdi.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID,c.nom_cliente AS NOMBRE
			FROM PERSONA.CLIENTE c
			INNER JOIN PERSONA.ID_PERSONA idp ON c.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID, e.primer_nom + ' ' + e.primer_ape + ' ' + e.segundo_ape AS NOMBRE
			FROM PERSONA.EMPLEADO e
			INNER JOIN PERSONA.ID_PERSONA idp ON e.id_persona = idp.id_persona

	SELECT e.id_email AS Id, id_persona as [Id Persona], et.nombre_email AS Tipo, per.NOMBRE as Nombre,  direccion_email as Email
	FROM PERSONA.EMAIL e
	INNER JOIN PERSONA.EMAIL_TIPOS et ON e.tipo_email = et.tipo_email
	RIGHT JOIN #Personas per ON e.id_persona = per.ID
	WHERE e.id_email IS NOT NULL 
	AND @id_persona = e.id_persona

			If(OBJECT_ID('#PERSONAS') Is Not Null)
			Begin
				Drop Table #PERSONAS
			End

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarEmailsTipos]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarEmailsTipos]
		
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT tipo_email, nombre_email
	FROM PERSONA.EMAIL_TIPOS

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarEMpleadoFull]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarEMpleadoFull]
	
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_persona AS [ID Empleado], p.desc_puesto AS [puesto], doc_oficial AS [Documento], ruc_empleado AS [RUC], fecha_nacimiento AS [Fecha Nacimiento], 
						fecha_inicio AS [Fecha Inicio], primer_nom + ' ' + primer_ape + ' ' [Nombre Completo], estado AS [Activo]
	FROM PERSONA.EMPLEADO
	INNER JOIN persona.PUESTO p ON PERSONA.EMPLEADO.puesto_empleado = p.id_puesto

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarEmpleadoPorId]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarEmpleadoPorId]
		@id_persona [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_persona, puesto_empleado, doc_oficial, ruc_empleado, fecha_nacimiento, fecha_inicio, primer_nom, segundo_nom, primer_ape, 
					segundo_ape, primer_nom + ' ' + primer_ape + ' ' + segundo_ape AS fullnom
	FROM PERSONA.EMPLEADO
	WHERE (id_persona = @id_persona OR @id_persona IS NULL)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarEmpleados]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarEmpleados]
		
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_persona, puesto_empleado, doc_oficial, ruc_empleado, fecha_nacimiento, fecha_inicio, primer_nom, 
			segundo_nom, primer_ape, segundo_ape, primer_nom + ' ' + primer_ape + ' ' + segundo_ape AS fullnom
	FROM PERSONA.EMPLEADO
	

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarPaises]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarPaises]

AS
	SET NOCOUNT ON

	SELECT id_pais, nom_pais, abr_pais
	FROM PERSONA.DIRECCION_PAIS

GO
/****** Object:  StoredProcedure [PERSONA].[ListarPersonasALL]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarPersonasALL]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

		SELECT idp.id_persona AS ID, pdi.nom_persona AS NOMBRE INTO #PERSONAS
			FROM PERSONA.PERSONA_DE_INTERES pdi
			INNER JOIN PERSONA.ID_PERSONA idp ON pdi.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID,c.nom_cliente AS NOMBRE
			FROM PERSONA.CLIENTE c
			INNER JOIN PERSONA.ID_PERSONA idp ON c.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID, e.primer_nom + ' ' + e.primer_ape + ' ' + e.segundo_ape AS NOMBRE
			FROM PERSONA.EMPLEADO e
			INNER JOIN PERSONA.ID_PERSONA idp ON e.id_persona = idp.id_persona


	SELECT per.ID AS [Id Persona], per.NOMBRE AS Nombre
		FROM #Personas per
		WHERE per.ID IS NOT NULL 

		If(OBJECT_ID('#PERSONAS') Is Not Null)
			Begin
				Drop Table #PERSONAS
			End
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarPersonasConDirecciones]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarPersonasConDirecciones]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

		SELECT idp.id_persona AS ID, pdi.nom_persona AS NOMBRE INTO #PERSONAS
			FROM PERSONA.PERSONA_DE_INTERES pdi
			INNER JOIN PERSONA.ID_PERSONA idp ON pdi.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID,c.nom_cliente AS NOMBRE
			FROM PERSONA.CLIENTE c
			INNER JOIN PERSONA.ID_PERSONA idp ON c.id_persona = idp.id_persona
			
			INSERT INTO #PERSONAS
			SELECT idp.id_persona AS ID, e.primer_nom + ' ' + e.primer_ape + ' ' + e.segundo_ape AS NOMBRE
			FROM PERSONA.EMPLEADO e
			INNER JOIN PERSONA.ID_PERSONA idp ON e.id_persona = idp.id_persona


	SELECT DISTINCT idp.id_persona AS [Id Persona], per.NOMBRE AS Nombre
		FROM PERSONA.DIRECCION d
		LEFT JOIN persona.ID_PERSONA idp ON d.id_persona = idp.id_persona
		RIGHT JOIN #Personas per ON idp.id_persona = per.ID
		WHERE d.id_direccion IS NOT NULL 

		If(OBJECT_ID('#PERSONAS') Is Not Null)
			Begin
				Drop Table #PERSONAS
			End
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarPersonasDeInteres]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarPersonasDeInteres]

AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_persona, id_directorio, id_proyecto, puesto, nom_persona
	FROM PERSONA.PERSONA_DE_INTERES


	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarPersonasDeInteresFull]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarPersonasDeInteresFull]
		
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_persona AS [Id Persona],nom_persona AS [Nombre], id_directorio AS [Id Directorio], p.nom_proyecto AS [Proyecto], p2.desc_puesto AS [Puesto]
	FROM PERSONA.PERSONA_DE_INTERES
	INNER JOIN PROYECTO.PROYECTO p ON PERSONA.PERSONA_DE_INTERES.id_proyecto = p.id_proyecto
	INNER JOIN persona.PUESTO p2 ON PERSONA.PERSONA_DE_INTERES.puesto = p2.id_puesto
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarPersonasDeInteresPorId]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarPersonasDeInteresPorId]
		@id_persona [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_persona, id_directorio, id_proyecto, puesto, nom_persona
	FROM PERSONA.PERSONA_DE_INTERES
	WHERE (id_persona = @id_persona)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarPersonasFull]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarPersonasFull]
	
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_persona AS [ID Persona], nom_cliente AS [Nombre Cliente],marketing AS [ID Ficha Marketing] ,  doc_oficial AS [Documento]
	FROM PERSONA.CLIENTE

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarProyecto]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [PERSONA].[ListarProyecto]    Script Date: 03/06/2020 12:32:16 a.m. ******/

 CREATE PROCEDURE [PERSONA].[ListarProyecto]

AS
	SET NOCOUNT ON


	SELECT id_proyecto, nom_proyecto
	FROM PROYECTO.PROYECTO
GO
/****** Object:  StoredProcedure [PERSONA].[ListarPuestos]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [PERSONA].[ListarPuestos]    Script Date: 02/06/2020 11:49:32 p.m. ******/

 CREATE PROCEDURE [PERSONA].[ListarPuestos]

AS
	SET NOCOUNT ON


	SELECT id_puesto,desc_puesto
	FROM PERSONA.PUESTO
GO
/****** Object:  StoredProcedure [PERSONA].[ListarRegiones]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarRegiones]

AS
	SET NOCOUNT ON


	SELECT id_region, id_pais, nom_region
	FROM PERSONA.DIRECCION_REGION

GO
/****** Object:  StoredProcedure [PERSONA].[ListarRegionesPorIdPais]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarRegionesPorIdPais]
		@id_pais [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_region, id_pais, nom_region
	FROM PERSONA.DIRECCION_REGION
	WHERE (id_pais = @id_pais )

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarTelefonosPorPersona]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarTelefonosPorPersona]
		@id_persona [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_persona, codigo_pais, campo_1, campo_2, campo_3, ext
	FROM PERSONA.TELEFONO
	WHERE (id_persona = @id_persona OR @id_persona IS NULL)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ListarTelefonosTipos]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ListarTelefonosTipos]
		
AS
	SET NOCOUNT ON


	SELECT tipo_telefono, nombre_telefono
	FROM PERSONA.TELEFONOS_TIPOS

GO
/****** Object:  StoredProcedure [PERSONA].[ModificarCliente]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ModificarCliente]
	(
		@id_persona [int],
		@marketing [int],
		@nom_cliente [varchar](200),
		@doc_oficial [varchar](16)
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		UPDATE PERSONA.CLIENTE
		SET id_persona = @id_persona, marketing = @marketing, nom_cliente = @nom_cliente, doc_oficial = @doc_oficial
		WHERE (id_persona = @id_persona OR @id_persona IS NULL)
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ModificarDireccion]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ModificarDireccion]
	(
		@id_direccion [int],
		@tipo_direccion [tinyint],
		@id_persona [int],
		@dir_pais [tinyint],
		@dir_provincia [int],
		@dir_ciudad [int],
		@dir_distrito [int],
		@dir_linea_1 [nvarchar](100),
		@dir_linea_2 [nvarchar](100),
		@dir_codigo_postal [varchar](10)
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		UPDATE PERSONA.DIRECCION
		SET  tipo_direccion = @tipo_direccion, id_persona = @id_persona, dir_pais = @dir_pais, dir_provincia = @dir_provincia, 
				dir_ciudad = @dir_ciudad, dir_distrito = @dir_distrito, dir_linea_1 = @dir_linea_1, dir_linea_2 = @dir_linea_2, 
				dir_codigo_postal = @dir_codigo_postal
		WHERE (id_direccion = @id_direccion)
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ModificarEmail]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ModificarEmail]
	(
		@tipo_email [tinyint],
		@id_email [int],
		@id_persona [int],
		@direccion_email [varchar](320)
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		UPDATE PERSONA.EMAIL
		SET tipo_email = @tipo_email, direccion_email = @direccion_email
		WHERE (id_email = @id_email)
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ModificarEmpleado]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ModificarEmpleado]
	(
		@id_persona [int],
		@puesto_empleado [smallint],
		@doc_oficial [char](8),
		@ruc_empleado [char](11),
		@fecha_nacimiento [date],
		@fecha_inicio [date],
		@primer_nom [varchar](50),
		@segundo_nom [varchar](50),
		@primer_ape [varchar](50),
		@segundo_ape [varchar](50)
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		UPDATE PERSONA.EMPLEADO
		SET id_persona = @id_persona, puesto_empleado = @puesto_empleado, doc_oficial = @doc_oficial, ruc_empleado = @ruc_empleado, fecha_nacimiento = @fecha_nacimiento, fecha_inicio = @fecha_inicio, primer_nom = @primer_nom, segundo_nom = @segundo_nom, primer_ape = @primer_ape, segundo_ape = @segundo_ape
		WHERE (id_persona = @id_persona OR @id_persona IS NULL)
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[ModificarTelefono]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[ModificarTelefono]
	(
		@id_telefono [int],
		@tipo_telefono [tinyint],
		@codigo_pais [varchar](5),
		@campo_1 [varchar](5),
		@campo_2 [varchar](5),
		@campo_3 [varchar](5),
		@ext [varchar](5)
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		UPDATE PERSONA.TELEFONO
		SET codigo_pais = @codigo_pais, tipo_telefono = @tipo_telefono,
				campo_1 = @campo_1, campo_2 = @campo_2, campo_3 = @campo_3, ext = @ext
		WHERE (id_telefono = @id_telefono)
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[NewEmpleado]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[NewEmpleado]
	(
		@id_persona [int],
		@puesto_empleado [smallint],
		@doc_oficial [char](8),
		@ruc_empleado [char](11),
		@fecha_nacimiento [date],
		@fecha_inicio [date],
		@primer_nom [varchar](50),
		@segundo_nom [varchar](50),
		@primer_ape [varchar](50),
		@segundo_ape [varchar](50)
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	INSERT INTO PERSONA.EMPLEADO
	(
		id_persona, puesto_empleado, doc_oficial, ruc_empleado, fecha_nacimiento, fecha_inicio, primer_nom, segundo_nom, primer_ape, segundo_ape
	)
	VALUES
	(
		@id_persona,
		@puesto_empleado,
		@doc_oficial,
		@ruc_empleado,
		@fecha_nacimiento,
		@fecha_inicio,
		@primer_nom,
		@segundo_nom,
		@primer_ape,
		@segundo_ape

	)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[NewPerson]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[NewPerson]
(
  @NewId int output
)
AS 
BEGIN 
  INSERT INTO PERSONA.ID_PERSONA (uid)
    SELECT NEWID();
  SET @NewId = SCOPE_IDENTITY()
  RETURN @NewId;
END
GO
/****** Object:  StoredProcedure [PERSONA].[NuevoCliente]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





--- Insertar cliente nuevo
CREATE PROCEDURE [PERSONA].[NuevoCliente]
(
	@ficha_marketing int,
	@nom_cliente varchar(200),
	@doc_oficial varchar(16)
)
AS
	DECLARE @nid int
IF 
	(@ficha_marketing IS NULL)	OR 
	(@nom_cliente IS NULL)	OR
	(@doc_oficial IS NULL)
	BEGIN
		PRINT 'Ha ingresado un parametro invalido'
		RETURN -1
END
IF NOT EXISTS
	(SELECT id_ficha_marketing FROM MARKETING.FICHA_MARKETING
								WHERE id_ficha_marketing = @ficha_marketing)
	BEGIN
		PRINT 'La ficha de marketing no existe'
		RETURN -2
END
BEGIN TRAN
EXEC @nid = PERSONA.NewPerson @nid
	INSERT INTO PERSONA.CLIENTE (id_persona, marketing,nom_cliente,doc_oficial)
						VALUES (@nid,@ficha_marketing,@nom_cliente,@doc_oficial)
	IF @@ERROR <> 0
		BEGIN
			PRINT 'Ocurrio un error en la transaccion, vuelve a intentar'
			ROLLBACK TRAN
			RETURN -100
		END
	COMMIT TRAN
	RETURN 0 
GO
/****** Object:  StoredProcedure [PERSONA].[NuevoEmpleado]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




--- Insertar empleado nuevo
CREATE PROCEDURE [PERSONA].[NuevoEmpleado]
(
	@puesto int,
	@doc_oficial varchar(8),
	@ruc varchar(11),
	@fecha_nac date,
	@fecha_inicio date,
	@primer_nom varchar(50),
	@primer_ape varchar(50),
	@segundo_nom varchar(50),
	@segundo_ape varchar(50)
)
AS
	DECLARE @nid int
IF 
	(@puesto IS NULL)	OR 
	(@doc_oficial IS NULL)	OR
	(@ruc IS NULL)OR
	(@fecha_nac IS NULL)OR
	(@fecha_inicio IS NULL)OR
	(@primer_ape IS NULL)OR
	(@primer_nom IS NULL)OR
	(@segundo_ape IS NULL)
	BEGIN
		PRINT 'Ha ingresado un parametro invalido'
		RETURN -1
END
IF EXISTS
	(SELECT doc_oficial FROM PERSONA.EMPLEADO
								WHERE doc_oficial = @doc_oficial)
	BEGIN
		PRINT 'El DNI ya existe'
		RETURN -2
END

IF EXISTS
	(SELECT ruc_empleado FROM PERSONA.EMPLEADO
								WHERE ruc_empleado = @ruc)
	BEGIN
		PRINT 'El RUC ya existe'
		RETURN -3
END

IF NOT EXISTS
	(SELECT id_puesto FROM PERSONA.PUESTO
								WHERE id_puesto = @puesto)
	BEGIN
		PRINT 'El puesto no existe'
		RETURN -3
END

BEGIN TRAN
EXEC @nid = PERSONA.NewPerson @nid
	INSERT INTO PERSONA.EMPLEADO(id_persona, puesto_empleado,doc_oficial,ruc_empleado,fecha_nacimiento,fecha_inicio,primer_nom,primer_ape,segundo_ape,segundo_nom)
						VALUES (@nid,@puesto,@doc_oficial,@ruc,@fecha_nac,@fecha_inicio,@primer_nom,@primer_ape,@segundo_ape,@segundo_nom)
	IF @@ERROR <> 0
		BEGIN
			PRINT 'Ocurrio un error en la transaccion, vuelve a intentar'
			ROLLBACK TRAN
			RETURN -100
		END
	COMMIT TRAN
	RETURN 0 
GO
/****** Object:  StoredProcedure [PERSONA].[PersonaDeInteresNew]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[PersonaDeInteresNew]
	(
		@id_persona [int],
		@id_directorio [int],
		@id_proyecto [int],
		@puesto [smallint],
		@nom_persona [varchar](200)
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	INSERT INTO PERSONA.PERSONA_DE_INTERES
	(
		id_persona, id_directorio, id_proyecto, puesto, nom_persona
	)
	VALUES
	(
		@id_persona,
		@id_directorio,
		@id_proyecto,
		@puesto,
		@nom_persona

	)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[SelectDireccion]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[SelectDireccion]
		@id_direccion [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_direccion, tipo_direccion, id_persona, dir_pais, dir_provincia, dir_ciudad, dir_distrito, dir_linea_1, dir_linea_2, dir_codigo_postal
	FROM PERSONA.DIRECCION
	WHERE (id_direccion = @id_direccion)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[SelectEmail]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[SelectEmail]
		@id_email [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT tipo_email, id_email, id_persona, direccion_email
	FROM PERSONA.EMAIL
	WHERE (id_email = @id_email )

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[SelectTelefono]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[SelectTelefono]
		@id_telefono [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_telefono, tipo_telefono, id_persona, codigo_pais, campo_1, campo_2, campo_3, ext
	FROM PERSONA.TELEFONO
	WHERE (id_telefono = @id_telefono)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[TelefonoNew]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[TelefonoNew]
	(
		@id_persona [int],
		@tipo_telefono [tinyint],
		@codigo_pais [varchar](5),
		@campo_1 [varchar](5),
		@campo_2 [varchar](5),
		@campo_3 [varchar](5),
		@ext [varchar](5)
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	INSERT INTO PERSONA.TELEFONO
	(
		id_persona, tipo_telefono, codigo_pais, campo_1, campo_2, campo_3, ext
	)
	VALUES
	(
	
		@id_persona,
		@tipo_telefono,
		@codigo_pais,
		@campo_1,
		@campo_2,
		@campo_3,
		@ext

	)

	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[UpdateEstado]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[UpdateEstado]
	(
		@id_persona [int],
		@estado [bit]
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		UPDATE PERSONA.EMPLEADO
		SET   estado = @estado
		WHERE (id_persona = @id_persona )
	COMMIT
GO
/****** Object:  StoredProcedure [PERSONA].[UpdatePersonaInteres]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PERSONA].[UpdatePersonaInteres]
	(
		@id_persona [int],
		@id_directorio [int],
		@id_proyecto [int],
		@puesto [smallint],
		@nom_persona [varchar](200)
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		UPDATE PERSONA.PERSONA_DE_INTERES
		SET id_persona = @id_persona, id_directorio = @id_directorio, id_proyecto = @id_proyecto, puesto = @puesto, nom_persona = @nom_persona
		WHERE (id_persona = @id_persona OR @id_persona IS NULL)
	COMMIT
GO
/****** Object:  StoredProcedure [PROYECTO].[FinalizarProyecto]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- Proc para finalizar un proyecto
CREATE PROCEDURE [PROYECTO].[FinalizarProyecto]
(
	@fechaFin date,
	@id_proyecto int
)
AS
IF 
	(@id_proyecto IS NULL)	OR 
	(@fechaFin IS NULL)	 
	BEGIN
		PRINT 'Ha ingresado un parametro invalido'
		RETURN -1
END

IF NOT EXISTS
	(SELECT id_proyecto FROM PROYECTO.PROYECTO
								WHERE id_proyecto = @id_proyecto)
	BEGIN
		PRINT 'El proyecto no existe'
		RETURN -2
END

IF 
	(SELECT fecha_inicio FROM PROYECTO.PROYECTO
								WHERE id_proyecto = @id_proyecto) > @fechaFin
	BEGIN
		PRINT 'La fecha de finalizacion es antes que la de inicio'
		RETURN -3
END

BEGIN TRAN
	UPDATE PROYECTO.PROYECTO 
	SET fecha_fin = @fechaFin 
	WHERE id_proyecto = @id_proyecto

	IF @@ERROR <> 0
		BEGIN
			PRINT 'Ocurrio un error en la transaccion, vuelve a intentar'
			ROLLBACK TRAN
			RETURN -100
		END
	COMMIT TRAN
	RETURN 0 
GO
/****** Object:  StoredProcedure [PROYECTO].[ListarDivisiones]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PROYECTO].[ListarDivisiones]
		
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_division, nombre_division
	FROM PROYECTO.DIVISION


	COMMIT
GO
/****** Object:  StoredProcedure [PROYECTO].[ListarProyectoPorId]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PROYECTO].[ListarProyectoPorId]
		@id_proyecto [int]
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_proyecto, id_cliente, id_division, nom_proyecto, dir_proyecto, fecha_inicio, fecha_fin
	FROM PROYECTO.PROYECTO
	WHERE (id_proyecto = @id_proyecto )

	COMMIT
GO
/****** Object:  StoredProcedure [PROYECTO].[ListarProyectos]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PROYECTO].[ListarProyectos]

AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	SELECT id_proyecto AS [ID Proyecto], c.nom_cliente AS [Nombre de Cliente], d.nombre_division AS [Division], 
				nom_proyecto AS [Nombre], dir_proyecto AS [Direccion], fecha_inicio AS [Fecha de Inicio], fecha_fin  AS [Fecha de Fin]
	FROM PROYECTO.PROYECTO
	INNER JOIN PROYECTO.DIVISION d ON PROYECTO.PROYECTO.id_division = d.id_division
	INNER JOIN PERSONA.CLIENTE c ON c.id_persona = PROYECTO.PROYECTO.id_cliente

	COMMIT
GO
/****** Object:  StoredProcedure [PROYECTO].[NuevoProyecto]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Proc para insertar un proyecto nuevo
CREATE PROCEDURE [PROYECTO].[NuevoProyecto]
(
	@id_cliente int, 
	@id_division tinyint,
	@nom_proyecto varchar(99),
	@dir_proyecto int,
	@fecha_inicio date
)
AS
	DECLARE @id_proy_nuevo int 
IF 
	(@id_cliente IS NULL)	OR 
	(@id_division IS NULL)	OR 
	(@nom_proyecto IS NULL)	OR
	(@dir_proyecto IS NULL)	OR
	(@fecha_inicio IS NULL)
	BEGIN
		PRINT 'Ha ingresado un parametro invalido'
		RETURN -1
END

IF NOT EXISTS
	(SELECT id_persona FROM PERSONA.CLIENTE 
								WHERE id_persona = @id_cliente)
	BEGIN
		PRINT 'El cliente no existe'
		RETURN -2
END

IF NOT EXISTS
	(SELECT id_division FROM PROYECTO.DIVISION 
								WHERE id_division = @id_division)
	BEGIN
		PRINT 'La division no existe'
		RETURN -3
END

IF NOT EXISTS
	(SELECT id_direccion FROM PERSONA.DIRECCION
								WHERE id_direccion = @dir_proyecto)
	BEGIN
		PRINT 'La direccion no existe'
		RETURN -4
END

BEGIN TRAN
	INSERT INTO PROYECTO.PROYECTO (id_cliente, id_division, nom_proyecto, dir_proyecto, fecha_inicio, fecha_fin)
	                       VALUES (@id_cliente,@id_division,@nom_proyecto,@dir_proyecto,@fecha_inicio, '')
	SET @id_proy_nuevo = SCOPE_IDENTITY()
	IF @@ERROR <> 0
		BEGIN
			PRINT 'Ocurrio un error en la transaccion, vuelve a intentar'
			ROLLBACK TRAN
			RETURN -100
		END
	COMMIT TRAN
	RETURN @id_proy_nuevo --Decuelve el ID del nuevo proyecto
GO
/****** Object:  StoredProcedure [PROYECTO].[ProyectoNew]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PROYECTO].[ProyectoNew]
	(
		@id_cliente [int],
		@id_division [tinyint],
		@nom_proyecto [varchar](99),
		@dir_proyecto [nvarchar](99),
		@fecha_inicio [date]
		
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION

	INSERT INTO PROYECTO.PROYECTO
	(
		id_cliente, id_division, nom_proyecto, dir_proyecto, fecha_inicio
	)
	VALUES
	(
		@id_cliente,
		@id_division,
		@nom_proyecto,
		@dir_proyecto,
		@fecha_inicio

	)

	COMMIT
GO
/****** Object:  StoredProcedure [PROYECTO].[UpdateProyecto]    Script Date: 7/8/2020 8:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [PROYECTO].[UpdateProyecto]
	(
		@id_proyecto [int],
		@id_cliente [int],
		@id_division [tinyint],
		@nom_proyecto [varchar](99),
		@dir_proyecto [nvarchar](99),
		@fecha_inicio [date],
		@fecha_fin [date]
	)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON
	
	BEGIN TRANSACTION
		UPDATE PROYECTO.PROYECTO
		SET  id_cliente = @id_cliente, id_division = @id_division, nom_proyecto = @nom_proyecto, dir_proyecto = @dir_proyecto, fecha_inicio = @fecha_inicio, fecha_fin = @fecha_fin
		WHERE (id_proyecto = @id_proyecto OR @id_proyecto IS NULL)
	COMMIT
GO
