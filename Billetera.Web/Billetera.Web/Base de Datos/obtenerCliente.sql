USE [clip-money]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[obtenerCliente]
	@id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [nombre]
      ,[apellido]
      ,[sexo]
      ,[fecha_nacimiento]
      ,[id_tipo_dni]
      ,[num_dni]
      ,[foto_frente_dni]
      ,[foto_dorso_dni]
      ,[id_localidad]
      ,[domicilio]
      ,[telefono]
      ,[email]
      ,[id_situacion_crediticia]
      ,[nombre_usuario]
      ,[password]
    FROM [dbo].[cliente]
	WHERE id=@id

END
GO