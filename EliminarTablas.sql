use SistemaGestionFarmaceutica;


-- Elimina la tabla VentasModel
DROP TABLE VentasModel;

DROP TABLE PrecioVentaModel;

DROP TABLE CostoProductoModel;


-- Elimina la tabla ProductosModel
DROP TABLE ProductosModel;

-- Elimina la tabla MedicamentosProveedoresModel
DROP TABLE MedicamentosProveedoresModel;

-- Elimina la tabla MedicamentosLotesModel
DROP TABLE MedicamentosLotesModel;

-- Elimina la tabla MedicamentosModel
DROP TABLE MedicamentosModel;

-- Elimina la tabla CodigosDeBarrasModel
DROP TABLE CodigosDeBarrasModel;

-- Elimina la tabla LotesModel
DROP TABLE LotesModel;

-- Elimina la tabla ProveedoresModel
DROP TABLE ProveedoresModel;

-- Elimina la tabla CategoriasModel
DROP TABLE CategoriasModel;

-- Elimina la tabla EstantesModel
DROP TABLE EstantesModel;

-- Deshabilitar la propiedad IDENTITY para todas las tablas

-- Tabla EstantesModel
SET IDENTITY_INSERT EstantesModel ON;
INSERT INTO EstantesModel (EstanteID, NombreEstante, NumeroEstante, SectorEstante)
VALUES (0, 'N/A', 0, 'N/A');
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT EstantesModel OFF;

-- Tabla CategoriasModel
SET IDENTITY_INSERT CategoriasModel ON;
INSERT INTO CategoriasModel (CategoriaID, NombreCategoria, DescripcionCategoria)
VALUES (0, 'N/A', 'N/A');
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT CategoriasModel OFF;

-- Tabla ProveedoresModel
SET IDENTITY_INSERT ProveedoresModel ON;
INSERT INTO ProveedoresModel (ProveedorID, NombreProveedor, DireccionProveedor, TelefonoProveedor)
VALUES (0, 'N/A', 'N/A', 'N/A');
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT ProveedoresModel OFF;

-- Tabla CodigosDeBarrasModel
SET IDENTITY_INSERT CodigosDeBarrasModel ON;
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT CodigosDeBarrasModel OFF;

-- Tabla LotesModel
SET IDENTITY_INSERT LotesModel ON;
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT LotesModel OFF;

-- Tabla MedicamentosModel
SET IDENTITY_INSERT MedicamentosModel ON;
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT MedicamentosModel OFF;

-- Tabla MedicamentosLotesModel
SET IDENTITY_INSERT MedicamentosLotesModel ON;
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT MedicamentosLotesModel OFF;

-- Tabla MedicamentosProveedoresModel
SET IDENTITY_INSERT MedicamentosProveedoresModel ON;
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT MedicamentosProveedoresModel OFF;

-- Tabla ProductosModel
SET IDENTITY_INSERT ProductosModel ON;
-- Volver a habilitar IDENTITY
SET IDENTITY_INSERT ProductosModel OFF;

-- Volver a habilitar IDENTITY para todas las tablas

-- Asegúrate de realizar esto solo si es necesario y si tienes copias de seguridad de tus datos.
