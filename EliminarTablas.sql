use FarmaciaDB;


-- Elimina la tabla VentasModel
DROP TABLE VentasModel;

DROP TABLE PrecioVentaModel;

DROP TABLE CostoProductoModel;


-- Elimina la tabla DETALLE_VENTA
DROP TABLE DETALLE_VENTA;

-- Elimina la tabla PRODUCTO
DROP TABLE PRODUCTO;

-- Elimina la tabla DETALLE_COMPRA
DROP TABLE DETALLE_COMPRA;

-- Elimina la tabla MEDICAMENTO
DROP TABLE MEDICAMENTO;

-- Elimina la tabla CodigosDeBarrasModel
DROP TABLE CodigosDeBarrasModel;

-- Elimina la tabla LotesModel
DROP TABLE LotesModel;

-- Elimina la tabla PROVEEDORES
DROP TABLE PROVEEDORES;

-- Elimina la tabla CategoriasModel
DROP TABLE CategoriasModel;

-- Elimina la tabla ESTANTES
DROP TABLE ESTANTES;

-- Deshabilitar la propiedad IDENTITY para todas las tablas

-- Tabla ESTANTES
SET IDENTITY_INSERT ESTANTES ON;
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT ESTANTES OFF;

-- Tabla CategoriasModel
SET IDENTITY_INSERT CATEGORIA ON;


-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT CATEGORIA OFF;

-- Tabla PROVEEDORES
SET IDENTITY_INSERT PROVEEDOR ON;
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT PROVEEDOR OFF;
EXEC sp_ActivateIdentityInsert_CATEGORIA;
EXEC sp_DeactivateIdentityInsert_CATEGORIA;



--- --- --- --- --- --- --- --- ---
-- PROCEDIMIENTOS
CREATE PROCEDURE sp_ActivateIdentityInsert_CATEGORIA
AS
BEGIN
    SET IDENTITY_INSERT CATEGORIA ON;
END
GO

CREATE PROCEDURE sp_DeactivateIdentityInsert_CATEGORIA
AS
BEGIN
    SET IDENTITY_INSERT CATEGORIA OFF;
END
GO

CREATE PROCEDURE sp_ActivateIdentityInsert_PROVEEDOR
AS
BEGIN
    SET IDENTITY_INSERT PROVEEDOR ON;
END
GO

CREATE PROCEDURE sp_DeactivateIdentityInsert_PROVEEDOR
AS
BEGIN
    SET IDENTITY_INSERT PROVEEDOR OFF;
END
GO

CREATE PROCEDURE sp_ActivateIdentityInsert_ESTANTE
AS
BEGIN
    SET IDENTITY_INSERT ESTANTE ON;
END
GO

CREATE PROCEDURE sp_DeactivateIdentityInsert_ESTANTE
AS
BEGIN
    SET IDENTITY_INSERT ESTANTE OFF;
END
GO
--- --- --- --- --- --- --- --- ---

-- Tabla MEDICAMENTO
SET IDENTITY_INSERT MEDICAMENTO ON;
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT MEDICAMENTO OFF;

-- Tabla PRODUCTO
SET IDENTITY_INSERT PRODUCTO ON;
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT PRODUCTO OFF;

-- Tabla DETALLE_COMPRA
SET IDENTITY_INSERT DETALLE_COMPRA ON;
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT DETALLE_COMPRA OFF;



-- Tabla DETALLE_VENTA
SET IDENTITY_INSERT DETALLE_VENTA ON;
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT DETALLE_VENTA OFF;

-- Volver a habilitar IDENTITY para todas las tablas

-- Asegúrate de realizar esto solo si es necesario y si tienes copias de seguridad de tus datos.
