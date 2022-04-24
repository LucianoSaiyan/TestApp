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
--5) Alquilar y Vender películas
ALTER PROCEDURE AlquilarVender --1,3
	@cod_genero int,	
	@cod_pelicula int
AS
BEGIN
	
	--ALTER TABLE tPelicula
	--add idGenero int

	--ALTER TABLE tPelicula
	--ADD FOREIGN KEY (idGenero) REFERENCES [tGenero](cod_genero);

	if exists(select * from [dbo].[tGenero] where [cod_genero] = @cod_genero)
	begin 
		if not exists(select * from tPelicula where [idGenero] = @cod_genero)
	BEGIN
		update [dbo].[tPelicula] set [idGenero] = @cod_genero where [cod_pelicula] = @cod_pelicula 
	--INSERT INTO tPelicula (idGenero) VALUES (@cod_genero)
	declare @pelicula as nvarchar(500) = (SELECT [txt_desc] from [dbo].[tPelicula] where [cod_pelicula] = @cod_pelicula ) 
	declare @genero as nvarchar(500) = (SELECT [txt_desc] from [dbo].[tGenero] where [cod_genero] = @cod_genero ) 
	print 'Se ingreso el genero '+ @genero + ' en la pelicula '+ @pelicula + ' correctamente' 
	END
	else
	begin 
		print 'LA PELICULA YA TIENE ESE GENERO'
	end
	end
	else
	begin 
		print 'EL GENERO NO EXISTE,PRIMERO DEBE CREAR EL GENERO'
	end
	--SELECT * from [dbo].[tPelicula]
	--SELECT * from [dbo].[tGenero]
END
GO
