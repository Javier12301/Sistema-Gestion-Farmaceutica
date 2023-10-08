use SistemaGestionFarmaceutica;

-- Eliminar la tabla CodigosDeBarrasModel
DROP TABLE IF EXISTS CodigosDeBarrasModel;

-- Eliminar la tabla ProductosModel
DROP TABLE IF EXISTS ProductosModel;

-- Eliminar la tabla MedicamentosModel
DROP TABLE IF EXISTS MedicamentosModel;

-- Eliminar la tabla LotesModel
DROP TABLE IF EXISTS LotesModel;

-- Eliminar la tabla CategoriasModel
DROP TABLE IF EXISTS CategoriasModel;

-- Eliminar la tabla EstantesModel
DROP TABLE IF EXISTS EstantesModel;


-- Tabla para almacenar informaci�n sobre estantes en el inventario
CREATE TABLE EstantesModel(
	EstanteID INT IDENTITY(1,1) PRIMARY KEY,      -- Clave primaria autonum�rica
	Nombre NVARCHAR(255) NOT NULL,               -- Nombre del estante
	Numero_de_estante INT NOT NULL,              -- N�mero de estante
	Sector NVARCHAR(255) NOT NULL                -- Sector del estante
);

-- Tabla para almacenar informaci�n sobre categor�as de productos y medicamentos
CREATE TABLE CategoriasModel(
	CategoriaID INT IDENTITY(0,1) PRIMARY KEY,    -- Clave primaria autonum�rica
	Nombre NVARCHAR(255) NOT NULL,               -- Nombre de la categor�a
	Descripcion NVARCHAR(255) NOT NULL          -- Descripci�n de la categor�a
);

-- -- -- -- -- -- Productos y Medicamentos -- -- -- -- -- --
-- Tabla para almacenar informaci�n sobre c�digos de barras
CREATE TABLE CodigosDeBarrasModel(
	CodigoID INT IDENTITY(1,1) PRIMARY KEY,       -- Clave primaria autonum�rica
	CodigoDeBarras NVARCHAR(255) NOT NULL        -- C�digo de barras
);

-- Tabla para almacenar informaci�n sobre lotes de medicamentos
CREATE TABLE LotesModel(
	LoteID INT IDENTITY(1,1) PRIMARY KEY,         -- Clave primaria autonum�rica
	Numero_Lote NVARCHAR(255),                   -- N�mero de lote
	Stock INT NOT NULL,                          -- Cantidad en stock
	Nombre_Medicamento NVARCHAR(255) NOT NULL,   -- Nombre del medicamento
	FechaVencimiento DATE NOT NULL               -- Fecha de vencimiento del lote
);

-- Tabla para almacenar informaci�n sobre medicamentos
CREATE TABLE MedicamentosModel(
	MedicamentoID INT IDENTITY(1,1) PRIMARY KEY,  -- Clave primaria autonum�rica
	EstanteID INT FOREIGN KEY REFERENCES EstantesModel(EstanteID),       -- Clave externa que se relaciona con la tabla de estantes
	CategoriaID INT FOREIGN KEY REFERENCES CategoriasModel(CategoriaID), -- Clave externa que se relaciona con la tabla de categor�as
	PrecioUnitario DECIMAL(10, 2),               -- Precio unitario del medicamento
	CodigoID INT FOREIGN KEY REFERENCES CodigosDeBarrasModel(CodigoID)   -- Clave externa que se relaciona con la tabla de c�digos de barras
);

-- Tabla para relacionar medicamentos con sus lotes
CREATE TABLE MedicamentosLotesModel(
	MedicamentoLoteID INT IDENTITY(1,1) PRIMARY KEY,  -- Clave primaria autonum�rica
	LoteID INT FOREIGN KEY REFERENCES LotesModel(LoteID),           -- Clave externa que se relaciona con la tabla de lotes
	MedicamentoID INT FOREIGN KEY REFERENCES MedicamentosModel(MedicamentoID) -- Clave externa que se relaciona con la tabla de medicamentos
);

-- Tabla para almacenar informaci�n sobre productos
CREATE TABLE ProductosModel (
    ProductoID INT IDENTITY(1,1) PRIMARY KEY,   -- Clave primaria autonum�rica
    NombreProducto NVARCHAR(255) NOT NULL,     -- Nombre del producto
    DescripcionProducto NVARCHAR(255) NOT NULL,-- Descripci�n del producto
    PrecioUnitario DECIMAL(10, 2) NOT NULL,    -- Precio unitario del producto
    EstanteID INT FOREIGN KEY REFERENCES EstantesModel(EstanteID),       -- Clave externa que se relaciona con la tabla de estantes
    CategoriaID INT FOREIGN KEY REFERENCES CategoriasModel(CategoriaID), -- Clave externa que se relaciona con la tabla de categor�as
    CodigoID INT FOREIGN KEY REFERENCES CodigosDeBarrasModel(CodigoID)   -- Clave externa que se relaciona con la tabla de c�digos de barras
);


-- Tabla para registrar informaci�n sobre ventas
CREATE TABLE VentasModel(
	VentaID INT IDENTITY(1,1) PRIMARY KEY,                -- Clave primaria autonum�rica
	ProductoID INT FOREIGN KEY REFERENCES ProductosModel(ProductoID),     -- Clave externa que se relaciona con la tabla de productos
	MedicamentoID INT FOREIGN KEY REFERENCES MedicamentosModel(MedicamentoID), -- Clave externa que se relaciona con la tabla de medicamentos
	Cantidad INT NOT NULL,                                -- Cantidad vendida
	FechaVenta DATE NOT NULL                             -- Fecha de la venta
);



SELECT * FROM CategoriasModel;

SELECT * FROM EstantesModel;

SELECT * FROM LotesModel;

SELECT * FROM MedicamentosModel;

DROP VIEW VistaInventarioMedicamento;

--SELECT * FROM MedicamentosDetalle

SELECT * FROM VistaInventarioMedicamento;

CREATE VIEW VistaInventarioMedicamento AS
SELECT
    CodigosDeBarrasModel.CodigoDeBarras AS Codigo,
    LotesModel.Numero_Lote AS Lote,
    LotesModel.Nombre_Medicamento AS Descripcion,
    LotesModel.Stock AS Cantidad,
    LotesModel.FechaVencimiento AS Vencimiento,
    CategoriasModel.Nombre AS Categoria,
    EstantesModel.Nombre AS [Nombre estante],
    EstantesModel.Sector AS Sector,
    EstantesModel.Numero_de_estante AS [Numero estante]
FROM
    LotesModel
INNER JOIN MedicamentosLotesModel ON LotesModel.LoteID = MedicamentosLotesModel.LoteID
INNER JOIN MedicamentosModel ON MedicamentosLotesModel.MedicamentoID = MedicamentosModel.MedicamentoID
INNER JOIN CategoriasModel ON MedicamentosModel.CategoriaID = CategoriasModel.CategoriaID
INNER JOIN EstantesModel ON MedicamentosModel.EstanteID = EstantesModel.EstanteID
INNER JOIN CodigosDeBarrasModel ON MedicamentosModel.CodigoID = CodigosDeBarrasModel.CodigoID;

