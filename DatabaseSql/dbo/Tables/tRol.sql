CREATE TABLE [dbo].[tRol] (
    [cod_rol]   INT           IDENTITY (1, 1) NOT NULL,
    [txt_desc]  VARCHAR (500) NULL,
    [sn_activo] INT           NULL,
    PRIMARY KEY CLUSTERED ([cod_rol] ASC)
);

