-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--3) Crear géneros
CREATE PROCEDURE Creargeneros --'NUEVO GENERO'
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
	--SELECT * from [dbo].[tPelicula]
END