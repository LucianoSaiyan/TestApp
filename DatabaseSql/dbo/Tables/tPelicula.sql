CREATE TABLE [dbo].[tPelicula] (
    [cod_pelicula]              INT             IDENTITY (1, 1) NOT NULL,
    [txt_desc]                  VARCHAR (500)   NULL,
    [cant_disponibles_alquiler] INT             NULL,
    [cant_disponibles_venta]    INT             NULL,
    [precio_alquiler]           NUMERIC (18, 2) NULL,
    [precio_venta]              NUMERIC (18, 2) NULL,
    [idGenero]                  INT             NULL,
    PRIMARY KEY CLUSTERED ([cod_pelicula] ASC),
    FOREIGN KEY ([idGenero]) REFERENCES [dbo].[tGenero] ([cod_genero])
);

