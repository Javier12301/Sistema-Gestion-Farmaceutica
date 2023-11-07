use SistemaGestionFarmaceutica;

-- Tabla para almacenar informaci�n sobre estantes en el inventario
CREATE TABLE EstantesModel(
	EstanteID INT IDENTITY(1,1) PRIMARY KEY,      -- Clave primaria autonum�rica
	NombreEstante NVARCHAR(255) NOT NULL,               -- Nombre del estante
	NumeroEstante INT NOT NULL,              -- N�mero de estante
	SectorEstante NVARCHAR(255) NOT NULL                -- Sector del estante
);


-- Tabla para almacenar informaci�n sobre categor�as de productos y medicamentos
CREATE TABLE CategoriasModel(
	CategoriaID INT IDENTITY(1,1) PRIMARY KEY,    -- Clave primaria autonum�rica
	NombreCategoria NVARCHAR(255) NOT NULL,               -- Nombre de la categor�a
	DescripcionCategoria NVARCHAR(255) NOT NULL          -- Descripci�n de la categor�a
);

-- Tabla para almacenar informaci�n sobre proveedores o droguer�as
CREATE TABLE ProveedoresModel(
	ProveedorID INT IDENTITY(1,1) PRIMARY KEY,   -- Clave primaria autonum�rica
	NombreProveedor NVARCHAR(255) NOT NULL,               -- Nombre del proveedor
	DireccionProveedor NVARCHAR(255) NOT NULL,            -- Direcci�n del proveedor
	TelefonoProveedor NVARCHAR(20) NOT NULL               -- Tel�fono del proveedor
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

CREATE TABLE MedicamentosModel(
    MedicamentoID INT IDENTITY(1,1) PRIMARY KEY,
    EstanteID INT FOREIGN KEY REFERENCES EstantesModel(EstanteID),
    CategoriaID INT FOREIGN KEY REFERENCES CategoriasModel(CategoriaID),
	ProveedoresID INT FOREIGN KEY REFERENCES ProveedoresModel(ProveedoresID),
	CodigoBarrasProductoID INT FOREIGN KEY REFERENCES CodigosDeBarrasModel(CodigoID),
	PrecioProductoID INT FOREIGN KEY REFERENCES PrecioProductoModel(PrecioProductoID),
	CostoProductoID INT FOREIGN KEY REFERENCES CostoProductoModel(CostoProductoID),
    LoteID INT FOREIGN KEY REFERENCES LotesModel(LoteID) -- Agregada columna para el n�mero de lote
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

--TABLAS DE ALMACENAMIENTO DE COSTO Y PRECIOS DE VENTA --
CREATE TABLE CostoProductoModel (
    CostoProductoID INT IDENTITY(1,1) PRIMARY KEY,
    CostoProducto DECIMAL(10, 2) NOT NULL,
    IVA DECIMAL(5, 2) NOT NULL,
    CostoConIVA DECIMAL(10, 2) NOT NULL
);

-- Tabla para almacenar informaci�n de precios de venta
CREATE TABLE PrecioProductoModel (
    PrecioProductoID INT IDENTITY(1,1) PRIMARY KEY,
    PrecioVenta DECIMAL(10, 2) NOT NULL,
    Descuento DECIMAL(5, 2) NOT NULL,
    IVA DECIMAL(5, 2) NOT NULL,
    PrecioConIVA DECIMAL(10, 2) NOT NULL,
);
-- FIN DE TABLAS DE ALMACENAMIENTO DE COSTO Y PRECIOS DE VENTA --

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

SELECT * FROM ProveedoresModel;

SELECT * FROM LotesModel;

SELECT * FROM MedicamentosModel;

-- Eliminar todo los valores de la tabla MedicamentosModel
DELETE FROM CategoriasModel;

SELECT * FROM CodigosDeBarrasModel;

DROP VIEW VistaInventarioMedicamento;

CREATE TABLE MedicamentosLotesModel(
	MedicamentoLoteID INT IDENTITY(1,1) PRIMARY KEY,  -- Clave primaria autonum�rica
	LoteID INT FOREIGN KEY REFERENCES LotesModel(LoteID),           -- Clave externa que se relaciona con la tabla de lotes
	MedicamentoID INT FOREIGN KEY REFERENCES MedicamentosModel(MedicamentoID) -- Clave externa que se relaciona con la tabla de medicamentos
);

-- Crear un lote
INSERT INTO LotesModel (Numero_Lote, Stock, Nombre_Medicamento, FechaVencimiento)
VALUES ('Lote1', 100, 'Medicamento C', '2024-12-31');

INSERT INTO CategoriasModel (Nombre, Descripcion) VALUES ('Analg�sicos', 'Medicamentos para el alivio del dolor');
INSERT INTO CategoriasModel (Nombre, Descripcion) VALUES ('Antibi�ticos', 'Medicamentos para combatir infecciones bacterianas');
INSERT INTO CategoriasModel (Nombre, Descripcion) VALUES ('Antiinflamatorios', 'Medicamentos para reducir la inflamaci�n');
INSERT INTO CategoriasModel (Nombre, Descripcion) VALUES ('Antipir�ticos', 'Medicamentos para reducir la fiebre');
INSERT INTO CategoriasModel (Nombre, Descripcion) VALUES ('Antihistam�nicos', 'Medicamentos para aliviar alergias');



-- Crear un medicamento y relacionarlo con el lote
INSERT INTO MedicamentosModel (EstanteID, CategoriaID, PrecioUnitario, CodigoID)
VALUES (13, 7, 2, 1); -- Supongamos que el ID del C�digo de Barras es 1

INSERT INTO MedicamentosModel (EstanteID, CategoriaID, PrecioUnitario, CodigoID)
VALUES (14, 13, 15.99,3);

-- Medicamento 2
INSERT INTO MedicamentosModel (EstanteID, CategoriaID, PrecioUnitario, CodigoID)
VALUES (17, 7, 9.99,2);

-- Medicamento 3
INSERT INTO MedicamentosModel (EstanteID, CategoriaID, PrecioUnitario)
VALUES (11, 14, 12.99);


SELECT * 
FROM MedicamentosModel
WHERE CategoriaID = CategoriaID;

--SELECT * FROM MedicamentosDetalle

SELECT * FROM VistaInventarioMedicamento;

-- Crear un view para mostrar datos de inventarios de medicamentos, que se vea c�digo, lote, descripci�n, cantidad, vencimiento, categor�a, nombre estante, sector y n�mero de estante


--CREATE VIEW VistaInventarioMedicamento AS
--SELECT
--    CodigosDeBarrasModel.CodigoDeBarras AS Codigo,
--    LotesModel.Numero_Lote AS Lote,
--    LotesModel.Nombre_Medicamento AS Descripcion,
--    LotesModel.Stock AS Cantidad,
--    LotesModel.FechaVencimiento AS Vencimiento,
--    CategoriasModel.Nombre AS Categoria,
--    EstantesModel.Nombre AS [Nombre estante],
--    EstantesModel.Sector AS Sector,
--    EstantesModel.Numero_de_estante AS [Numero estante]
--FROM
--    LotesModel
--INNER JOIN MedicamentosLotesModel ON LotesModel.LoteID = MedicamentosLotesModel.LoteID
--INNER JOIN MedicamentosModel ON MedicamentosLotesModel.MedicamentoID = MedicamentosModel.MedicamentoID
--INNER JOIN CategoriasModel ON MedicamentosModel.CategoriaID = CategoriasModel.CategoriaID
--INNER JOIN EstantesModel ON MedicamentosModel.EstanteID = EstantesModel.EstanteID
--INNER JOIN CodigosDeBarrasModel ON MedicamentosModel.CodigoID = CodigosDeBarrasModel.CodigoID;

