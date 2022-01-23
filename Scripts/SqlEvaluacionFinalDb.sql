USE EvaluacionFinalDb
GO

IF EXISTS (SELECT* FROM INFORMATION_SCHEMA.TABLES T WHERE T.TABLE_NAME = 'Producto') BEGIN
	DROP TABLE dbo.Producto;
END
IF EXISTS (SELECT* FROM INFORMATION_SCHEMA.TABLES T WHERE T.TABLE_NAME = 'Categoria') BEGIN
	DROP TABLE dbo.Categoria;
END

CREATE TABLE dbo.Categoria(
	IdCategoria int identity(1,1) NOT NULL,
	Nombre nvarchar(100) NOT NULL,
	Descripcion nvarchar(200) NOT NULL,
	Habilitado bit NOT NULL,

	CONSTRAINT PK_Categoria PRIMARY KEY (IdCategoria)
)

CREATE TABLE dbo.Producto(
	IdProducto int identity(1,1) NOT NULL,
	IdCategoria int NOT NULL,
	Nombre nvarchar(100) NOT NULL,
	PrecioUnitario numeric NOT NULL,
	Habilitado bit NOT NULL,

	CONSTRAINT PK_Producto PRIMARY KEY (IdProducto),
	CONSTRAINT FK_Producto_001 FOREIGN KEY (IdCategoria) REFERENCES dbo.Categoria(IdCategoria)
)