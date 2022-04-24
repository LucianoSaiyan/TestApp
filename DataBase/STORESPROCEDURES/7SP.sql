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
--7) Obtener las películas en stock para vender
ALTER PROCEDURE STOCKVENDER --1,3
	@cod_genero int,	
	@cod_pelicula int
AS
BEGIN	
	select COUNT([cant_disponibles_venta]),[cod_pelicula],[txt_desc],[cant_disponibles_venta]
	from [dbo].[tPelicula] p 
	group by [cod_pelicula],[cant_disponibles_venta],[cod_pelicula] ,[txt_desc]
	HAVING COUNT([cant_disponibles_venta]) > 0
END
GO
