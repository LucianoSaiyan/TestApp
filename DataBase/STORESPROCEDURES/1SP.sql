-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
USE [TestCrud]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--1) Crear usuarios, cuyo documento no exista actualmente en la base de datos, en
--caso de existir, debería devolver un mensaje de error, en caso contrario insertarlo
ALTER PROCEDURE CrearUsuarios --'Lucho', 'user123', 'Luciano Leonel', 'Gomez', '30639655'	
	@txt_user nvarchar(50),
	@txt_password nvarchar(50),
	@txt_nombre nvarchar(50),
	@txt_apellido nvarchar(50),
	@nro_doc nvarchar(50)
AS
BEGIN
	
	if not exists(select * from [dbo].[tUsers] where [nro_doc] = @nro_doc)
	BEGIN
	INSERT INTO [dbo].[tUsers] VALUES (@txt_user, @txt_password, @txt_nombre, @txt_apellido, @nro_doc, 1, -1)
	END
	else
	begin 
	print 'Ocurrio un error'
	end
END
GO
