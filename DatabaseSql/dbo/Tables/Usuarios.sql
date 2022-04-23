CREATE TABLE [dbo].[Usuarios] (
    [IdUsuario]     INT           NOT NULL,
    [UserName]      NVARCHAR (50) NULL,
    [IdTipoUsuario] INT           NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED ([IdUsuario] ASC),
    CONSTRAINT [FK_Usuarios_TiposUsuarios] FOREIGN KEY ([IdTipoUsuario]) REFERENCES [dbo].[TiposUsuarios] ([IdTipoUsuario])
);

