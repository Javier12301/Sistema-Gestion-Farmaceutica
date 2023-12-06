use FarmaciaDB;
GO


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
GO

-- TOP
DECLARE @TopCount int = 0;

SELECT TOP (@TopCount)
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
    P.RazonSocial AS 'Proveedor',
	M.Estado AS 'Estado'
FROM
    MEDICAMENTO AS M
    INNER JOIN ESTANTE AS E ON M.EstanteID = E.EstanteID
    INNER JOIN CATEGORIA AS C ON M.CategoriaID = C.CategoriaID
    INNER JOIN PROVEEDOR AS P ON M.ProveedorID = P.ProveedorID;
GO
 

-- FILTER
DECLARE @desde DATE = '01/05/2030';
DECLARE @hasta DATE = '02/06/2035';
DECLARE @filtro VARCHAR(50) = 'Nombre';
DECLARE @buscar VARCHAR(50) = 'Medicamento';
DECLARE @estado INT = NULL; -- 1 para Medicamentos activos, ajusta según tu lógica de estados

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
    P.RazonSocial AS 'Proveedor',
    M.Estado AS 'Estado'
FROM
    MEDICAMENTO M
    INNER JOIN ESTANTE E ON M.EstanteID = E.EstanteID
    INNER JOIN CATEGORIA C ON M.CategoriaID = C.CategoriaID
    INNER JOIN PROVEEDOR P ON M.ProveedorID = P.ProveedorID
WHERE
    (
        @filtro = 'Código' AND M.Codigo LIKE '%' + @buscar + '%'
        OR @filtro = 'Nombre' AND M.Nombre LIKE '%' + @buscar + '%'
        OR @filtro = 'Lote' AND M.Lote LIKE '%' + @buscar + '%'
        OR @filtro = 'Estante' AND E.Nombre LIKE '%' + @buscar + '%'
        OR @filtro = 'Categoría' AND C.Nombre LIKE '%' + @buscar + '%'
        OR @filtro = 'Proveedor' AND P.RazonSocial LIKE '%' + @buscar + '%'
        OR @filtro = 'Vencimiento' AND M.FechaVencimiento >= @desde AND M.FechaVencimiento <= @hasta
    )
    AND (M.Estado = @estado OR @estado IS NULL);
GO

-- FILTRO PROVEEDOR
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


-- SELECT
SELECT * FROM ESTANTE
SELECT * FROM CATEGORIA;
SELECT * FROM TipoCliente

SELECT * FROM MEDICAMENTO;

SELECT * FROM PROVEEDOR;
SELECT * FROM VistaInventario;
GO;

-- Filtrar Producto
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
    P.RazonSocial AS 'Proveedor'
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

-- FILTER
DECLARE @desde DATE = NULL; -- Ajusta a NULL para indicar 'sin filtro'
DECLARE @hasta DATE = NULL; -- Ajusta a NULL para indicar 'sin filtro'
DECLARE @filtro VARCHAR(50) = 'Nombre';
DECLARE @buscar VARCHAR(50) = '';
DECLARE @estado INT = NULL; -- 1 para Medicamentos activos, ajusta según tu lógica de estados

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
    P.RazonSocial AS 'Proveedor',
    M.Estado AS 'Estado'
FROM
    MEDICAMENTO M
    INNER JOIN ESTANTE E ON M.EstanteID = E.EstanteID
    INNER JOIN CATEGORIA C ON M.CategoriaID = C.CategoriaID
    INNER JOIN PROVEEDOR P ON M.ProveedorID = P.ProveedorID
WHERE
    (
        (@filtro = 'Código' AND M.Codigo LIKE '%' + @buscar + '%')
        OR (@filtro = 'Nombre' AND M.Nombre LIKE '%' + @buscar + '%')
        OR (@filtro = 'Lote' AND M.Lote LIKE '%' + @buscar + '%')
        OR (@filtro = 'Estante' AND E.Nombre LIKE '%' + @buscar + '%')
        OR (@filtro = 'Categoría' AND C.Nombre LIKE '%' + @buscar + '%')
        OR (@filtro = 'Proveedor' AND P.RazonSocial LIKE '%' + @buscar + '%')
    )
    AND ((@desde IS NOT NULL AND @hasta IS NOT NULL AND M.FechaVencimiento >= @desde AND M.FechaVencimiento <= @hasta) OR (@desde IS NULL AND @hasta IS NULL))
    AND (M.Estado = @estado OR @estado IS NULL)
    AND M.MedicamentoID > 0;
