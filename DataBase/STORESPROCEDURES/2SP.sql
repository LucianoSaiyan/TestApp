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
--2) Crear/Borrar/Modificar peliculas (Borrar es poner en 0 el stock de ventas y
--alquileres)
ALTER PROCEDURE CrearBorrarModificarpeliculas --'Crear' ,null ,'Batman', 3, 0,1.5,5.0
	@Operacion nvarchar(50) ,
	@cod_pelicula int = null,
	@txt_desc nvarchar(500),
	@cant_disponibles_alquiler int,
	@cant_disponibles_venta int,
	@precio_alquiler numeric(18,2),
	@precio_venta numeric(18,2)
AS
BEGIN
	
	if (@Operacion = 'Crear')
	BEGIN
	INSERT INTO [dbo].[tPelicula] VALUES (@txt_desc, @cant_disponibles_alquiler, @cant_disponibles_venta
	,@precio_alquiler,@precio_venta)
	print 'Se ingreso la pelicula '+ @txt_desc + ' correctamente' 
	END
	else if(@Operacion = 'Borrar')
	begin 
	update [dbo].[tPelicula] set [cant_disponibles_venta] = 0  where [cod_pelicula] = @cod_pelicula 
	print 'Se elimino la pelicula' + @cod_pelicula
	end
	else if(@Operacion = 'Modificar')
	begin 
	update [dbo].[tPelicula] set [txt_desc] = @txt_desc,[cant_disponibles_alquiler]=@cant_disponibles_alquiler ,
	[cant_disponibles_venta] = @cant_disponibles_venta ,[precio_alquiler] = @precio_alquiler,
	[precio_venta] = @precio_venta  where [cod_pelicula] = @cod_pelicula 
	print 'Se actualizo la pelicula ' + @txt_desc
	end
	--SELECT * from [dbo].[tPelicula]
END
GO
