use FarmaciaDB;
-- Tabla para almacenar información sobre estantes en el inventario
CREATE TABLE ESTANTE (
    EstanteID INT IDENTITY PRIMARY KEY,
    Nombre NVARCHAR(255) NOT NULL,
    Numero INT NOT NULL,
    Sector NVARCHAR(255) NOT NULL
);
SET IDENTITY_INSERT ESTANTE ON;
INSERT INTO ESTANTE (EstanteID, Nombre, Numero, Sector)
VALUES (0, 'N/A', 0, 'N/A');
SET IDENTITY_INSERT ESTANTE OFF;
GO



CREATE TABLE CATEGORIA (
    CategoriaID INT IDENTITY PRIMARY KEY,
    Nombre NVARCHAR(255) NOT NULL,
    Descripcion NVARCHAR(255) NOT NULL
);
SET IDENTITY_INSERT CATEGORIA ON;
INSERT INTO CATEGORIA (CategoriaID, Nombre, Descripcion)
VALUES (0, 'N/A', 'N/A');
SET IDENTITY_INSERT CATEGORIA OFF;
GO

-- Volver a habilitar IDENTITY

CREATE TABLE PROVEEDOR (
    ProveedorID INT IDENTITY PRIMARY KEY,
    RazonSocial VARCHAR(50),
    Documento VARCHAR(50),
    Direccion VARCHAR(50),
    TelefonoProveedor VARCHAR(20),
    Correo VARCHAR(50)
);
SET IDENTITY_INSERT PROVEEDOR ON;
INSERT INTO PROVEEDOR (ProveedorID, RazonSocial, Documento, Direccion, TelefonoProveedor, Correo)
VALUES (0, 'N/A', 'N/A', 'N/A', 'N/A', 'N/A');
SET IDENTITY_INSERT PROVEEDOR OFF;
GO

CREATE TABLE CLIENTE (
    ClienteID INT IDENTITY PRIMARY KEY,
    Documento VARCHAR(50),
    NombreCompleto VARCHAR(50),
    TipoClienteID INT REFERENCES TipoCliente(TipoClienteID),
    Correo VARCHAR(50),
    Telefono VARCHAR(50),
    Estado BIT,
    FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE TipoCliente (
    TipoClienteID INT IDENTITY PRIMARY KEY,
    Descripcion VARCHAR(50)
);
GO

CREATE TABLE PRODUCTO (
    ProductoID INT IDENTITY PRIMARY KEY,
    Codigo VARCHAR(50),
    Nombre VARCHAR(50),
    CategoriaID INT REFERENCES CATEGORIA(CategoriaID),
    EstanteID INT REFERENCES ESTANTE(EstanteID),
    ProveedorID INT REFERENCES PROVEEDOR(ProveedorID),
    Stock INT NOT NULL DEFAULT 0,
    PrecioCompra DECIMAL(10,2) DEFAULT 0,
    PrecioVenta DECIMAL(10,2) DEFAULT 0,
	Estado BIT,
    FechaRegistro DATETIME DEFAULT GETDATE()
);
SET IDENTITY_INSERT PRODUCTO ON;
INSERT INTO PRODUCTO (ProductoID, Codigo, Nombre, CategoriaID, EstanteID, ProveedorID, Stock, PrecioCompra, PrecioVenta, Estado)
VALUES (0, 'N/A', 'N/A', 0, 0, 0, 0, 0, 0, 1);
SET IDENTITY_INSERT PRODUCTO OFF;
GO




SELECT * FROM MEDICAMENTO;

DELETE FROM PRODUCTO



CREATE TABLE MEDICAMENTO (
    MedicamentoID INT IDENTITY PRIMARY KEY,
    Codigo VARCHAR(50),
    Nombre VARCHAR(50),
    Lote VARCHAR(50),
    FechaVencimiento DATE,
    EstanteID INT REFERENCES ESTANTE(EstanteID),
    CategoriaID INT REFERENCES CATEGORIA(CategoriaID),
    ProveedorID INT REFERENCES PROVEEDOR(ProveedorID),
    Stock INT NOT NULL DEFAULT 0,
    PrecioVenta DECIMAL(10,2) DEFAULT 0,
    PrecioCompra DECIMAL(10,2) DEFAULT 0,
    Refrigerado BIT DEFAULT 0,
    BajoReceta BIT DEFAULT 0,
	Estado BIT,
    FechaRegistro DATETIME DEFAULT GETDATE()
);
SET IDENTITY_INSERT MEDICAMENTO ON;
INSERT INTO MEDICAMENTO (MedicamentoID, Codigo, Nombre, Lote, FechaVencimiento, EstanteID, CategoriaID, ProveedorID, Stock, PrecioVenta, PrecioCompra, Refrigerado, BajoReceta, Estado)
VALUES (0, 'N/A', 'N/A', 'N/A', null, 0, 0, 0, 0, 0, 0, 0, 0, 1);
SET IDENTITY_INSERT MEDICAMENTO OFF;
GO

SELECT * FROM VistaInventario

INSERT INTO MEDICAMENTO (Codigo, Nombre, Lote, FechaVencimiento, EstanteID, CategoriaID, ProveedorID, Refrigerado, BajoReceta)
VALUES ('ABC123', 'Paracetamol', 'L12345', '2023-12-31', 1, 2, 1, 1, 0);




CREATE TABLE VENTA (
    VentaID INT IDENTITY PRIMARY KEY,
    UsuarioID INT REFERENCES USUARIO(UsuarioID),
    TipoDocumento VARCHAR(50),
    NumeroDocumento VARCHAR(50),
    DocumentoCliente VARCHAR(50),
    NombreCliente VARCHAR(100),
    MontoPago DECIMAL(10,2),
    MontoCambio DECIMAL(10,2),
    MontoTotal DECIMAL(10,2),
    FechaRegistro DATETIME DEFAULT GETDATE()
);
GO


CREATE TABLE COMPRA (
    CompraID INT IDENTITY PRIMARY KEY,
    UsuarioID INT REFERENCES USUARIO(UsuarioID),
    ProveedorID INT REFERENCES PROVEEDOR(ProveedorID),
    TipoDocumento VARCHAR(50),
    NumeroDocumento VARCHAR(50),
    MontoTotal DECIMAL(10,2),
    FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE DETALLE_COMPRA (
    DetalleCompraID INT IDENTITY PRIMARY KEY,
    CompraID INT REFERENCES COMPRA(CompraID),
    ProductoID INT REFERENCES PRODUCTO(ProductoID),
	MedicamentoID INT REFERENCES MEDICAMENTO(MedicamentoID),
    PrecioCompra DECIMAL(10,2) DEFAULT 0,
    PrecioVenta DECIMAL(10,2) DEFAULT 0,
    Cantidad INT,
    MontoTotal DECIMAL(10,2),
    FechaRegistro DATETIME DEFAULT GETDATE()
);
GO



CREATE TABLE DETALLE_VENTA (
    DetalleVentaID INT IDENTITY PRIMARY KEY,
    VentaID INT REFERENCES VENTA(VentaID),
    ProductoID INT REFERENCES PRODUCTO(ProductoID),
    MedicamentoID INT REFERENCES MEDICAMENTO(MedicamentoID),
    PrecioVenta DECIMAL(10,2),
    Cantidad INT,
    SubTotal DECIMAL(10,2),
    FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE NEGOCIO (
	NegocioID INT PRIMARY KEY,
	Nombre VARCHAR(60),
	CUIT VARCHAR(60),
	Domicilio VARCHAR(60),
	CodigoPostal VARCHAR(60),
	Ciudad VARCHAR(60),
	Provincia VARCHAR(60),
	Telefono VARCHAR (60),
	Logo VARBINARY(MAX) -- Campo para almacenar la imagen del logo (en formato binario)
);

-- Eliminación de Tablas
DROP TABLE TipoCliente;
DROP TABLE DETALLE_VENTA;
DROP TABLE DETALLE_COMPRA;
DROP TABLE VENTA;
DROP TABLE COMPRA;
DROP TABLE MEDICAMENTO;
DROP TABLE PRODUCTO;
DROP TABLE CLIENTE;
DROP TABLE PROVEEDOR;
DROP TABLE CATEGORIA;
DROP TABLE ESTANTE;
DROP TABLE USUARIO;
DROP TABLE PERMISO;
DROP TABLE ROL;

CREATE VIEW VistaInventario AS
SELECT
    M.Codigo AS 'Codigo de Barras',
    M.Nombre AS 'Nombre Medicamento',
    M.Descripcion AS 'Descripcion Medicamento',
    M.Stock AS 'Stock',
    M.FechaVencimiento AS 'Fecha de Vencimiento',
    C.Nombre AS 'Nombre Categoria',
    E.Nombre AS 'Nombre de Estante',
    E.Sector AS 'Sector de Estante',
    E.Numero AS 'Numero de Estante',
    P.RazonSocial AS 'Nombre Proveedor'
FROM
    MEDICAMENTO M
    INNER JOIN CATEGORIA C ON M.CategoriaID = C.CategoriaID
    INNER JOIN ESTANTE E ON M.EstanteID = E.EstanteID
    INNER JOIN PROVEEDOR P ON M.ProveedorID = P.ProveedorID;
GO

SELECT * FROM MEDICAMENTO;
GO

SELECT * FROM ESTANTE;
GO

SELECT * FROM CATEGORIA;
GO

SELECT * FROM PROVEEDOR;
GO
ALTER VIEW VistaInventario AS
SELECT
    M.MedicamentoID AS 'ID',
    M.Codigo AS 'Cod.',
    M.Lote AS 'Lote',
    M.Nombre AS 'Nombre',
    M.Stock AS 'Cantidad',
    M.PrecioCompra AS 'PrecioCompra',
    M.PrecioVenta AS 'PrecioVenta',
    M.FechaVencimiento AS 'VTO',
    E.Nombre AS 'Estante',
    E.Sector AS 'Sector',
    E.Numero AS 'Num. Estante',
    C.Nombre AS 'Categoría',
    P.RazonSocial AS 'Proveedor'
FROM
    MEDICAMENTO M
    INNER JOIN ESTANTE E ON M.EstanteID = E.EstanteID
    INNER JOIN CATEGORIA C ON M.CategoriaID = C.CategoriaID
    INNER JOIN PROVEEDOR P ON M.ProveedorID = P.ProveedorID;
GO

SELECT TOP 10
    M.MedicamentoID AS 'ID',
    M.Codigo AS 'Cod.',
    M.Lote,
    M.Nombre,
    M.Stock AS 'Cantidad',
	M.PrecioCompra AS 'PrecioCompra',
    M.PrecioVenta AS 'PrecioVenta',
    M.FechaVencimiento AS 'VTO',
    E.Nombre AS 'Estante',
    E.Sector,
    E.Numero AS 'Num. Estante',
    C.Nombre AS 'Categoría', 
    P.RazonSocial AS 'Proveedor'
FROM
    MEDICAMENTO AS M
    INNER JOIN ESTANTE AS E ON M.EstanteID = E.EstanteID
    INNER JOIN CATEGORIA AS C ON M.CategoriaID = C.CategoriaID
    INNER JOIN PROVEEDOR AS P ON M.ProveedorID = P.ProveedorID;

 

DECLARE @desde DATE = '2024-01-01';
DECLARE @hasta DATE = '2025-12-31';
DECLARE @filtro VARCHAR(50) = 'Nombre';
DECLARE @buscar VARCHAR(50) = 'Ni';

SELECT
    M.MedicamentoID AS 'ID',
    M.Codigo AS 'Cod.',
    M.Lote AS 'Lote',
    M.Nombre AS 'Nombre',
    M.Stock AS 'Cantidad',
	M.PrecioCompra AS 'PrecioCompra',
    M.PrecioVenta AS 'PrecioVenta',
    M.FechaVencimiento AS 'VTO',
    E.Nombre AS 'Estante',
    E.Sector AS 'Sector',
    E.Numero AS 'Num. Estante',
    C.Nombre AS 'Categoría',
    P.RazonSocial AS 'Proveedor'
FROM
    MEDICAMENTO M
    INNER JOIN ESTANTE E ON M.EstanteID = E.EstanteID
    INNER JOIN CATEGORIA C ON M.CategoriaID = C.CategoriaID
    INNER JOIN PROVEEDOR P ON M.ProveedorID = P.ProveedorID
WHERE
    (@filtro = 'Código' AND M.Codigo LIKE '%' + @buscar + '%')
    OR (@filtro = 'Nombre' AND M.Nombre LIKE '%' + @buscar + '%')
    OR (@filtro = 'Lote' AND M.Lote LIKE '%' + @buscar + '%')
    OR (@filtro = 'Estante' AND E.Nombre LIKE '%' + @buscar + '%')
    OR (@filtro = 'Categoría' AND C.Nombre LIKE '%' + @buscar + '%')
    OR (@filtro = 'Proveedor' AND P.RazonSocial LIKE '%' + @buscar + '%')
    OR (@filtro = 'Vencimiento' AND M.FechaVencimiento >= @desde AND M.FechaVencimiento <= @hasta);

DECLARE @filtro VARCHAR(50) = 'Documento';
DECLARE @buscar VARCHAR(50) = '44';
SELECT
    P.ProveedorID AS 'ID',
    P.RazonSocial AS 'Razón Social',
    P.Documento AS 'Documento',
    P.Direccion AS 'Dirección',
    P.TelefonoProveedor AS 'Teléfono',
    P.Correo AS 'Correo'
FROM
    PROVEEDOR P
WHERE
    (@filtro = 'Razón Social' AND P.RazonSocial LIKE '%' + @buscar + '%')
    OR (@filtro = 'Documento' AND P.Documento LIKE '%' + @buscar + '%')
    OR (@filtro = 'Dirección' AND P.Direccion LIKE '%' + @buscar + '%')
    OR (@filtro = 'Teléfono' AND P.TelefonoProveedor LIKE '%' + @buscar + '%')
    OR (@filtro = 'Correo' AND P.Correo LIKE '%' + @buscar + '%');
GO;

SELECT * FROM ESTANTE
WHERE EstanteID > 0;
SELECT * FROM MEDICAMENTO;

SELECT * FROM CATEGORIA;
SELECT * FROM PROVEEDOR;
SELECT * FROM VistaInventario;
GO;


DECLARE @filtro VARCHAR(50) = 'Nombre';
DECLARE @buscar VARCHAR(50) = '';
SELECT
    P.ProductoID AS 'ID',
    P.Codigo AS 'Cod.',
    P.Nombre AS 'Nombre',
    P.Stock AS 'Cantidad',
    P.PrecioCompra AS 'PrecioCompra',
    P.PrecioVenta AS 'PrecioVenta',
    P.FechaRegistro AS 'FechaRegistro',
    E.Nombre AS 'Estante',
    E.Sector AS 'Sector',
    E.Numero AS 'Num. Estante',
    C.Nombre AS 'Categoría',
    PR.RazonSocial AS 'Proveedor'
FROM
    PRODUCTO P
    INNER JOIN ESTANTE E ON P.EstanteID = E.EstanteID
    INNER JOIN CATEGORIA C ON P.CategoriaID = C.CategoriaID
    INNER JOIN PROVEEDOR PR ON P.ProveedorID = PR.ProveedorID
WHERE
    (@filtro = 'Código' AND P.Codigo LIKE '%' + @buscar + '%')
    OR (@filtro = 'Nombre' AND P.Nombre LIKE '%' + @buscar + '%')
    OR (@filtro = 'Estante' AND E.Nombre LIKE '%' + @buscar + '%')
    OR (@filtro = 'Categoría' AND C.Nombre LIKE '%' + @buscar + '%')
    OR (@filtro = 'Proveedor' AND PR.RazonSocial LIKE '%' + @buscar + '%');
GO

-- CARGAR BASE DE DATOS
INSERT INTO MEDICAMENTO (Codigo, Nombre, Lote, FechaVencimiento, EstanteID, CategoriaID, ProveedorID, Stock, PrecioVenta, PrecioCompra)
VALUES
    ('COD001', 'Losartán', 'Lote001', '2023-12-01', 1, 1, 2, 0, 0, 0),
    ('COD002', 'Amoxicilina', 'Lote002', '2023-12-02', 2, 2, 3, 0, 0, 0),
    ('COD003', 'Omeprazol', 'Lote003', '2023-12-03', 3, 3, 4, 0, 0, 0),
    ('COD004', 'Metformina', 'Lote004', '2023-12-04', 4, 1, 5, 0, 0, 0),
    ('COD005', 'Morfina', 'Lote005', '2023-12-05', 5, 2, 2, 0, 0, 0),
    ('COD006', 'Paracetamol', 'Lote006', '2023-12-06', 6, 3, 3, 0, 0, 0),
    ('COD007', 'Ibuprofeno', 'Lote007', '2023-12-07', 1, 1, 4, 0, 0, 0),
    ('COD008', 'Aspirina', 'Lote008', '2023-12-08', 2, 2, 5, 0, 0, 0),
    ('COD009', 'Atorvastatina', 'Lote009', '2023-12-09', 3, 3, 2, 0, 0, 0),
    ('COD010', 'Enalapril', 'Lote010', '2023-12-10', 4, 1, 3, 0, 0, 0),
    ('COD011', 'Simvastatina', 'Lote011', '2023-12-11', 5, 2, 4, 0, 0, 0),
    ('COD012', 'Clonazepam', 'Lote012', '2023-12-12', 6, 3, 5, 0, 0, 0),
    ('COD013', 'Warfarina', 'Lote013', '2023-12-13', 1, 1, 2, 0, 0, 0),
    ('COD014', 'Gabapentina', 'Lote014', '2023-12-14', 2, 2, 3, 0, 0, 0),
    ('COD015', 'Hidroclorotiazida', 'Lote015', '2023-12-15', 3, 3, 4, 0, 0, 0);
GO