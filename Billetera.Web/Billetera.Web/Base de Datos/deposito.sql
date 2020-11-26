USE [clip-money]
GO

/****** Object:  StoredProcedure [dbo].[deposito]    Script Date: 08/11/2020 19:24:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[deposito]
	@monto money, @id_cuenta_virtual bigint
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	begin transaction transaccion_deposito

	declare @fecha_actual date;
	declare @hora_actual time;
	SET @fecha_actual = (SELECT Format(GETDATE(), 'yyyy-MM-dd'));
	SET @hora_actual = (SELECT Format(GETDATE(), 'HH:mm'));

    insert into operaciones (num_operacion,fecha,hora,monto,id_tipo_operacion,id_estado,id_cuenta_virtual) values ('1234567',@fecha_actual,@hora_actual,@monto,3,6,@id_cuenta_virtual);

	commit;
END
GO


