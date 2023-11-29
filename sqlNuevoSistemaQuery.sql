use FarmaciaDB;
-- Tabla para almacenar informaci�n sobre estantes en el inventario
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
GO

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
    FechaRegistro DATETIME DEFAULT GETDATE()
);
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

-- Eliminaci�n de Tablas
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
ALTER VIEW VistaInventario AS
SELECT
    M.MedicamentoID AS 'ID',
    M.Codigo AS 'Cod.',
    M.Lote AS 'Lote',
    M.Nombre AS 'Nombre',
    M.Stock AS 'Cantidad',
    M.FechaVencimiento AS 'VTO',
    E.Nombre AS 'Estante',
    E.Sector AS 'Sector',
    E.Numero AS 'Num. Estante',
    C.Nombre AS 'Categor�a',
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
    M.FechaVencimiento AS 'VTO',
    E.Nombre AS 'Estante',
    E.Sector,
    E.Numero AS 'Num. Estante',
    C.Nombre AS 'Categor�a', 
    P.RazonSocial AS 'Proveedor'
FROM
    MEDICAMENTO AS M
    INNER JOIN ESTANTE AS E ON M.EstanteID = E.EstanteID
    INNER JOIN CATEGORIA AS C ON M.CategoriaID = C.CategoriaID
    INNER JOIN PROVEEDOR AS P ON M.ProveedorID = P.ProveedorID;


SELECT
    M.MedicamentoID AS 'ID',
    M.Codigo AS 'Cod.',
    M.Lote AS 'Lote',
    M.Nombre AS 'Nombre',
    M.Stock AS 'Cantidad',
    M.FechaVencimiento AS 'VTO',
    E.Nombre AS 'Estante',
    E.Sector AS 'Sector',
    E.Numero AS 'Num. Estante',
    C.Nombre AS 'Categor�a',
    P.RazonSocial AS 'Proveedor'
FROM
    MEDICAMENTO M
    INNER JOIN ESTANTE E ON M.EstanteID = E.EstanteID
    INNER JOIN CATEGORIA C ON M.CategoriaID = C.CategoriaID
    INNER JOIN PROVEEDOR P ON M.ProveedorID = P.ProveedorID
WHERE
    (@filtro = 'C�digo' AND M.Codigo LIKE '%' + @buscar + '%')
    OR (@filtro = 'Nombre' AND M.Nombre LIKE '%' + @buscar + '%')
    OR (@filtro = 'Lote' AND M.Lote LIKE '%' + @buscar + '%')
    OR (@filtro = 'Estante' AND E.Nombre LIKE '%' + @buscar + '%')
    OR (@filtro = 'Categor�a' AND C.Nombre LIKE '%' + @buscar + '%')
    OR (@filtro = 'Proveedor' AND P.RazonSocial LIKE '%' + @buscar + '%')
    OR (@filtro = 'Vencimiento' AND M.FechaVencimiento >= @desde AND M.FechaVencimiento <= @hasta);


SELECT * FROM ESTANTE
WHERE EstanteID > 0;
SELECT * FROM MEDICAMENTO;

SELECT * FROM CATEGORIA;
SELECT * FROM PROVEEDOR;
SELECT * FROM VistaInventario;
GO;