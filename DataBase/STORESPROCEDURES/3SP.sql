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
--3) Crear géneros
CREATE PROCEDURE Creargeneros 'NUEVO GENERO'
	@txt_desc nvarchar(500)
AS
BEGIN
	
	if not exists(select * from [dbo].[tGenero] where [txt_desc] = @txt_desc)
	BEGIN
	INSERT INTO [dbo].[tGenero] VALUES(@txt_desc)
	print 'Se ingreso el genero '+ @txt_desc + ' correctamente' 
	END
	else
	begin 
	print 'EL GENERO YA EXISTO'
	end
	--SELECT * from [dbo].[tGenero]
END
GO
