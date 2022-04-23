-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--4) Asignar géneros a películas, verificar que la película no tenga asignada el
--género previamente
CREATE PROCEDURE AsignargenerosaPeliculas --2,3
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