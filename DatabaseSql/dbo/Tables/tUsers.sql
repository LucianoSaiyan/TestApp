CREATE TABLE [dbo].[tUsers] (
    [cod_usuario]  INT           IDENTITY (1, 1) NOT NULL,
    [txt_user]     VARCHAR (50)  NULL,
    [txt_password] VARCHAR (50)  NULL,
    [txt_nombre]   VARCHAR (200) NULL,
    [txt_apellido] VARCHAR (200) NULL,
    [nro_doc]      VARCHAR (50)  NULL,
    [cod_rol]      INT           NULL,
    [sn_activo]    INT           NULL,
    PRIMARY KEY CLUSTERED ([cod_usuario] ASC),
    CONSTRAINT [fk_user_rol] FOREIGN KEY ([cod_rol]) REFERENCES [dbo].[tRol] ([cod_rol])
);

