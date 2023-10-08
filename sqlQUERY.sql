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

CREATE TABLE CodigosDeBarrasModel(
	CodigoID INT IDENTITY(1,1) PRIMARY KEY,
	CodigoDeBarras NVARCHAR(255) NOT NULL
);

ALTER TABLE MedicamentosModel
ADD CodigoID INT FOREIGN KEY REFERENCES CodigosDeBarrasModel(CodigoID);

ALTER TABLE ProductosModel
ADD CodigoID INT FOREIGN KEY REFERENCES CodigosDeBarrasModel(CodigoID);


-- Crear la vista que muestra la información deseada
CREATE VIEW VistaMedicamentos AS
SELECT
    Lotes.Numero_Lote,
    Lotes.Nombre_Medicamento,
    Lotes.Stock AS Stock_Medicamento,
    Lotes.FechaVencimiento AS Vencimiento,
    Categorias.Nombre AS Categoria,
    Estantes.Nombre AS Estante,
    Estantes.Sector,
    Estantes.Numero_de_estante AS NumEstante
FROM
    MedicamentosModel Medicamentos
INNER JOIN
    LotesModel Lotes ON Medicamentos.LoteID = Lotes.LoteID
INNER JOIN
    CategoriasModel Categorias ON Medicamentos.CategoriaID = Categorias.CategoriaID
INNER JOIN
    EstantesModel Estantes ON Medicamentos.EstanteID = Estantes.EstanteID;


DROP TABLE ProductosModel;
SELECT * FROM CategoriasModel;

SELECT * FROM EstantesModel;

SELECT * FROM LotesModel;

SELECT * FROM MedicamentosModel;

SELECT * FROM ProductosModel;

SELECT * FROM MedicamentosDetalle

SELECT * FROM VistaMedicamentos;
