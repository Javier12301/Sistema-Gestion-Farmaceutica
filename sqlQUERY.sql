use SistemaGestionFarmaceutica

USE SistemaGestionFarmaceutica; -- Reemplaza "NombreDeTuBaseDeDatos" por el nombre de tu base de datos
CREATE TABLE EstantesModel(
	EstanteID INT IDENTITY(1,1) PRIMARY KEY,
	Nombre NVARCHAR(255) NOT NULL,
	Numero_de_estante INT NOT NULL,
	Sector NVARCHAR(255) NOT NULL
);

CREATE TABLE CategoriasModel(
	CategoriaID INT IDENTITY(0,1) PRIMARY KEY,
	Nombre NVARCHAR(255) NOT NULL,
	Descripcion NVARCHAR(255) NOT NULL
);

CREATE TABLE LotesModel(
	LoteID INT IDENTITY(1,1) PRIMARY KEY,
	Numero_Lote NVARCHAR(255),
	Stock INT NOT NULL,
	Nombre_Medicamento NVARCHAR(255) NOT NULL,
	FechaVencimiento DATE NOT NULL
);


CREATE TABLE MedicamentosModel(
	LoteID INT FOREIGN KEY REFERENCES LotesModel(LoteID),
	EstanteID INT FOREIGN KEY REFERENCES EstantesModel(EstanteID),
	CategoriaID INT FOREIGN KEY REFERENCES CategoriasModel(CategoriaID),
	PrecioUnitario DECIMAL(10, 2),
	PRIMARY KEY (LoteID)
);

CREATE TABLE ProductosModel (
    ProductoID INT IDENTITY(1,1) PRIMARY KEY,
    NombreProducto NVARCHAR(255) NOT NULL,
    DescripcionProducto NVARCHAR(255) NOT NULL,
    PrecioUnitario DECIMAL(10, 2) NOT NULL,
    EstanteID INT FOREIGN KEY REFERENCES EstantesModel(EstanteID),
    CategoriaID INT FOREIGN KEY REFERENCES CategoriasModel(CategoriaID)
);

DROP TABLE ProductosModel;
SELECT * FROM CategoriasModel;

SELECT * FROM EstantesModel;

SELECT * FROM LotesModel;

SELECT * FROM MedicamentosModel;