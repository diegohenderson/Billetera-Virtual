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

CREATE PROCEDURE [dbo].[modificarCliente]
	@id int, @nombre char(25), @apellido char(25), @sexo char(9), @fecha_nacimiento date, @id_tipo_dni tinyint, @num_dni varchar(15), @foto_frente_dni image, @foto_dorso_dni image, @id_localidad int, @domicilio varchar(30), @telefono varchar(20), @email varchar(50), @id_situacion_crediticia tinyint, @nombre_usuario varchar(50), @password varchar(30)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SET @fecha_nacimiento = (SELECT Format(getdate(), 'dd-MM-yyyy') as date);

	UPDATE [dbo].[cliente] SET
	  [nombre] = @nombre,
	  [apellido] = @apellido,
      [sexo] = @sexo,
      [fecha_nacimiento] = @fecha_nacimiento,
      [id_tipo_dni] = @id_tipo_dni,
      [num_dni] = @num_dni,
      [foto_frente_dni] =  @foto_frente_dni,
      [foto_dorso_dni] = @foto_dorso_dni,
      [id_localidad] = @id_localidad,
      [domicilio] = @domicilio,
      [telefono] = @telefono,
      [email] = @email,
      [id_situacion_crediticia] = @id_situacion_crediticia,
      [nombre_usuario] = @nombre_usuario,
      [password] = @password
    WHERE id=@Id

END
GO


