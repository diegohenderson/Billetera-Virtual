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
CREATE PROCEDURE [dbo].[existeCliente]
	@numDni varchar(15), @email varchar(50), @nombreUsuario varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [num_dni]
      ,[email]
      ,[nombre_usuario]
    FROM [dbo].[cliente]
	WHERE num_dni=@numDni OR email=@email OR nombre_usuario=@nombreUsuario

END
GO