USE [clip-money]
GO

/****** Object:  StoredProcedure [dbo].[extraccion]    Script Date: 08/11/2020 19:25:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[extraccion]
	@monto money , @id_cuenta_virtual bigint
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	begin transaction transaccion_extracion
    
	--Primero tengo que verificar si la cuenta tiene saldo.
	declare @saldo money;

	SET @saldo = (select SUM(operaciones.monto) from cuenta_virtual inner join operaciones on (cuenta_virtual.id=operaciones.id_cuenta_virtual) where cuenta_virtual.id = 3);
	
	if 
		(@saldo >= @monto)
		begin
			declare @fecha_actual date;
			declare @hora_actual time;
			SET @fecha_actual = (SELECT Format(GETDATE(), 'yyyy-MM-dd'));
			SET @hora_actual = (SELECT Format(GETDATE(), 'HH:mm'));
		
			insert into operaciones (num_operacion,fecha,hora,monto,id_tipo_operacion,id_estado,id_cuenta_virtual) values ('1234567',@fecha_actual,@hora_actual,-1*@monto,2,6,@id_cuenta_virtual);
			print 'Extracción realizada correctamente.'
		end
	else
		print 'No hay fondos suficientes.'
	
	commit;
END
GO


