use FarmaciaDB;
-- Se actualizará toda la base de datos, Estantes, Categoría, Proveedores, Productos y Medicamentos deberán tener
-- Estados estos deben ser activos o inactivos, los estados se deben poder cambiar desde la interfaz de usuario
-- SE UTILIZARÁ LA PROPIEDAD BIT PARA LOS ESTADOS

-- Tabla para almacenar información sobre estantes en el inventario
CREATE TABLE ESTANTE (
    EstanteID INT IDENTITY PRIMARY KEY,
    Nombre NVARCHAR(255) NOT NULL,
    Sector NVARCHAR(255) NOT NULL,
    Estado BIT DEFAULT 1,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

SET IDENTITY_INSERT ESTANTE ON;
-- Estante default
INSERT INTO ESTANTE (EstanteID, Nombre, Sector, Estado)
VALUES (0, 'N/A', 'N/A', 1);
SET IDENTITY_INSERT ESTANTE OFF;

GO

SELECT * FROM CATEGORIA


CREATE TABLE CATEGORIA (
    CategoriaID INT IDENTITY PRIMARY KEY,
    Nombre NVARCHAR(255) NOT NULL,
    Descripcion NVARCHAR(255) NOT NULL,
    Estado BIT DEFAULT 1,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

SET IDENTITY_INSERT CATEGORIA ON;
INSERT INTO CATEGORIA (CategoriaID, Nombre, Descripcion, Estado)
VALUES (0, 'N/A', 'N/A', 1);
SET IDENTITY_INSERT CATEGORIA OFF;

GO

-- Crear 5 categorias -> genericos, bajo receta, perfumes, vitaminas, perfumes
INSERT INTO CATEGORIA (Nombre, Descripcion)
VALUES ('Genericos', 'Medicamentos genericos'),
('Bajo Receta', 'Medicamentos bajo receta'),
('Perfumes', 'Perfumes'),
('Vitaminas', 'Vitaminas'),
('Suplementos', 'Suplementos');


CREATE TABLE PROVEEDOR (
    ProveedorID INT IDENTITY PRIMARY KEY,
    RazonSocial VARCHAR(50),
    Documento VARCHAR(50),
    Direccion VARCHAR(50),
    TelefonoProveedor VARCHAR(20),
    Correo VARCHAR(50),
    Estado BIT DEFAULT 1,
    FechaRegistro DATETIME DEFAULT GETDATE()
);

SET IDENTITY_INSERT PROVEEDOR ON;
INSERT INTO PROVEEDOR (ProveedorID, RazonSocial, Documento, Direccion, TelefonoProveedor, Correo, Estado)
VALUES (0, 'N/A', 'N/A', 'N/A', 'N/A', 'N/A', 1);
SET IDENTITY_INSERT PROVEEDOR OFF;

GO

CREATE TABLE CLIENTE (
    ClienteID INT IDENTITY PRIMARY KEY,
    Documento VARCHAR(50),
    NombreCompleto VARCHAR(50),
    TipoClienteID INT REFERENCES TipoCliente(TipoClienteID),
    Correo VARCHAR(50),
    Telefono VARCHAR(50),
    Estado BIT DEFAULT 1,
    FechaRegistro DATETIME DEFAULT GETDATE()
);
SET IDENTITY_INSERT CLIENTE ON;
INSERT INTO CLIENTE (ClienteID, Documento, NombreCompleto, TipoClienteID, Correo, Telefono, Estado)
VALUES (0, 'N/A', 'N/A', 0, 'N/A', 'N/A', 1);
SET IDENTITY_INSERT CLIENTE OFF;
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

CREATE VIEW InventarioMedicamento AS
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
    C.Nombre AS 'Categoría',
    P.RazonSocial AS 'Proveedor',
    M.Estado AS 'Estado'
FROM
    MEDICAMENTO M
    INNER JOIN ESTANTE E ON M.EstanteID = E.EstanteID
    INNER JOIN CATEGORIA C ON M.CategoriaID = C.CategoriaID
    INNER JOIN PROVEEDOR P ON M.ProveedorID = P.ProveedorID
GO

CREATE VIEW InventarioProducto AS
SELECT
    P.ProductoID AS 'ID',
    P.Codigo AS 'Cod.',
    P.Nombre AS 'Nombre',
    P.Stock AS 'Cantidad',
    P.PrecioCompra AS 'PrecioCompra',
    P.PrecioVenta AS 'PrecioVenta',
    E.Nombre AS 'Estante',
    E.Sector AS 'Sector',
    C.Nombre AS 'Categoría',
    PR.RazonSocial AS 'Proveedor',
    P.Estado AS 'Estado',
    P.FechaRegistro AS 'FechaRegistro'
FROM
    PRODUCTO P
    INNER JOIN ESTANTE E ON P.EstanteID = E.EstanteID
    INNER JOIN CATEGORIA C ON P.CategoriaID = C.CategoriaID
    INNER JOIN PROVEEDOR PR ON P.ProveedorID = PR.ProveedorID;
GO


-- CARGAR BASE DE DATOS
-- Medicamentos con Estado true
INSERT INTO MEDICAMENTO (Codigo, Nombre, Lote, FechaVencimiento, EstanteID, CategoriaID, ProveedorID, Stock, PrecioVenta, PrecioCompra, Refrigerado, BajoReceta, Estado, FechaRegistro)
VALUES 
    ('COD001', 'Medicamento1', 'Lote001', '2024-12-01', 1, 1, 2, 100, 15.00, 10.00, 0, 0, 1, GETDATE()),
    ('COD002', 'Medicamento2', 'Lote002', '2023-11-01', 2, 2, 2, 50, 25.00, 20.00, 1, 0, 1, GETDATE()),
    ('COD003', 'Medicamento3', 'Lote003', '2025-05-01', 3, 3, 3, 80, 30.00, 25.00, 0, 1, 1, GETDATE());
GO
-- Medicamentos con Estado false
INSERT INTO MEDICAMENTO (Codigo, Nombre, Lote, FechaVencimiento, EstanteID, CategoriaID, ProveedorID, Stock, PrecioVenta, PrecioCompra, Refrigerado, BajoReceta, Estado, FechaRegistro)
VALUES 
    ('COD004', 'Medicamento4', 'Lote004', '2023-08-01', 4, 4, 4, 120, 40.00, 35.00, 1, 0, 0, GETDATE()),
    ('COD005', 'Medicamento5', 'Lote005', '2022-10-01', 5, 3, 5, 90, 18.00, 15.00, 0, 1, 0, GETDATE());
GO

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

