CREATE TABLE [dbo].[TiposUsuarios] (
    [IdTipoUsuario]   INT           NOT NULL,
    [DescripcionTipo] NVARCHAR (50) NULL,
    CONSTRAINT [PK_TiposUsuarios] PRIMARY KEY CLUSTERED ([IdTipoUsuario] ASC)
);

